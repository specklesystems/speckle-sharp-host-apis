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
  public IRevitLocationPoint? ToLocationPoint()
  {
    if (_Instance is LocationPoint point)
    {
      return new LocationPointProxy(point);
    }
    return null;
  }public IRevitLocationCurve? ToLocationCurve()
  {
    if (_Instance is LocationCurve point)
    {
      return new LocationCurveProxy(point);
    }
    return null;
  }
}

[Proxy(
  typeof(LocationPoint),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitLocationPointProxy : IRevitLocationPoint;
