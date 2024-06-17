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
  new[] { "Parameter", "BoundingBox", "Geometry", "Location" }
)]
public partial interface IRevitElementProxy : IRevitElement;

public partial class ElementProxy
{
  public IRevitParameter?  GetParameter(RevitBuiltInParameter builtInParameter) => A.Call<IRevitParameter>(() =>_Instance.get_Parameter(EnumUtility<RevitBuiltInParameter, BuiltInParameter>.Convert(builtInParameter)));
  public IRevitBoundingBoxXYZ? GetBoundingBox() => A.Call<IRevitBoundingBoxXYZ>(() => _Instance.get_BoundingBox(null));

  public IRevitGeometryElement? GetGeometry(IRevitOptions options) => A.Call<IRevitGeometryElement>(() => _Instance.get_Geometry(((OptionsProxy)options)._Instance));

  public IRevitFamilySymbol? ToFamilySymbol() => A.Cast<IRevitFamilySymbol, FamilySymbol>(_Instance);

  public IRevitMaterial? ToMaterial() => A.Cast<IRevitMaterial, Material>(_Instance);

  public IRevitHostObject? ToHostObject() => A.Cast<IRevitHostObject, HostObject>(_Instance);

  public IRevitGroup? ToGroup() => A.Cast<IRevitGroup, Group>(_Instance);

  public IRevitGraphicsStyle? ToGraphicsStyle() => A.Cast<IRevitGraphicsStyle, GraphicsStyle>(_Instance);

  public IRevitElementType? ToType() => A.Cast<IRevitElementType, ElementType>(_Instance);

  public IRevitSketch? ToSketch() => A.Cast<IRevitSketch, Sketch>(_Instance);

  public IRevitFloor? ToFloor() => A.Cast<IRevitFloor, Floor>(_Instance);

  public IRevitModelLine? ToModelLine() => A.Cast<IRevitModelLine, ModelLine>(_Instance);

  public IRevitLevel? ToLevel() => A.Cast<IRevitLevel, Level>(_Instance);

  public IRevitLocationPoint? GetLocationAsLocationPoint()
  {
    if (_Instance.Location is LocationPoint l)
    {
      return new LocationPointProxy(l);
    }

    return null;
  }

  public IRevitLocationCurve? GetLocationAsLocationCurve()
  {
    if (_Instance.Location is LocationCurve l)
    {
      return new LocationCurveProxy(l);
    }

    return null;
  }

  //location can be 3 types and need to handle it?
  public IRevitLocation Location
  {
    get
    {
      IRevitLocation? location = GetLocationAsLocationPoint();
      if (location is not null)
      {
        return location;
      }
      location = GetLocationAsLocationCurve();
      if (location is not null)
      {
        return location;
      }

      return new LocationProxy(_Instance.Location);
    }
  }
}

[Proxy(typeof(FamilySymbol), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitFamilySymbolProxy : IRevitFamilySymbol;

[Proxy(typeof(ElementType), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
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

[Proxy(typeof(WallType), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitWallTypeProxy : IRevitWallType;

[Proxy(typeof(HostObject), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitHostObjectProxy : IRevitHostObject;

[Proxy(typeof(Ellipse), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitEllipseProxy : IRevitEllipse;
