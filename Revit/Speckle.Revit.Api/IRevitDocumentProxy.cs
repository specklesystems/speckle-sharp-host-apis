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
  public IRevitParameter GetParameter(RevitBuiltInParameter builtInParameter) =>
    new ParameterProxy(
      _Instance.get_Parameter(EnumUtility<RevitBuiltInParameter, BuiltInParameter>.Convert(builtInParameter))
    );

  public IRevitBoundingBoxXYZ GetBoundingBox() => new BoundingBoxXYZProxy(_Instance.get_BoundingBox(null));

  public IRevitGeometryElement GetGeometry(IRevitOptions options) =>
    new GeometryElementProxy(_Instance.get_Geometry(((OptionsProxy)options)._Instance));

  public IRevitFamilySymbol? ToFamilySymbol()
  {
    if (_Instance is FamilySymbol s)
    {
      return new FamilySymbolProxy(s);
    }

    return null;
  }

  public IRevitMaterial? ToMaterial()
  {
    if (_Instance is Material m)
    {
      return new MaterialProxy(m);
    }

    return null;
  }

  public IRevitHostObject? ToHostObject()
  {
    if (_Instance is HostObject m)
    {
      return new HostObjectProxy(m);
    }

    return null;
  }

  public IRevitGroup? ToGroup()
  {
    if (_Instance is Group m)
    {
      return new GroupProxy(m);
    }

    return null;
  }

  public IRevitGraphicsStyle? ToGraphicsStyle()
  {
    if (_Instance is GraphicsStyle m)
    {
      return new GraphicsStyleProxy(m);
    }

    return null;
  }

  public IRevitElementType? ToType()
  {
    if (_Instance is ElementType m)
    {
      return new ElementTypeProxy(m);
    }

    return null;
  }

  public IRevitSketch? ToSketch()
  {
    if (_Instance is Sketch m)
    {
      return new SketchProxy(m);
    }

    return null;
  }

  public IRevitFloor? ToFloor()
  {
    if (_Instance is Floor m)
    {
      return new FloorProxy(m);
    }

    return null;
  }

  public IRevitModelLine? ToModelLine()
  {
    if (_Instance is ModelLine m)
    {
      return new ModelLineProxy(m);
    }

    return null;
  }

  public IRevitLevel? ToLevel()
  {
    if (_Instance is Level m)
    {
      return new LevelProxy(m);
    }

    return null;
  }

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
