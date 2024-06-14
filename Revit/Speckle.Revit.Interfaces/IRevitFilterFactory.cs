using System.Collections.Generic;

namespace Speckle.Revit.Interfaces;

#pragma warning disable CA1040
public interface IRevitFilterFactory
{
  IRevitElementIsElementTypeFilter CreateElementIsElementTypeFilter(bool inverted);
  IRevitElementMulticategoryFilter CreateElementMulticategoryFilter(
    ICollection<RevitBuiltInCategory> categories,
    bool inverted
  );
  IRevitLogicalAndFilterFilter CreateLogicalAndFilter(params IRevitElementFilter[] filters);
  IRevitFilteredElementCollector CreateFilteredElementCollector(
    IRevitDocument document,
    params IRevitElementId[] elementIds
  );

  IRevitPointCloudFilter CreateMultiPlaneFilter(params IRevitPlane[] planes);
  IRevitElementCategoryFilter CreateElementCategoryFilter(RevitBuiltInCategory category);
}

public interface IProxyMapper
{
  Type? GetMappedTypeFromHostType(Type type);
  Type? GetMappedTypeFromProxyType(Type type);
  Type? GetHostTypeFromMappedType(Type type);

  object CreateProxy(Type type, object toWrap);

  T CreateProxy<T>(object toWrap);
}

// ghetto default interface implementation :(
public static class ProxyMapExtensions
{
  public static (Type, object)? WrapIfExists(this IProxyMapper proxyMap, Type target, object toWrap)
  {
    var mappedType = proxyMap.GetMappedTypeFromHostType(target);
    if (mappedType is not null)
    {
      return (mappedType, proxyMap.CreateProxy(mappedType, toWrap));
    }
    mappedType = proxyMap.GetMappedTypeFromProxyType(target);
    if (mappedType is not null)
    {
      return (mappedType, toWrap);
    }
    return null;
  }
}
