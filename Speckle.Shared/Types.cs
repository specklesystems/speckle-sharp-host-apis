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
    if (clazz.BaseType is not null)
    {
      RenderType(clazz.BaseType);
      sb.Append($" : {clazz.BaseType.FullName}");
      baseClazz = clazz.BaseType.FullName;
    }
   
    var (constructors, members) = WriteTypeBody(sb, clazz, false);
    return (sb.ToString(), new(clazz.FullName, baseClazz, constructors, members));
  }

  private (string, GeneratedTypeInfo)  WriteStruct(Type clazz)
  {
    StringBuilder sb = new();
    sb.AppendLine($"namespace {clazz.Namespace};").AppendLine();
    sb.Append($"public partial struct {clazz.Name}");
    var (constructors, members) = WriteTypeBody(sb, clazz, true);
    return (sb.ToString(), new(clazz.FullName, null, constructors, members));
  }

  private (List<GeneratedConstructor>, List<GeneratedMember>)  WriteTypeBody( StringBuilder sb, Type clazz, bool isStruct)
  {
    sb.AppendLine();
    sb.AppendLine("{");
    var members = new List<GeneratedMember>();
   var constructors = WriteConstructors(sb, clazz);
    foreach(var method in clazz.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public))
    {
      if (method.IsSpecialName //special is get/set for properties
                               || IsExcluded(clazz.Name, method.Name))
      {
        continue;
      }
      try
      {
        var methodSb = new StringBuilder();
        methodSb.Append("\t");
        WriteMethod(methodSb, method);
        sb.Append(methodSb);
        members.Add(new (method.Name));
      }
      catch (FileLoadException)
      {
        Console.WriteLine($"Did not write {method.Name} on {clazz.FullName}");
        
      }
      catch (ApplicationException)
      {
        Console.WriteLine($"Did not write {method.Name} on {clazz.FullName}");
      }
    }
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
        WriteProperty(methodSb, propertyInfo, isStruct);
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
