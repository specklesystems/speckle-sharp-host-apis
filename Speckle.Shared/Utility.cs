using System.Reflection;

namespace Speckle.Shared;

public partial class Generator
{
  private string ParameterType(Type type, bool isOut, bool nullable)
  {
    if (!isOut && (type.IsByRef || type.IsPointer))
    {
      throw new ApplicationException("Not Handling References");
    }

    if (
      !_namespaces.Contains(type.Namespace)
      && !type.Namespace.StartsWith("System")
      && !type.Namespace.StartsWith("System.Drawing")
    )
    {
      throw new ApplicationException($"Not Handling: {type.FullName}");
    }

    string name;
    if (isOut)
    {
      name =
        "out "
        + FormGenericType(
          type.GetElementType() ?? throw new ApplicationException($"Cannot make parameter {type}"),
          false
        );
    }
    else
    {
      name = FormGenericType(type, false);
    }

    if (nullable && !name.EndsWith("?", StringComparison.Ordinal))
    {
      return $"{type}?";
    }
    return name;
  }

  private string ReturnType(Type type, bool nullable)
  {
    if (type == typeof(void))
    {
      return "void";
    }
    return ParameterType(type, false, nullable);
  }

  private string FormGenericType(Type type, bool isOpenGeneric)
  {
    if (type.IsGenericParameter)
    {
      return type.Name;
    }
    var t = RenderType(type, false);
    if (isOpenGeneric)
    {
      type = t;
    }
    var name = GetName(type);
    if (!type.IsGenericType)
    {
      return name.Replace('+', '.').NotNull();
    }

    var nonGenericName = name.Split('`').First();
    nonGenericName = nonGenericName.Replace('+', '.');

    return $"{nonGenericName}<{string.Join(", ", type.GetGenericArguments().Select((ta, i) => isOpenGeneric ? ta.Name : FormGenericFullNameOnly(ta, isOpenGeneric)))}>";
    // return $"{nonGenericName}<{string.Join(", ", type.GetGenericArguments().Select((ta, i) => isOpenGeneric ? $"T{i}" : FormGenericFullNameOnly(ta, isOpenGeneric)))}>";
  }

  private string FormGenericFullNameOnly(Type type, bool isOpenGeneric)
  {
    if (type.IsGenericParameter)
    {
      return type.Name;
    }
    var t = RenderType(type, false);
    if (isOpenGeneric)
    {
      type = t;
    }
    var name = GetName(type);
    if (!type.IsGenericType)
    {
      return name;
    }
    var nonGenericName = name.Split('`').First();
    return $"{nonGenericName}<{string.Join(", ", type.GetGenericArguments().Select((ta, i) => isOpenGeneric ? $"T{i}" : FormGenericFullNameOnly(ta, isOpenGeneric)))}>";
  }

  private string FormGenericNameOnly(Type type, bool isOpenGeneric)
  {
    if (type.IsGenericParameter)
    {
      return type.Name;
    }
    var t = RenderType(type, false);
    if (isOpenGeneric)
    {
      type = t;
    }
    if (!type.IsGenericType)
    {
      return type.Name.NotNull();
    }

    var nonGenericName = type.Name.Split('`').First();
    return $"{nonGenericName}<{string.Join(", ", type.GetGenericArguments().Select(ta => ta.Name))}>";
  }

  private string FormNameOnly(Type type)
  {
    if (!type.IsGenericType)
    {
      return type.Name.NotNull();
    }

    var nonGenericName = type.Name.Split('`').First();
    return nonGenericName;
  }

  private string FixName(string name) =>
    name switch
    {
      "lock" or "params" or "string" or "override" => "@" + name,
      _ => name
    };

  private string GetName(Type type)
  {
    if (type.IsGenericParameter || type.ContainsGenericParameters)
    {
      var isCollection = type.IsGenericType && (type.GetGenericTypeDefinition() != null);
      if (!isCollection)
      {
        return type.Name;
      }
    }

    return type.FullName ?? $"{type.Namespace}.{type.Name}";
  }

  public bool IsExplicit(string name)
  {
    int dot = name.LastIndexOf('.');
    return dot > -1;
  }
}
