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

public interface IProxyMap
{
  Type? GetMappedType(Type type);
  Type? UnmapType(Type type);

  object CreateProxy(Type type, object toWrap);
}

// ghetto default interface implementation :(
public static class ProxyMapExtensions
{
  public static (Type, object)? WrapIfExists(this IProxyMap proxyMap, Type target, object toWrap)
  {
    var proxyType = proxyMap.GetMappedType(target);
    if (proxyType is not null)
    {
      return (proxyType, proxyMap.CreateProxy(proxyType, toWrap));
    }
    return null;
  }
}
