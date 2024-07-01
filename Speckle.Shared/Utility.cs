namespace Speckle.Shared;

public partial class Generator
{
  
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
