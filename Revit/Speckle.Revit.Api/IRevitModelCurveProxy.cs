using Autodesk.Revit.DB;
using Speckle.ProxyGenerator;
using Speckle.Revit.Interfaces;

namespace Speckle.Revit.Api;

[Proxy(typeof(ModelCurve), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitModelCurveProxy : IRevitModelCurve;

[Proxy(typeof(CurveElement), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitCurveElementProxy : IRevitCurveElement;

[Proxy(typeof(Curve), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitCurveProxy : IRevitCurve;

public partial class CurveProxy
{
  public IRevitLine? ToLine()
  {
    if (_Instance is Line m)
    {
      return new LineProxy(m);
    }
    return null;
  }

  public IRevitArc? ToArc()
  {
    if (_Instance is Arc m)
    {
      return new ArcProxy(m);
    }
    return null;
  }

  public IRevitEllipse? ToEllipse()
  {
    if (_Instance is Ellipse m)
    {
      return new EllipseProxy(m);
    }
    return null;
  }

  public IRevitNurbSpline? ToNurbSpline()
  {
    if (_Instance is NurbSpline m)
    {
      return new NurbSplineProxy(m);
    }
    return null;
  }

  public IRevitHermiteSpline? ToHermiteSpline()
  {
    if (_Instance is HermiteSpline m)
    {
      return new HermiteSplineProxy(m);
    }
    return null;
  }
}

[Proxy(typeof(XYZ), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitXYZProxy : IRevitXYZ;

[Proxy(
  typeof(LocationCurve),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "JoinType", "ElementsAtJoin" }
)]
public partial interface IRevitLocationCurveProxy : IRevitLocationCurve;

[Proxy(typeof(Location), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitLocationProxy : IRevitLocation;

public partial class LocationProxy
{
  public IRevitLocationCurve? ToLocationCurve(){
    if (_Instance is LocationCurve m)
    {
      return new LocationCurveProxy(m);
    }

    return null;
  }
  public IRevitLocationPoint? ToLocationPoint()
  {
    if (_Instance is LocationPoint m)
    {
      return new LocationPointProxy(m);
    }

    return null;
  }
}

[Proxy(
  typeof(LocationPoint),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitLocationPointProxy : IRevitLocationPoint;
