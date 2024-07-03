using System.Reflection;
using System.Text;

namespace Speckle.Shared;

public partial class Generator
{
  private bool IsMemberOnBaseClass(string? baseClazz, GeneratedMember member)
  {
    if (baseClazz is null)
    {
      return false;
    }
    if (!_info.TryGetValue(baseClazz, out var info))
    {
      return false;
    }
    if (info.Members.Contains(member))
    {
      return true;
    }

    if (info.Base is null)
    {
      return false;
    }
    return IsMemberOnBaseClass(info.Base, member);
  }

  private GeneratedTypeInfo WriteType(Type type)
  {
    string typeString;
    GeneratedTypeInfo typeInfo;
    if (type.IsEnum)
    {
      (typeString, typeInfo) = WriteEnum(type);
    }
    else if (type.IsValueType || type.BaseType == typeof(ValueType))
    {
      (typeString, typeInfo) = WriteStruct(type);
    }
    else if (type.IsInterface)
    {
      (typeString, typeInfo) = WriteInterface(type);
    }
    else
    {
      (typeString, typeInfo) = WriteClass(type);
    }

    try
    {
      File.WriteAllText(Path.Combine(_path, $"{type.FullName}.s.cs"), typeString);
    }
    catch (ArgumentException e)
    {
      Console.WriteLine(e);
      throw;
    }

    return typeInfo;
  }

  //can't get values from enum in reflection
  private (string, GeneratedTypeInfo) WriteEnum(Type clazz)
  {
    var declaringClass = clazz.DeclaringType;
    var leading = declaringClass is null ? string.Empty : "\t";
    StringBuilder sb = new();
    sb.AppendLine($"namespace {clazz.Namespace};").AppendLine();
    if (declaringClass is not null)
    {
      sb.AppendLine($"public partial class {FormNameOnly(declaringClass)}");
      sb.AppendLine("{");
    }
    sb.AppendLine($"{leading}public enum {clazz.Name}");
    sb.AppendLine($"{leading}{{");
    foreach (var field in clazz.GetFields(BindingFlags.Public | BindingFlags.Static))
    {
      sb.AppendLine($"{leading}\t{field.Name},");
    }
    sb.AppendLine($"{leading}}}");
    if (declaringClass is not null)
    {
      sb.AppendLine("}");
    }
    return (sb.ToString(), new(clazz.FullName, null, [], []));
  }

  private (string, GeneratedTypeInfo) WriteClass(Type clazz)
  {
    var isOpenGeneric = clazz.GenericTypeArguments.Length > 0;
    var declaringClass = clazz.DeclaringType;
    var leading = declaringClass is null ? string.Empty : "\t";
    StringBuilder sb = new();
    sb.AppendLine($"namespace {clazz.Namespace};").AppendLine();
    if (declaringClass is not null)
    {
      sb.AppendLine($"{leading}public partial class {FormNameOnly(declaringClass)}");
      sb.AppendLine($"{leading}{{");
    }
    sb.Append($"{leading}public partial class {FormGenericNameOnly(clazz, false)}");
    string? baseClazz = null;
    bool appended = false;
    bool isFirst = true;
    if (clazz.BaseType is not null && clazz.BaseType != typeof(object))
    {
      sb.Append($" : {FormGenericFullNameOnly(clazz.BaseType, isOpenGeneric)}");
      baseClazz = clazz.BaseType.FullName;
      appended = true;
      isFirst = false;
    }

    var interfaces = GetInterfaces(clazz);
    if (interfaces.Any())
    {
      if (!appended)
      {
        sb.Append(" : ");
      }
      foreach (var i in interfaces)
      {
        if (!isFirst)
        {
          sb.Append(",");
        }
        else
        {
          isFirst = false;
        }
        sb.Append(FormGenericType(i, isOpenGeneric));
      }
    }

    var (constructors, members) = WriteTypeBody(sb, clazz, GeneratedType.Class);
    if (declaringClass is not null)
    {
      sb.AppendLine("}");
    }
    return (sb.ToString(), new(clazz.FullName, baseClazz, constructors, members));
  }

  private List<Type> GetInterfaces(Type clazz)
  {
    if (clazz.BaseType is null || clazz.BaseType == typeof(object))
    {
      return clazz.GetInterfaces().ToList();
    }
    var interfaces = clazz.GetInterfaces().Except(clazz.BaseType?.GetInterfaces() ?? Enumerable.Empty<Type>()).ToList();
    return interfaces.Except(interfaces.SelectMany(i => i.GetInterfaces())).ToList();
  }

  private (string, GeneratedTypeInfo) WriteStruct(Type clazz)
  {
    StringBuilder sb = new();
    sb.AppendLine($"namespace {clazz.Namespace};").AppendLine();
    sb.Append($"public partial class {clazz.Name}");
    bool appended = false;
    bool isFirst = true;
    var interfaces = GetInterfaces(clazz);
    if (interfaces.Any())
    {
      if (!appended)
      {
        sb.Append(" : ");
      }
      foreach (var i in interfaces)
      {
        if (!isFirst)
        {
          sb.Append(",");
        }
        else
        {
          ;
          isFirst = false;
        }
        sb.Append(FormGenericType(i, false));
      }
    }
    var (constructors, members) = WriteTypeBody(sb, clazz, GeneratedType.Struct);
    return (sb.ToString(), new(clazz.FullName, null, constructors, members));
  }

  private (string, GeneratedTypeInfo) WriteInterface(Type clazz)
  {
    StringBuilder sb = new();
    sb.AppendLine($"namespace {clazz.Namespace};").AppendLine();
    sb.Append($"public partial interface {FormGenericNameOnly(clazz, false)}");
    var (constructors, members) = WriteTypeBody(sb, clazz, GeneratedType.Interface);
    return (sb.ToString(), new(clazz.FullName, null, constructors, members));
  }

  private (List<GeneratedConstructor>, List<GeneratedMember>) WriteTypeBody(
    StringBuilder sb,
    Type clazz,
    GeneratedType generatedType
  )
  {
    sb.AppendLine();
    sb.AppendLine("{");
    List<GeneratedConstructor> constructors = new();
    if (generatedType != GeneratedType.Interface)
    {
      constructors = WriteConstructors(sb, clazz);
    }
    WriteFields(sb, clazz, generatedType);

    var methods = WriteMethods(sb, clazz, generatedType);
    var properties = WriteProperties(sb, clazz, generatedType);
    sb.AppendLine("}");
    return (constructors, properties.Concat(methods).ToList());
  }

  private void WriteFields(StringBuilder sb, Type clazz, GeneratedType generatedType)
  {
    var bindingAttributes = BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly;
    foreach (var field in clazz.GetFields(bindingAttributes))
    {
      sb.AppendLine($"public {FormGenericType(field.FieldType, false)} {field.Name};");
    }
  }
}
