using System.Reflection;
using System.Text;

namespace Speckle.Shared;

public partial class Generator
{
   
  private void WriteProperty(StringBuilder sb, PropertyInfo propertyInfo, GeneratedType generatedType)
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
        WritePropertyHeader(sb, propertyInfo,getMethod.IsStatic, generatedType, isOverriden, getMethod.ReturnType);
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
        WritePropertyHeader(sb, propertyInfo, setMethod.IsStatic, generatedType, isOverriden, parameters[0].ParameterType);
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
    sb.AppendLine("\t}");
  }

  private void WritePropertyHeader(StringBuilder sb, PropertyInfo property, bool isStatic, GeneratedType generatedType, bool isOverriden, Type returnType)
  {
    var extra = string.Empty;
    if (generatedType == GeneratedType.Class)
    {
      if (isStatic)
      {
        extra += "static ";
      }
      else
      {
        extra = isOverriden ? "override" : "virtual";
        if (IsMemberOnBaseClass(property.DeclaringType?.BaseType?.FullName, new(property.Name)))
        {
          extra = "new";
        }
      }
    }

    sb.AppendLine($"public {extra} {ReturnType(returnType)} {property.Name}");
    sb.AppendLine("\t{");
  }

}
