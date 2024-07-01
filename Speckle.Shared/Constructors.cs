using System.Text;

namespace Speckle.Shared;

public partial class Generator
{
  private List<GeneratedConstructor> WriteConstructors(StringBuilder sb, Type clazz)
  {
    var generatedConstructor = new List<GeneratedConstructor>();
    if (IsExcluded(clazz.Name, string.Empty))
    {
      return generatedConstructor;
    }
    var constructors = clazz.GetConstructors().ToList();
    var emptyConstructor = constructors.FirstOrDefault(x => !x.GetParameters().Any());
    if (emptyConstructor is not null)
    {
      constructors.Remove(emptyConstructor);
    }

    var constructorSb = new StringBuilder();
    constructorSb.Append($"\tpublic {clazz.Name}(");
    WriteMethodBody(constructorSb, [], clazz.BaseType, GeneratedType.Empty);
    sb.Append(constructorSb);
    generatedConstructor.Add(new GeneratedConstructor([]));
    foreach (var constructor in constructors)
    {
      try
      {
        constructorSb = new StringBuilder();
        constructorSb.Append($"\tpublic {clazz.Name}(");
        var parameters = constructor.GetParameters();
        WriteMethodBody(constructorSb, parameters, clazz.BaseType, GeneratedType.Class);
        sb.Append(constructorSb);
        generatedConstructor.Add(
          new GeneratedConstructor(parameters.Select(x => new GeneratedParameter(x.ParameterType, x.Name)).ToList())
        );
      }
      catch (FileLoadException)
      {
        Console.WriteLine($"Did not write a constructor on {clazz.FullName}");
      }
      catch (ApplicationException)
      {
        Console.WriteLine($"Did not write constructor on {clazz.FullName}");
      }
    }

    return generatedConstructor;
  }
}
