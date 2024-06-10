using System.Diagnostics.CodeAnalysis;
using Autodesk.Revit.DB;
using Speckle.ProxyGenerator;
using Speckle.Revit.Interfaces;
#pragma warning disable CA1010
#pragma warning disable CA1710

namespace Speckle.Revit.Api;

[Proxy(
  typeof(Document),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "PlanTopology", "PlanTopologies", "TypeOfStorage", "Equals" }
)]
[SuppressMessage("Maintainability", "CA1506:Avoid excessive class coupling")]
public partial interface IRevitDocumentProxy : IRevitDocument;

[Proxy(
  typeof(ForgeTypeId),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Equals" }
)]
public partial interface IRevitForgeTypeIdProxy : IRevitForgeTypeId;

[Proxy(
  typeof(Element),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Parameter", "BoundingBox", "Geometry" }
)]
public partial interface IRevitElementProxy : IRevitElement;

public partial class ElementProxy
{
  public IRevitBoundingBoxXYZ GetBoundingBox() => new BoundingBoxXYZProxy(_Instance.get_BoundingBox(null));
  public IRevitFamilySymbol? ToFamilySymbol()
  {
    if (_Instance is FamilySymbol s)
    {
      return new FamilySymbolProxy(s);
    }

    return null;
  }  public IRevitMaterial? ToMaterial()
  {
    if (_Instance is Material m)
    {
      return new MaterialProxy(m);
    }

    return null;
  }
}
[Proxy(
  typeof(FamilySymbol),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitFamilySymbolProxy : IRevitFamilySymbol;
[Proxy(
  typeof(ElementType),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitElementTypeProxy : IRevitElementType;
[Proxy(
  typeof(Category),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "AllowsVisibilityControl", "Visible" }
)]
public partial interface IRevitCategoryProxy : IRevitCategory;

[Proxy(
  typeof(ElementId),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Equals" }
)]
public partial interface IRevitElementIdProxy : IRevitElementId;

[Proxy(typeof(CurtainGrid), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitCurtainGridProxy : IRevitCurtainGrid;

[Proxy(typeof(Wall), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitWallProxy : IRevitWall;

[Proxy(typeof(HostObject), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitHostObjectProxy : IRevitHostObject;

[Proxy(typeof(Ellipse), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitEllipseProxy : IRevitEllipse;
