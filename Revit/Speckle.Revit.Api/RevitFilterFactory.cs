using Autodesk.Revit.DB;
using Autodesk.Revit.DB.PointClouds;
using Speckle.ProxyGenerator;
using Speckle.Revit.Interfaces;

namespace Speckle.Revit.Api;

public class RevitFilterFactory : IRevitFilterFactory
{
  public IRevitElementIsElementTypeFilter CreateElementIsElementTypeFilter(bool inverted) =>
    new ElementIsElementTypeFilterProxy(new ElementIsElementTypeFilter());

  public IRevitLogicalAndFilterFilter CreateLogicalAndFilter(params IRevitElementFilter[] filters) =>
    new LogicalAndFilterProxy(
      new LogicalAndFilter(filters.Cast<ElementFilterProxy>().Select(x => x._Instance).ToList())
    );

  public IRevitElementMulticategoryFilter CreateElementMulticategoryFilter(
    ICollection<RevitBuiltInCategory> categories,
    bool inverted
  ) =>
    new ElementMulticategoryFilterProxy(
      instance: new ElementMulticategoryFilter(
        categories.Select(EnumUtility<RevitBuiltInCategory, BuiltInCategory>.Convert).ToArray(),
        inverted
      )
    );

  public IRevitFilteredElementCollector CreateFilteredElementCollector(
    IRevitDocument document,
    params IRevitElementId[] elementIds
  )
  {
    if (elementIds.Any())
    {
      return new FilteredElementCollectorProxy(
        new FilteredElementCollector(
          ((DocumentProxy)document)._Instance,
          elementIds.Cast<ElementIdProxy>().Select(x => x._Instance).ToList()
        )
      );
    }
    return new FilteredElementCollectorProxy(new FilteredElementCollector(((DocumentProxy)document)._Instance));
  }

  public IRevitPointCloudFilter CreateMultiPlaneFilter(params IRevitPlane[] planes) =>
    new PointCloudFilterProxy(
      PointCloudFilterFactory.CreateMultiPlaneFilter(planes.Cast<PlaneProxy>().Select(x => x._Instance).ToList())
    );

  public IRevitElementCategoryFilter CreateElementCategoryFilter(RevitBuiltInCategory category) =>
    new ElementCategoryFilterProxy(
      new ElementCategoryFilter(EnumUtility<RevitBuiltInCategory, BuiltInCategory>.Convert(category))
    );
}

[Proxy(
  typeof(PointCloudFilter),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitPointCloudFilterProxy : IRevitPointCloudFilter;

[Proxy(
  typeof(ElementFilter),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitElementFilterProxy : IRevitElementFilter;

[Proxy(
  typeof(ElementCategoryFilter),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitElementCategoryFilterProxy : IRevitElementCategoryFilter;

[Proxy(
  typeof(ElementIsElementTypeFilter),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitElementIsElementTypeFilterProxy : IRevitElementIsElementTypeFilter;

[Proxy(
  typeof(ElementMulticategoryFilter),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitElementMulticategoryFilterProxy : IRevitElementMulticategoryFilter;

[Proxy(
  typeof(LogicalAndFilter),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitLogicalAndFilterProxy : IRevitLogicalAndFilterFilter;

[Proxy(
  typeof(FilteredElementCollector),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitFilteredElementCollectorProxy : IRevitFilteredElementCollector;

public partial class FilteredElementCollectorProxy
{
  public IEnumerable<T> OfClass<T>() =>
    _Instance
      .OfClass(
        ProxyMap.GetHostTypeFromMappedType(typeof(T))
          ?? throw new InvalidOperationException($"Could not unmap type: {typeof(T).FullName}")
      )
      .Select(x => ProxyMap.CreateProxy(typeof(T), x))
      .Cast<T>();
}
