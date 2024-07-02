using System.Reflection;
using System.Text;

namespace Speckle.Shared;

public partial class Generator
{
  private readonly Dictionary<string, bool> _boolDone = new();
  private readonly Dictionary<string, GeneratedTypeInfo> _info = new();
  private readonly string _path;
  private readonly Assembly[] _assemblies;
  private readonly string[] _namespaces;
  private readonly ExcludedType[] _excludedTypes;

  public Generator(string path, Assembly[] assemblies, string[] namespaces, ExcludedType[] excludedTypes)
  {
    _path = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", path, "generated");
    _assemblies = assemblies;
    _namespaces = namespaces;
    _excludedTypes = excludedTypes;
    AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += CurrentDomainOnReflectionOnlyAssemblyResolve;
  }

  private Assembly? CurrentDomainOnReflectionOnlyAssemblyResolve(object? sender, ResolveEventArgs args)
  {
    string name = args.Name.Split(',')[0];

    if (!name.StartsWith("System") && !name.StartsWith("Presentation") && !name.StartsWith("Windows"))
    {
      return null;
    }
    string assemblyFile = Path.Combine(
      "C:\\Program Files (x86)\\Reference Assemblies\\Microsoft\\Framework\\.NETFramework\\v4.8",
      name + ".dll"
    );

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
    }
    catch (ReflectionTypeLoadException e)
    {
      definedTypes = e.Types.ToList();
    }

    definedTypes = definedTypes
      .Where(x => x.IsPublic)
      .Where(x => _namespaces.Any(y => x.FullName?.StartsWith(y) ?? false))
      .ToList();
    foreach (var type in definedTypes)//.Where(x => x.FullName.EndsWith("NurbsSurface")))
    {
      try
      {
        RenderType(type, false);
      }
      catch (ApplicationException)
      {
        Console.WriteLine($"Did not write type {type.FullName}");
        _boolDone[type.FullName] = false;
      }
    }
  }

  private Type RenderType(Type type, bool isOpenGeneric)
  {
    if (IsExcluded(type.Name, string.Empty))
    {
      throw new ApplicationException($"Type is excluded: {type.FullName}");
    }
    if (type.FullName is null)
    {
      throw new ApplicationException("Type has a null full name");
    }
    if (type.FullName.StartsWith("System.Drawing."))
    {
      throw new ApplicationException($"Not dealing with base types: {type.FullName}");
    }
    if (type.FullName.StartsWith("System.Windows") || type.FullName.StartsWith("System.MulticastDelegate"))
    {
      throw new ApplicationException($"Not dealing with base WPF types: {type.FullName}");
    }
    if (type.FullName.StartsWith("System."))
    {
      return type;
    }
    if (!_namespaces.Contains(type.Namespace))
    {
      return type;
    }

    if (type.IsArray)
    {
      return RenderType(type.GetElementType().NotNull(), isOpenGeneric);
    }

    if (type.IsGenericType)
    {
      type = type.GetGenericTypeDefinition();
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

  private bool IsExcluded(string type, string member)
  {
    var excludedType = _excludedTypes.FirstOrDefault(x =>
      x.Name.Equals(type, StringComparison.InvariantCultureIgnoreCase)
    );
    if (excludedType is null)
    {
      return false;
    }

    if (!excludedType.ExcludedMembers.Any())
    {
      //none means all
      return true;
    }

    return excludedType.ExcludedMembers.Any(x => x.Name.Equals(member, StringComparison.CurrentCultureIgnoreCase));
  }
}
