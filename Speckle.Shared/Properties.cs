using System.Reflection;
using System.Text;

namespace Speckle.Shared;

public partial class Generator
{
  private List<GeneratedMember> WriteProperties(StringBuilder sb, Type clazz, GeneratedType generatedType)
  {
    var properities = new List<GeneratedMember>();
    var publicProperties = clazz.GetProperties(
      BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public
    );
    var explicitProperties = clazz
      .GetProperties(BindingFlags.NonPublic | BindingFlags.DeclaredOnly | BindingFlags.Instance)
      .Where(mi =>
      {
        int dot = mi.Name.LastIndexOf('.');
        return dot > -1;
      })
      .ToArray();
    foreach (var propertyInfo in publicProperties.Concat(explicitProperties))
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
        properities.Add(new(propertyInfo.Name));
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
    return properities;
  }

  private void WriteProperty(StringBuilder sb, PropertyInfo propertyInfo, GeneratedType generatedType)
  {
    var wrotePropHeader = false;
    var getMethod = propertyInfo.GetGetMethod(true);
    if (getMethod is not null)
    {
      if (_options.HasFlag(GeneratorOptions.ExplicitProperties) && getMethod.GetParameters().Any())
      {
        throw new ApplicationException($"getter has parameters {propertyInfo.Name}");
      }
      bool isOverriden = getMethod.GetBaseDefinition().DeclaringType != propertyInfo.DeclaringType;
      if (wrotePropHeader is false)
      {
        wrotePropHeader = true;
        WritePropertyHeader(sb, propertyInfo, getMethod.IsStatic, generatedType, isOverriden, getMethod.ReturnType);
      }
      if (generatedType == GeneratedType.Interface)
      {
        sb.AppendLine("\t\tget;");
      }
      else
      {
        sb.AppendLine("\t\tget => throw new System.NotImplementedException();");
      }
    }
    var setMethod = propertyInfo.GetSetMethod(true);
    if (setMethod is not null)
    {
      var parameters = setMethod.GetParameters();
      if (_options.HasFlag(GeneratorOptions.ExplicitProperties) && parameters.Length > 1)
      {
        throw new ApplicationException($"setter has more than one parameter {propertyInfo.Name}");
      }
      bool isOverriden = setMethod.GetBaseDefinition().DeclaringType != propertyInfo.DeclaringType;
      if (wrotePropHeader is false)
      {
        WritePropertyHeader(
          sb,
          propertyInfo,
          setMethod.IsStatic,
          generatedType,
          isOverriden,
          parameters[0].ParameterType
        );
      }

      if (generatedType == GeneratedType.Interface)
      {
        sb.AppendLine("\t\tset;");
      }
      else
      {
        sb.AppendLine("\t\tset {}");
      }
    }

    if (getMethod is not null || setMethod is not null)
    {
      sb.AppendLine("\t}");
    }
    else
    {
      Console.WriteLine();
    }
  }

  private void WritePropertyHeader(
    StringBuilder sb,
    PropertyInfo property,
    bool isStatic,
    GeneratedType generatedType,
    bool isOverriden,
    Type returnType
  )
  {
    var isIndexer = (property.Name.Length == 4 && property.Name.Equals("Item")) || property.Name.EndsWith(".Item");
    var extra = string.Empty;
    if (isStatic)
    {
      extra += "static";
    }
    if (generatedType != GeneratedType.Interface)
    {
      if (!isStatic)
      {
        extra = isOverriden ? "override" : "virtual";
        if (IsMemberOnBaseClass(property.DeclaringType?.BaseType?.FullName, new(property.Name)))
        {
          extra = "new";
        }
      }
    }

    ParameterInfo[] p = [];
    if (isIndexer)
    {
      p = property.GetIndexParameters();
    }

    if (IsExplicit(property.Name))
    {
      var name = isIndexer
        ? $"{property.Name.Substring(0, property.Name.Length - 4)}this[{ParameterType(p[0].ParameterType, false, false)} {FixName(p[0].Name)}]"
        : property.Name;
      sb.AppendLine($"{ReturnType(returnType, false)} {name}");
    }
    else
    {
      var name = isIndexer
        ? $"this[{ParameterType(p[0].ParameterType, false, false)} {FixName(p[0].Name)}]"
        : property.Name;
      sb.AppendLine($"public {extra} {ReturnType(returnType, false)} {name}");
    }

    sb.AppendLine("\t{");
  }
}
