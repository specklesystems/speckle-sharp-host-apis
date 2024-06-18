using System.Collections;
using Rhino;
using Rhino.DocObjects;
using Rhino.Geometry;
using Rhino.Geometry.Collections;
using Rhino.Geometry.MeshRefinements;
using Rhino.Runtime;
using Speckle.ProxyGenerator;
using Speckle.Rhino7.Interfaces;

namespace Speckle.Rhino7.Api;
[Proxy(
  typeof(RhinoDoc),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Equals" }
)]
public partial interface IRhinoDocProxy : IRhinoDoc;
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
[Proxy(
  typeof(Arc),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new [] {"Equals"}
)]
public partial interface IRhinoArcProxy : IRhinoArc;

[Proxy(
  typeof(Interval),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new [] {"Equals"}
)]
public partial interface IRhinoIntervalProxy : IRhinoInterval;

[Proxy(
  typeof(Point3d),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new [] {"Equals"}
)]
public partial interface IRhinoPoint3dProxy : IRhinoPoint3d;

[Proxy(
  typeof(Plane),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new [] {"Equals"}
)]
public partial interface IRhinoPlaneProxy : IRhinoPlane;

[Proxy(
  typeof(Box),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new [] {"Equals"}
)]
public partial interface IRhinoBoxProxy : IRhinoBox;
[Proxy(
  typeof(BoundingBox),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new [] {"Equals"}
)]
public partial interface IRhinoBoundingBoxProxy : IRhinoBoundingBox;
[Proxy(
  typeof(Brep),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new [] {"SolidOrientation"}
)]
public partial interface IRhinoBrepProxy : IRhinoBrep;

public partial class BrepProxy
{
  public RhinoBrepSolidOrientation SolidOrientation
  {
    get
    {
      var e = A.Cast<IRhinoBrepProxy, Brep>(this, x => x._Instance)
        ?.SolidOrientation;
      return EnumUtility<BrepSolidOrientation, RhinoBrepSolidOrientation>.Convert(e ?? throw new InvalidOperationException("Invalid null"));
    }
  }
}
[Proxy(
  typeof(NurbsSurface),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoNurbsSurfaceProxy : IRhinoNurbsSurface;
[Proxy(
  typeof(Surface),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoSurfaceProxy : IRhinoSurface;
[Proxy(
  typeof(Mesh),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new []{"CreateRefinedLoopMesh"}
)]
public partial interface IRhinoMeshProxy : IRhinoMesh;

[Proxy(
  typeof(RefinementSettings),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoRefinementSettingsProxy : IRhinoRefinementSettings;

[Proxy(
  typeof(BrepVertex),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoBrepVertexProxy : IRhinoBrepVertex;

[Proxy(
  typeof(BrepVertexList),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoBrepVertexListProxy : IRhinoBrepVertexList;

public partial class BrepVertexListProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

[Proxy(
  typeof(Point),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoPointProxy : IRhinoPoint;
[Proxy(
  typeof(BrepCurveList),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoBrepCurveListProxy : IRhinoBrepCurveList;

public partial class BrepCurveListProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
[Proxy(
  typeof(BrepSurfaceList),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoBrepSurfaceListProxy : IRhinoBrepSurfaceList;

public partial class BrepSurfaceListProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
[Proxy(
  typeof(BrepFaceList),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoBrepFaceListProxy : IRhinoBrepFaceList;

public partial class BrepFaceListProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
[Proxy(
  typeof(BrepFace),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoBrepFaceProxy : IRhinoBrepFace;
[Proxy(
  typeof(BrepLoopList),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoBrepLoopListProxy : IRhinoBrepLoopList;

public partial class BrepLoopListProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
[Proxy(
  typeof(BrepLoop),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new []{"LoopType"}
)]
public partial interface IRhinoBrepLoopProxy : IRhinoBrepLoop;

public partial class BrepLoopProxy
{
  
  public RhinoBrepLoopType LoopType
  {
    get
    {
      var x = A.Cast<IRhinoBrepLoopProxy, BrepLoop>(this, x => x._Instance) ?? throw new NullReferenceException();
      return EnumUtility<BrepLoopType, RhinoBrepLoopType>.Convert(x.LoopType);
    }
  }
}

[Proxy(
  typeof(BrepEdgeList),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoBrepEdgeListProxy : IRhinoBrepEdgeList;

public partial class BrepEdgeListProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
[Proxy(
  typeof(BrepEdge),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoBrepEdgeProxy : IRhinoBrepEdge;
[Proxy(
  typeof(CurveProxy),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoCurveProxy2Proxy : IRhinoCurveProxy2;
[Proxy(
  typeof(BrepTrimList),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoBrepTrimListProxy : IRhinoBrepTrimList;

public partial class BrepTrimListProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
[Proxy(
  typeof(BrepTrim),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new []{"IsoStatus", "TrimType"}
)]
public partial interface IRhinoBrepTrimProxy : IRhinoBrepTrim;

public partial class BrepTrimProxy
{
  public RhinoIsoStatus IsoStatus
  {
    get
    {
      var x = A.Cast<IRhinoBrepTrimProxy, BrepTrim>(this, x => x._Instance) ?? throw new NullReferenceException();
      return EnumUtility<IsoStatus, RhinoIsoStatus>.Convert(x.IsoStatus);
    }
  }
  
  public RhinoBrepTrimType TrimType
  {
    get
    {
      var x = A.Cast<IRhinoBrepTrimProxy, BrepTrim>(this, x => x._Instance) ?? throw new NullReferenceException();
      return EnumUtility<BrepTrimType, RhinoBrepTrimType>.Convert(x.TrimType);
    }
  }
}
[Proxy(
  typeof(ControlPoint),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoControlPointProxy : IRhinoControlPoint;
[Proxy(
  typeof(PolyCurve),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoPolyCurveProxy : IRhinoPolyCurve;
[Proxy(
  typeof(PolylineCurve),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoPolylineCurveProxy : IRhinoPolylineCurve;
[Proxy(
  typeof(NurbsCurve),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoNurbsCurveProxy : IRhinoNurbsCurve;
[Proxy(
  typeof(LineCurve),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoLineCurveProxy : IRhinoLineCurve;
[Proxy(
  typeof(Ellipse),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoEllipseProxy : IRhinoEllipse;
[Proxy(
  typeof(Line),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new []{"Equals"}
)]
public partial interface IRhinoLineProxy : IRhinoLine;
