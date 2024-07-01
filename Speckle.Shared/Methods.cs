using System.Reflection;
using System.Text;

namespace Speckle.Shared;

public partial class Generator
{
  private List<GeneratedMember> WriteMethods(StringBuilder sb, Type clazz, GeneratedType generatedType)
  {
    var members = new List<GeneratedMember>();

    foreach(var method in clazz.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public))
    {
      if (method.IsSpecialName //special is get/set for properties
          || IsExcluded(clazz.Name, method.Name))
      {
        continue;
      }
      try
      {
        var methodSb = new StringBuilder();
        methodSb.Append("\t");
        WriteMethod(methodSb, method, generatedType);
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

    return members;
  }
  private void WriteMethod(StringBuilder sb, MethodInfo methodInfo, GeneratedType generatedType)
  {
    if (methodInfo.GetBaseDefinition().DeclaringType != methodInfo.DeclaringType)
    {
      throw new ApplicationException("not base property?");
    }

    var extras = string.Empty;
    if (generatedType != GeneratedType.Interface)
    {
      extras = "virtual";
      if (methodInfo.IsStatic)
      {
        extras = "static";

        if (IsMemberOnBaseClass(methodInfo.DeclaringType?.BaseType?.FullName, new(methodInfo.Name)))
        {
          extras = "new " + extras;
        }
      }
    }


    sb.Append($"public {extras} {ReturnType(methodInfo.ReturnType)} {methodInfo.Name}(");
    WriteMethodBody(sb, methodInfo.GetParameters(), null, generatedType);
  }

  private void WriteMethodBody(StringBuilder sb, ParameterInfo[] parameterInfos, Type? baseType, GeneratedType generatedType)
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

    if (generatedType == GeneratedType.Interface)
    {
      sb.AppendLine(");");
    }
    else
    {
      sb.AppendLine(") => throw new System.NotImplementedException();");
    }
  }
}
