using Rhino.DocObjects;
using Rhino.Geometry;
using Speckle.ProxyGenerator;
using Speckle.Rhino7.Interfaces;

namespace Speckle.Rhino7.Api;

[Proxy(typeof(BrepObject), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoBrepObjectProxy : IRhinoBrepObject;

[Proxy(typeof(CurveObject), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoCurveObjectProxy : IRhinoCurveObject;

[Proxy(
  typeof(ExtrusionObject),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoExtrusionObjectProxy : IRhinoExtrusionObject;

[Proxy(typeof(Extrusion), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoExtrusionProxy : IRhinoExtrusion;

[Proxy(typeof(MeshObject), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoMeshObjectProxy : IRhinoMeshObject;

[Proxy(
  typeof(PointCloudObject),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoPointCloudObjectProxy : IRhinoPointCloudObject;

[Proxy(typeof(PointObject), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoPointObjectProxy : IRhinoPointObject;
