using Autodesk.Revit.DB;
using Speckle.ProxyGenerator;
using Speckle.Revit.Interfaces;

namespace Speckle.Revit.Api;

[Proxy(typeof(Units), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitUnitsProxy : IRevitUnits;

[Proxy(
  typeof(FormatOptions),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitFormatOptionsProxy : IRevitFormatOptions;

[Proxy(
  typeof(Transform),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new [] { "Basis" }
)]
public partial interface IRevitTransformProxy : IRevitTransform;

[Proxy(
  typeof(BasePoint),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitBasePointProxy : IRevitBasePoint;

public partial class BasePointProxy
{
  public IRevitParameter GetParameter(RevitBuiltInParameter parameter) =>
    new ParameterProxy(_Instance.get_Parameter((BuiltInParameter)parameter));
}

[Proxy(
  typeof(Parameter),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new [] {"IsReadOnly"}
)]
public partial interface IRevitParameterProxy : IRevitParameter;
public partial class ParameterProxy
{
  public bool IsReadOnly => _Instance.IsReadOnly;
}

[Proxy(
  typeof(PolyLine),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitPolyLineProxy : IRevitPolyLine;
[Proxy(
  typeof(Point),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitPointProxy : IRevitPoint;
[Proxy(
  typeof(Plane),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitPlaneProxy : IRevitPlane;
[Proxy(
  typeof(Arc),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitArcProxy : IRevitArc;
[Proxy(
  typeof(BoundingBoxXYZ),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new [] {"BoundEnabled", "MaxEnabled", "MinEnabled","Bounds"}
)]
public partial interface IRevitBoundingBoxXYZProxy : IRevitBoundingBoxXYZ;
