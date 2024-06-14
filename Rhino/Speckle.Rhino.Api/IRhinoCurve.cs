using Rhino.DocObjects;
using Rhino.Geometry;
using Rhino.Runtime;
using Speckle.ProxyGenerator;
using Speckle.Rhino7.Interfaces;

namespace Speckle.Rhino7.Api;

[Proxy(
  typeof(Curve),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Duplicate" }
)]
public partial interface IRhinoCurveProxy : IRhinoCurve;

[Proxy(
  typeof(GeometryBase),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoGeometryBaseProxy : IRhinoGeometryBase;

[Proxy(
  typeof(CommonObject),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoCommonObjectProxy : IRhinoCommonObject;

[Proxy(
  typeof(RhinoObject),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
new[] { "ComponentType" }
)]
public partial interface IRhinoObjectProxy : IRhinoObject;

[Proxy(
  typeof(ModelComponent),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoModelComponentProxy : IRhinoModelComponent;
[Proxy(
  typeof(ArcCurve),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoArcCurveProxy : IRhinoArcCurve;
[Proxy(
  typeof(Circle),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoCircleProxy : IRhinoCircle;
