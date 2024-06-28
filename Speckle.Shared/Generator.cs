using System.Reflection;
using System.Text;

namespace Speckle.Shared;

public class Generator
{
  private readonly Dictionary<string, bool> _boolDone = new();
  private readonly string _path;
  private readonly Assembly _assembly;
  private readonly string[] _namespaces;

  public Generator(string path, Assembly assembly, string[] namespaces)
  {
    _path = Path.Combine(Environment.CurrentDirectory,  "..", "..", "..", "..", path);
    _assembly = assembly;
    _namespaces = namespaces;
    AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += CurrentDomainOnReflectionOnlyAssemblyResolve;
  }

  private Assembly? CurrentDomainOnReflectionOnlyAssemblyResolve(object sender, ResolveEventArgs args)
  {
    string name = args.Name.Split(',')[0];

    if (!name.StartsWith("System"))
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
    List<Type> definedTypes;
    try
    {
      definedTypes = _assembly.GetExportedTypes().ToList();
    }catch (ReflectionTypeLoadException e)
    {
      definedTypes = e.Types.ToList();
    }

    definedTypes = definedTypes.Where(x => x.IsPublic)
      .Where(x => _namespaces.Any(y => x.FullName?.StartsWith(y) ?? false)).ToList();
    foreach (var type in definedTypes)
    {
      if (type.IsClass)
      {
        RenderType(type);
      }
    }
  }

  private Type RenderType(Type type)
  {
    if (type.FullName is null || !_namespaces.Contains(type.Namespace))
    {
      return type;
    }
    if (type.FullName.StartsWith("System."))
    {
      return type;
    }

    if (_boolDone.TryGetValue(type.FullName, out _))
    {
      return type;
    }
    _boolDone[type.FullName] = true;
    if (type.IsEnum)
    {
      WriteEnum(type);
    }
    else
    {
      WriteClass(type);
    }

    return type;
  }

  private void WriteEnum(Type clazz)
  {
    StringBuilder sb = new();
    sb.AppendLine($"namespace {clazz.Namespace};").AppendLine();
    sb.AppendLine($"public enum {clazz.Name}");
    sb.AppendLine("{");
    sb.AppendLine("}");
    File.WriteAllText(Path.Combine(_path, $"{clazz.FullName}.s.cs"), sb.ToString());
  }

  private void WriteClass(Type clazz)
  {
    StringBuilder sb = new();
    sb.AppendLine($"namespace {clazz.Namespace};").AppendLine();
    sb.Append($"public partial class {clazz.Name}");
    if (clazz.BaseType is not null)
    {
      RenderType(clazz.BaseType);
      sb.Append($" : {clazz.BaseType.FullName}");
    }
    sb.AppendLine();
    sb.AppendLine("{");
    foreach(var method in clazz.GetMethods(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public))
    {
      sb.Append("\t");
      try
      {
        WriteMethod(sb, method);
      }
      catch (FileLoadException)
      {
        Console.WriteLine($"Did not write {method.Name} on {clazz.FullName}");
      }
    }
    sb.AppendLine("}");
    File.WriteAllText(Path.Combine(_path, $"{clazz.FullName}.s.cs"), sb.ToString());
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
      sb.Append(ParameterType(parameter.ParameterType)).Append(" ").Append(parameter.Name);
    }

    sb.AppendLine(") => throw new System.NotImplementedException();");
  }
  
  private string ParameterType(Type type)
  {
    if (type.IsByRef)
    {
      throw new ApplicationException("Not Handling References");
    }
    return FormGenericType(type);
  }

  private string ReturnType(Type type)
  {
    if (type == typeof(void))
    {
      return "void";
    }

    if (type.IsByRef)
    {
      throw new ApplicationException("Not Handling References");
    }
    return FormGenericType(type);
  }

  private string FormGenericType(Type type)
  {
     type = RenderType(type);
     if (!type.IsGenericType)
     {
       return type.FullName;
     }

     var nonGenericName = type.Name.Split('`').First();
     return $"{nonGenericName}<{string.Join(", ", type.GetGenericArguments().Select(ta => RenderType(ta).Name))}>";
  }
}
