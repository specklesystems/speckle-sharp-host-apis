using System.Reflection;
using System.Text;

namespace Speckle.Shared;

public record GeneratedMember(string Name);
public record GeneratedTypeInfo(string Name, string? Base, List<GeneratedMember> Members);
public class Generator
{
  private readonly Dictionary<string, bool> _boolDone = new();
  private readonly Dictionary<string, GeneratedTypeInfo> _info = new();
  private readonly string _path;
  private readonly Assembly[] _assemblies;
  private readonly string[] _namespaces;

  public Generator(string path, Assembly[] assemblies, string[] namespaces)
  {
    _path = Path.Combine(Environment.CurrentDirectory,  "..", "..", "..", "..", path, "generated");
    _assemblies = assemblies;
    _namespaces = namespaces;
    AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += CurrentDomainOnReflectionOnlyAssemblyResolve;
  }

  private Assembly? CurrentDomainOnReflectionOnlyAssemblyResolve(object? sender, ResolveEventArgs args)
  {
    string name = args.Name.Split(',')[0];

    if (!name.StartsWith("System") && !name.StartsWith("Presentation")&& !name.StartsWith("Windows"))
    {
      return null;
    }
    string assemblyFile = Path.Combine("C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.8", name + ".dll");

    if (File.Exists(assemblyFile))
    {
      return Assembly.ReflectionOnlyLoadFrom(assemblyFile);
    }
    return null;
  }

  public void Generate()
  {
    if (Directory.Exists(_path))
    {
      Directory.Delete(_path, true);
    }

    if (!Directory.Exists(_path))
    {
      Directory.CreateDirectory(_path);
    }

    List<Type> definedTypes;
    try
    {
      definedTypes = _assemblies.SelectMany(x => x.GetExportedTypes()).ToList();
    }catch (ReflectionTypeLoadException e)
    {
      definedTypes = e.Types.ToList();
    }

    definedTypes = definedTypes.Where(x => x.IsPublic)
      .Where(x => _namespaces.Any(y => x.FullName?.StartsWith(y) ?? false)).ToList();
    foreach (var type in definedTypes)//.Where(x => x.FullName.EndsWith("ImageView")))
    {
      try
      {
        RenderType(type);
      }
      catch (ApplicationException)
      {
        Console.WriteLine($"Did not write type {type.FullName}");
        _boolDone[type.FullName] = false;
      }
    }
  }

  private Type RenderType(Type type)
  {
    if (type.FullName.StartsWith("System.Drawing."))
    {
      throw new ApplicationException($"Not dealing with base types: {type.FullName}");
    }
    if (type.FullName.StartsWith("System.Windows") || type.FullName.StartsWith("System.MulticastDelegate"))
    {
      throw new ApplicationException($"Not dealing with base WPF types: {type.FullName}");
    }
    if (type.FullName.StartsWith("Autodesk.Revit.DB.Plumbing") 
        || type.FullName.StartsWith("Autodesk.Revit.DB.Electrical")
        || type.FullName.StartsWith("Autodesk.Revit.DB.Fabrication"))
    {
      throw new ApplicationException($"Not dealing with base WPF types: {type.FullName}");
    }
    if (type.FullName.StartsWith("System."))
    {
      return type;
    }
    if (type.FullName is null || !_namespaces.Contains(type.Namespace))
    {
      return type;
    }

    if (_boolDone.TryGetValue(type.FullName, out var isDone))
    {
      if (isDone)
      {
        return type;
      }
      throw new ApplicationException($"Can't use skipped type: {type.FullName}");
    }
    _boolDone[type.FullName] = true;
    var generatedInfo = WriteType(type);
    _info[type.FullName] = generatedInfo;
    return type;
  }

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
    return (sb.ToString(), new (clazz.FullName, null, []));
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
   
