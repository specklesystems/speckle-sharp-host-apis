using Autodesk.Revit.DB;
using Autodesk.Revit.DB.PointClouds;
using Mapster.Utils;
using Speckle.ProxyGenerator;
using Speckle.Revit.Interfaces;

namespace Speckle.Revit.Api;

public class RevitFilterFactory : IRevitFilterFactory
{
  public IRevitElementIsElementTypeFilter CreateElementIsElementTypeFilter(bool inverted) =>
    new ElementIsElementTypeFilterProxy(new ElementIsElementTypeFilter());

  public IRevitLogicalAndFilterFilter CreateLogicalAndFilter(params IRevitElementFilter[] filters) =>
    new LogicalAndFilterProxy(
      new LogicalAndFilter(filters.Cast<IRevitElementFilterProxy>().Select(x => x._Instance).ToList())
    );

  public IRevitElementMulticategoryFilter CreateElementMulticategoryFilter(
    ICollection<RevitBuiltInCategory> categories,
    bool inverted
  ) =>
    new ElementMulticategoryFilterProxy(
      new ElementMulticategoryFilter(categories.Select(x => (BuiltInCategory)x).ToArray(), inverted)
    );

  public IRevitFilteredElementCollector CreateFilteredElementCollector(
    IRevitDocument document,
    params IRevitElementId[] elementIds
  ) =>
    new FilteredElementCollectorProxy(
      new FilteredElementCollector(
        ((IRevitDocumentProxy)document)._Instance,
        elementIds.Cast<IRevitElementIdProxy>().Select(x => x._Instance).ToList()
      )
    );

  public IRevitPointCloudFilter CreateMultiPlaneFilter(params IRevitPlane[] planes) =>
    new PointCloudFilterProxy(
      PointCloudFilterFactory.CreateMultiPlaneFilter(planes.Cast<PlaneProxy>().Select(x => x._Instance).ToList())
    );

  public IRevitElementCategoryFilter CreateElementCategoryFilter(RevitBuiltInCategory category) =>
    new ElementCategoryFilterProxy(new ElementCategoryFilter(EnumUtility<RevitBuiltInCategory, BuiltInCategory>.Convert(category)));
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
  public IEnumerable<T> OfClass<T>() => _Instance.OfClass(typeof(T)).Cast<T>();
}
