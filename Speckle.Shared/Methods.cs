using System.Reflection;
using System.Text;

namespace Speckle.Shared;

public partial class Generator
{
  private List<GeneratedMember> WriteMethods(StringBuilder sb, Type clazz, GeneratedType generatedType)
  {
    var members = new List<GeneratedMember>();
    var publicMethods = clazz.GetMethods(
      BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public
    );
    var explicitMethods = clazz.GetMethods(BindingFlags.NonPublic| BindingFlags.DeclaredOnly  | BindingFlags.Instance)
      .Where(mi => IsExplicit(mi.Name)).ToArray();
    foreach (var method in publicMethods.Concat(explicitMethods))
    {
      if (IsExcluded(clazz.Name, method.Name))
      {
        continue;
      }
      try
      {
        if (method.IsSpecialName)
        {
            continue;
          
        }

        var methodSb = new StringBuilder();
        methodSb.Append("\t");
        WriteMethod(methodSb, method, generatedType, false);
        sb.Append(methodSb);
        members.Add(new(method.Name));
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

  private void WriteMethod(StringBuilder sb, MethodInfo methodInfo, GeneratedType generatedType, bool nullable)
  {
    if (methodInfo.GetBaseDefinition().DeclaringType != methodInfo.DeclaringType)
    {
      throw new ApplicationException("not base property?");
    }

    var extras = string.Empty;
    if (generatedType == GeneratedType.Class)
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

    var genericArguments = methodInfo.GetGenericArguments();
    var genericString = string.Empty;
    if (genericArguments.Any())
    {
      genericString = $"<{string.Join(", ", genericArguments.Select((ta, i) => ta.Name))}>";
      
    }

    if (methodInfo.Name.Contains("."))
    {
      sb.Append($"{ReturnType(methodInfo.ReturnType, nullable)} {methodInfo.Name}{genericString}(");
    }
    else
    {
      sb.Append($"public {extras} {ReturnType(methodInfo.ReturnType, nullable)} {methodInfo.Name}{genericString}(");
    }

    WriteMethodBody(sb, methodInfo.GetParameters(), null, generatedType, nullable);
  }

  private void WriteMethodBody(
    StringBuilder sb,
    ParameterInfo[] parameterInfos,
    Type? baseType,
    GeneratedType generatedType,
    bool nullable
  )
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
      sb.Append(ParameterType(parameter.ParameterType, nullable)).Append(" ").Append(FixName(parameter.Name));
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
    else if (generatedType == GeneratedType.Empty)
    {
      sb.AppendLine(") {}");
    }
    else
    {
      sb.AppendLine(") => throw new System.NotImplementedException();");
    }
  }
}
