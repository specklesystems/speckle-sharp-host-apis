﻿using Autodesk.Revit.DB;
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
}

[Proxy(
  typeof(ElementFilter),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitElementFilterProxy : IRevitElementFilter;

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
