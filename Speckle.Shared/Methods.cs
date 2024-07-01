using System.Reflection;
using System.Text;

namespace Speckle.Shared;

public partial class Generator
{
  
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
    WriteMethodBody(sb, methodInfo.GetParameters(), null);
  }

  private void WriteMethodBody(StringBuilder sb, ParameterInfo[] parameterInfos, Type? baseType)
  {
    
    bool isFirst = true;
    foreach (var parameter in parameterInfos)
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

    if (baseType is not null)
    {
      if (_info.TryGetValue(baseType.FullName, out var info))
      {
        foreach (var baseConstructors in info.Constructors.Where(x => x.Parameters.Count == parameterInfos.Length))
        {
          bool matches = false;
          for (int i = 0; i < baseConstructors.Parameters.Count; i++)
          {
            var typeBase = baseConstructors.Parameters[i].param;
            var currentType = parameterInfos[i].ParameterType;
            if (typeBase != currentType)
            {
              break;
            }

            matches = true;
          }

          if (matches)
          {
            sb.Append("):base(");
            isFirst = true;
            foreach (var parameter in parameterInfos)
            {
              if (isFirst)
              {
                isFirst = false;
              }
              else
              {
                sb.Append(",");
              }
              sb.Append(" ").Append(FixName(parameter.Name));
            }
          }
        }
      }
    }
      sb.AppendLine(") => throw new System.NotImplementedException();");
  }
}
