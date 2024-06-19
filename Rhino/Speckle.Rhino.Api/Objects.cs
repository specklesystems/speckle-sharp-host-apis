using Rhino.DocObjects;
using Rhino.Geometry;
using Speckle.ProxyGenerator;
using Speckle.Rhino7.Interfaces;

namespace Speckle.Rhino7.Api;

[Proxy(typeof(BrepObject))]
public partial interface IRhinoBrepObjectProxy : IRhinoBrepObject;

[Proxy(typeof(CurveObject))]
public partial interface IRhinoCurveObjectProxy : IRhinoCurveObject;

[Proxy(typeof(ExtrusionObject))]
public partial interface IRhinoExtrusionObjectProxy : IRhinoExtrusionObject;

[Proxy(typeof(Extrusion))]
public partial interface IRhinoExtrusionProxy : IRhinoExtrusion;

[Proxy(typeof(MeshObject))]
public partial interface IRhinoMeshObjectProxy : IRhinoMeshObject;

[Proxy(typeof(PointCloudObject))]
public partial interface IRhinoPointCloudObjectProxy : IRhinoPointCloudObject;

[Proxy(typeof(PointObject))]
public partial interface IRhinoPointObjectProxy : IRhinoPointObject;
