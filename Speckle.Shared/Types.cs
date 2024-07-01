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
      (typeString, typeInfo)  = WriteStruct(type);
    }
    else if (type.IsInterface)
    {
      (typeString, typeInfo)  = WriteInterface(type);
    }
    else
    {
      (typeString, typeInfo)  = WriteClass(type);
    }
    File.WriteAllText(Path.Combine(_path, $"{type.FullName}.s.cs"), typeString);
    return typeInfo;
  }

  //can't get values from enum in reflection
  private (string, GeneratedTypeInfo) WriteEnum(Type clazz)
  {
    StringBuilder sb = new();
    sb.AppendLine($"namespace {clazz.Namespace};").AppendLine();
    sb.AppendLine($"public enum {clazz.Name}");
    sb.AppendLine("{");
    foreach (var field in clazz.GetFields(BindingFlags.Public | BindingFlags.Static))
    {
      sb.AppendLine($"\t{field.Name},");
    }
    sb.AppendLine("}");
    return (sb.ToString(), new (clazz.FullName, null, [],  []));
  }
  
  
  private (string, GeneratedTypeInfo)  WriteClass(Type clazz)
  {
    StringBuilder sb = new();
    sb.AppendLine($"namespace {clazz.Namespace};").AppendLine();
    sb.Append($"public partial class {clazz.Name}");
    string? baseClazz = null;
    bool appended = false;
    bool isFirst = true;
    if (clazz.BaseType is not null && clazz.BaseType != typeof(object))
    {
      RenderType(clazz.BaseType);
      sb.Append($" : {clazz.BaseType.FullName}");
      baseClazz = clazz.BaseType.FullName;
      appended = true;
      isFirst = false;
    }
    var interfaces = clazz.GetInterfaces().Except(clazz.BaseType?.GetInterfaces() ?? Enumerable.Empty<Type>()).ToList();
    interfaces = interfaces.Except(interfaces.SelectMany(i => i.GetInterfaces())).ToList();
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
        {;
          isFirst = false;
        }
        sb.Append(FormGenericType(i));
      }
    }
   
    var (constructors, members) = WriteTypeBody(sb, clazz, GeneratedType.Class);
    return (sb.ToString(), new(clazz.FullName, baseClazz, constructors, members));
  }

  private (string, GeneratedTypeInfo)  WriteStruct(Type clazz)
  {
    StringBuilder sb = new();
    sb.AppendLine($"namespace {clazz.Namespace};").AppendLine();
    sb.Append($"public partial struct {clazz.Name}");
    var (constructors, members) = WriteTypeBody(sb, clazz, GeneratedType.Struct);
    return (sb.ToString(), new(clazz.FullName, null, constructors, members));
  }
  
  private (string, GeneratedTypeInfo)  WriteInterface(Type clazz)
  {
    StringBuilder sb = new();
    sb.AppendLine($"namespace {clazz.Namespace};").AppendLine();
    sb.Append($"public partial interface {clazz.Name}");
    var (constructors, members) = WriteTypeBody(sb, clazz, GeneratedType.Interface);
    return (sb.ToString(), new(clazz.FullName, null, constructors, members));
  }

  private (List<GeneratedConstructor>, List<GeneratedMember>)  WriteTypeBody( StringBuilder sb, Type clazz, GeneratedType generatedType)
  {
    sb.AppendLine();
    sb.AppendLine("{");
    List<GeneratedConstructor> constructors = new();
    if (generatedType != GeneratedType.Interface)
    {
       constructors = WriteConstructors(sb, clazz);
    }
   var members = WriteMethods(sb, clazz, generatedType);
    foreach(var propertyInfo in clazz.GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public))
    {
      if (IsExcluded(clazz.Name, propertyInfo.Name))
      {
        continue;
      }
      try
      {
        var methodSb = new StringBuilder();
        methodSb.Append("\t");
        WriteProperty(methodSb, propertyInfo, generatedType);
        sb.Append(methodSb);
        members.Add(new (propertyInfo.Name));
      }
      catch (FileLoadException)
      {
        Console.WriteLine($"Did not write {propertyInfo.Name} on {clazz.FullName}");
        
      }
      catch (ApplicationException)
      {
        Console.WriteLine($"Did not write {propertyInfo.Name} on {clazz.FullName}");
      }
    }
    sb.AppendLine("}");
    return (constructors, members);
  }
}