    var members = WriteTypeBody(sb, clazz, false);
    return (sb.ToString(), new(clazz.FullName, baseClazz, members));
  }

  private (string, GeneratedTypeInfo)  WriteStruct(Type clazz)
  {
    StringBuilder sb = new();
    sb.AppendLine($"namespace {clazz.Namespace};").AppendLine();
    sb.Append($"public partial struct {clazz.Name}");
    var members = WriteTypeBody(sb, clazz, true);
    return (sb.ToString(), new(clazz.FullName, null, members));
  }

  private  List<GeneratedMember>  WriteTypeBody( StringBuilder sb, Type clazz, bool isStruct)
  {
    sb.AppendLine();
    sb.AppendLine("{");
    var members = new List<GeneratedMember>();
    foreach(var method in clazz.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public))
    {
      if (method.IsSpecialName)
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
    foreach(var propertyInfo in clazz.GetProperties(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public))
    {
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
    return members;
  }
  
  private void WriteProperty(StringBuilder sb, PropertyInfo propertyInfo, bool isStruct)
  {
    var wrotePropHeader = false;
    var getMethod = propertyInfo.GetGetMethod(false);
    if (getMethod is not null)
    {

      if (getMethod.GetParameters().Any())
      {
        throw new ApplicationException($"getter has parameters {propertyInfo.Name}");
      }
      bool isOverriden = getMethod.GetBaseDefinition().DeclaringType != propertyInfo.DeclaringType;
      if (wrotePropHeader is false)
      {
        wrotePropHeader = true;
        WritePropertyHeader(sb, propertyInfo,isStruct, isOverriden, getMethod.ReturnType);
      }
      sb.AppendLine("\t\tget => throw new System.NotImplementedException();");
    }
    var setMethod = propertyInfo.GetSetMethod(false);
    if (setMethod is not null) 
    {
      var parameters = setMethod.GetParameters();
      if (parameters.Length > 1)
      {
        throw new ApplicationException($"setter has more than one parameter {propertyInfo.Name}");
      }
      bool isOverriden = setMethod.GetBaseDefinition().DeclaringType != propertyInfo.DeclaringType;
      if (wrotePropHeader is false)
      {
        WritePropertyHeader(sb, propertyInfo, isStruct, isOverriden, parameters[0].ParameterType);
      }
      sb.AppendLine("\t\tset {}");
    }
    sb.AppendLine("\t}");
  }

  private void WritePropertyHeader(StringBuilder sb, PropertyInfo property, bool isStruct, bool isOverriden, Type returnType)
  {
    var extra = string.Empty;
    if (!isStruct)
    {
      extra = isOverriden ? "override" : "virtual";
      if (IsMemberOnBaseClass(property.DeclaringType?.BaseType?.FullName, new(property.Name)))
      {
        extra = "new";
      }
    }

    sb.AppendLine($"public {extra} {ReturnType(returnType)} {property.Name}");
    sb.AppendLine("\t{");
  }

  private void WriteMethod(StringBuilder sb, MethodInfo methodInfo)
  {
    if (methodInfo.GetBaseDefinition().DeclaringType != methodInfo.DeclaringType)
    {
      throw new ApplicationException("not base property?");
    }

    var extras = "virtual";
    if (methodInfo.IsStatic)
    {
      extras = "static";

      if (IsMemberOnBaseClass(methodInfo.DeclaringType?.BaseType?.FullName, new (methodInfo.Name)))
      {
        extras = "new " + extras;
      }
    }


    sb.Append($"public {extras} {ReturnType(methodInfo.ReturnType)} {methodInfo.Name}(");
    bool isFirst = true;
    foreach (var parameter in methodInfo.GetParameters())
    {
      if (isFirst)
      {
        isFirst = false;
      }
      else
      {
        sb.Append(",");
      }
      sb.Append(ParameterType(parameter.ParameterType)).Append(" ").Append(FixName(parameter.Name));
    }

    sb.AppendLine(") => throw new System.NotImplementedException();");
  }
  
  private string ParameterType(Type type)
  {
    if (type.IsByRef)
    {
      throw new ApplicationException("Not Handling References");
    }

    if (!_namespaces.Contains(type.Namespace) && !type.Namespace.StartsWith("System")
        && !type.Namespace.StartsWith("System.Drawing"))
    {
      throw new ApplicationException($"Not Handling: {type.FullName}");
    }
    return FormGenericType(type);
  }

  private string ReturnType(Type type)
  {
    if (type == typeof(void))
    {
      return "void";
    }
    return ParameterType(type);
  }

  private string FormGenericType(Type type)
  {
     type = RenderType(type);
     if (!type.IsGenericType)
     {
       return type.FullName.NotNull();
     }

     var nonGenericName = type.Name.Split('`').First();
     return $"{nonGenericName}<{string.Join(", ", type.GetGenericArguments().Select(ta => FormGenericType(ta)))}>";
  }

  private string FixName(string name) =>
    name switch
    {
      "lock" or "params" or "string" => "@" + name,
      _ => name
    };
}
