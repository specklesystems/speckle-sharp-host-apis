using System.Reflection;
using System.Text;

namespace Speckle.Shared;

public class Generator
{
  private readonly Dictionary<string, bool> _boolDone = new();
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
    foreach (var type in definedTypes)
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
    if (type.FullName.StartsWith("System.Windows") || type.FullName.StartsWith("System.MulticastDelegate"))
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
    WriteType(type);
    return type;
  }

  private void WriteType(Type type)
  {
    string typeString;
    if (type.IsEnum)
    {
      typeString = WriteEnum(type);
    }
    else if (type.IsValueType || type.BaseType == typeof(ValueType))
    {
      typeString = WriteStruct(type);
    }
    else
    {
      typeString = WriteClass(type);
    }
    File.WriteAllText(Path.Combine(_path, $"{type.FullName}.s.cs"), typeString);

  }

  private string WriteEnum(Type clazz)
  {
    StringBuilder sb = new();
    sb.AppendLine($"namespace {clazz.Namespace};").AppendLine();
    sb.AppendLine($"public enum {clazz.Name}");
    sb.AppendLine("{");
    sb.AppendLine("}");
    return sb.ToString();
  }
  
  
  private string WriteClass(Type clazz)
  {
    StringBuilder sb = new();
    sb.AppendLine($"namespace {clazz.Namespace};").AppendLine();
    sb.Append($"public partial class {clazz.Name}");
    if (clazz.BaseType is not null)
    {
      RenderType(clazz.BaseType);
      sb.Append($" : {clazz.BaseType.FullName}");
    }
   
    WriteTypeBody(sb, clazz);
    return sb.ToString();
  }

  private string WriteStruct(Type clazz)
  {
    StringBuilder sb = new();
    sb.AppendLine($"namespace {clazz.Namespace};").AppendLine();
    sb.Append($"public partial struct {clazz.Name}");
    WriteTypeBody(sb, clazz);
    return sb.ToString();
  }

  private void WriteTypeBody( StringBuilder sb, Type clazz)
  {
    sb.AppendLine();
    sb.AppendLine("{");
    foreach(var method in clazz.GetMethods(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public))
    {
      try
      {
        var methodSb = new StringBuilder();
        methodSb.Append("\t");
        WriteMethod(methodSb, method);
        sb.Append(methodSb);
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
    sb.AppendLine("}");
    
  }

  private void WriteMethod(StringBuilder sb, MethodInfo methodInfo)
  {
    if (methodInfo.IsVirtual)
    {
      return;
    }
    sb.Append($"public virtual {ReturnType(methodInfo.ReturnType)} {methodInfo.Name}(");
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

    if (!_namespaces.Contains(type.Namespace))
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
      "lock" or "params" => "@" + name,
      _ => name
    };
}
