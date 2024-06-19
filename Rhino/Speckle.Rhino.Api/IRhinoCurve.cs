using System.Collections;
using Rhino;
using Rhino.Collections;
using Rhino.DocObjects;
using Rhino.Geometry;
using Rhino.Geometry.Collections;
using Rhino.Geometry.MeshRefinements;
using Rhino.Runtime;
using Speckle.ProxyGenerator;
using Speckle.Rhino7.Interfaces;
using Speckle.Shared;

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

[Proxy(typeof(GeometryBase), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Transform" })]
public partial interface IRhinoGeometryBaseProxy : IRhinoGeometryBase;

public partial class GeometryBaseProxy
{
  public bool Transform(IRhinoTransform transform) => 
    _Instance.Transform(transform.To<IRhinoTransformProxy>().NotNull()._Instance);
}

[Proxy(typeof(CommonObject), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
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

[Proxy(typeof(ArcCurve), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoArcCurveProxy : IRhinoArcCurve;

[Proxy(typeof(Circle), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoCircleProxy : IRhinoCircle;

[Proxy(
  typeof(Arc),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Equals" }
)]
public partial interface IRhinoArcProxy : IRhinoArc;

[Proxy(
  typeof(Interval),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Equals" }
)]
public partial interface IRhinoIntervalProxy : IRhinoInterval;

[Proxy(
  typeof(Point3d),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Equals" }
)]
public partial interface IRhinoPoint3dProxy : IRhinoPoint3d;

[Proxy(
  typeof(Plane),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Equals" }
)]
public partial interface IRhinoPlaneProxy : IRhinoPlane;

[Proxy(
  typeof(Box),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Equals" }
)]
public partial interface IRhinoBoxProxy : IRhinoBox;

[Proxy(
  typeof(BoundingBox),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Equals" }
)]
public partial interface IRhinoBoundingBoxProxy : IRhinoBoundingBox;

[Proxy(
  typeof(Brep),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "SolidOrientation" }
)]
public partial interface IRhinoBrepProxy : IRhinoBrep;

public partial class BrepProxy
{
  public RhinoBrepSolidOrientation SolidOrientation
  {
    get
    {
      var e = A.Cast<IRhinoBrepProxy, Brep>(this, x => x._Instance)?.SolidOrientation;
      return EnumUtility<BrepSolidOrientation, RhinoBrepSolidOrientation>.Convert(
        e ?? throw new InvalidOperationException("Invalid null")
      );
    }
  }
}

[Proxy(typeof(NurbsSurface), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoNurbsSurfaceProxy : IRhinoNurbsSurface;

[Proxy(typeof(Surface), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoSurfaceProxy : IRhinoSurface;

[Proxy(
  typeof(Mesh),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "CreateRefinedLoopMesh", "GetNgonAndFacesEnumerable", "SetCachedTextureCoordinates" }
)]
public partial interface IRhinoMeshProxy : IRhinoMesh;

public partial class MeshProxy
{
  public IEnumerable<IRhinoMeshNgon> GetNgonAndFacesEnumerable()
  {
    var x = A.Cast<IRhinoMeshProxy, Mesh>(this, x => x._Instance).NotNull();
    foreach (var e in x.GetNgonAndFacesEnumerable())
    {
      yield return new MeshNgonProxy(e);
    }
  }
}

[Proxy(
  typeof(MeshNgon),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Equals" }
)]
public partial interface IRhinoMeshNgonProxy : IRhinoMeshNgon;

[Proxy(
  typeof(RefinementSettings),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoRefinementSettingsProxy : IRhinoRefinementSettings;

[Proxy(typeof(BrepVertex), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
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

[Proxy(typeof(Point), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
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

[Proxy(typeof(BrepFaceList), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoBrepFaceListProxy : IRhinoBrepFaceList;

public partial class BrepFaceListProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

[Proxy(typeof(BrepFace), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoBrepFaceProxy : IRhinoBrepFace;

[Proxy(typeof(BrepLoopList), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoBrepLoopListProxy : IRhinoBrepLoopList;

public partial class BrepLoopListProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

[Proxy(
  typeof(BrepLoop),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "LoopType" }
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

[Proxy(typeof(BrepEdgeList), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoBrepEdgeListProxy : IRhinoBrepEdgeList;

public partial class BrepEdgeListProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

[Proxy(typeof(BrepEdge), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoBrepEdgeProxy : IRhinoBrepEdge;

[Proxy(typeof(CurveProxy), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoCurveProxy2Proxy : IRhinoCurveProxy2;

[Proxy(typeof(BrepTrimList), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoBrepTrimListProxy : IRhinoBrepTrimList;

public partial class BrepTrimListProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

[Proxy(
  typeof(BrepTrim),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "IsoStatus", "TrimType" }
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

[Proxy(typeof(ControlPoint), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoControlPointProxy : IRhinoControlPoint;

[Proxy(typeof(PolyCurve), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoPolyCurveProxy : IRhinoPolyCurve;

[Proxy(
  typeof(PolylineCurve),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRhinoPolylineCurveProxy : IRhinoPolylineCurve;

[Proxy(typeof(NurbsCurve), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoNurbsCurveProxy : IRhinoNurbsCurve;

[Proxy(typeof(LineCurve), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoLineCurveProxy : IRhinoLineCurve;

[Proxy(typeof(Transform),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
new[] { "Equals",
  "M00","M01", "M02", "M03", 
  "M10", "M11", "M12", "M13",
  "M20", "M21", "M22", "M23",
  "M30", "M31", "M32", "M33", 
  "get_Item"
})]
public partial interface IRhinoTransformProxy : IRhinoTransform;


[Proxy(typeof(Ellipse), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRhinoEllipseProxy : IRhinoEllipse;

[Proxy(
  typeof(Line),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Equals" }
)]
public partial interface IRhinoLineProxy : IRhinoLine;

[Proxy(
  typeof(Point3f),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Equals" }
)]
public partial interface IRhinoPoint3fProxy : IRhinoPoint3f;

[Proxy(
  typeof(MeshVertexList),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "GetEnumerator" }
)]
public partial interface IRhinoMeshVertexListProxy : IRhinoMeshVertexList;

public partial class MeshVertexListProxy
{
  public IEnumerator<IRhinoPoint3f> GetEnumerator()
  {
    var x =
      A.Cast<IRhinoMeshVertexListProxy, MeshVertexList>(this, x => x._Instance) ?? throw new NullReferenceException();
    foreach (var e in x)
    {
      yield return new Point3fProxy(e);
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

[Proxy(
  typeof(MeshFace),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Equals", "IsValidEx", "RepairEx" }
)]
public partial interface IRhinoMeshFaceProxy : IRhinoMeshFace;

[Proxy(
  typeof(MeshFaceList),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "GetEnumerator" }
)]
public partial interface IRhinoMeshFaceListProxy : IRhinoMeshFaceList;

public partial class MeshFaceListProxy
{
  public IEnumerator<IRhinoMeshFace> GetEnumerator()
  {
    var x = A.Cast<IRhinoMeshFaceListProxy, MeshFaceList>(this, x => x._Instance) ?? throw new NullReferenceException();
    foreach (var e in x)
    {
      yield return new MeshFaceProxy(e);
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

[Proxy(
  typeof(Point2f),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Equals" }
)]
public partial interface IRhinoPoint2fProxy : IRhinoPoint2f;

[Proxy(
  typeof(MeshTextureCoordinateList),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "GetEnumerator" }
)]
public partial interface IRhinoMeshTextureCoordinateListProxy : IRhinoMeshTextureCoordinateList;

public partial class MeshTextureCoordinateListProxy
{
  public IEnumerator<IRhinoPoint2f> GetEnumerator()
  {
    var x = A.Cast<IRhinoMeshTextureCoordinateListProxy, MeshTextureCoordinateList>(this, x => x._Instance).NotNull();
    foreach (var e in x)
    {
      yield return new Point2fProxy(e);
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

[Proxy(
  typeof(MeshVertexColorList),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "GetEnumerator" }
)]
public partial interface IRhinoMeshVertexColorListProxy : IRhinoMeshVertexColorList;

public partial class MeshVertexColorListProxy
{
  public IEnumerator<System.Drawing.Color> GetEnumerator()
  {
    var x = A.Cast<IRhinoMeshVertexColorListProxy, MeshVertexColorList>(this, x => x._Instance).NotNull();
    foreach (var e in x)
    {
      yield return e;
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

[Proxy(typeof(Polyline), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new []{ "Add"})]
public partial interface IRhinoPolylineProxy : IRhinoPolyline;

[Proxy(
  typeof(Point3dList),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Equals", "Duplicate", "GetEnumerator" }
)]
public partial interface IRhinoPoint3dListProxy : IRhinoPoint3dList;

public partial class Point3dListProxy
{
  public IEnumerator<IRhinoPoint3d> GetEnumerator()
  {
    var x = A.Cast<IRhinoPoint3dListProxy, Point3dList>(this, x => x._Instance).NotNull();
    foreach (var e in x)
    {
      yield return new Point3dProxy(e);
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

  public int Count => _Instance.Count;

  public IRhinoPoint3d this[int index] => A.Call<IRhinoPoint3d>(() => this[index]).NotNull();

  public void Add(IRhinoPoint3d point3d)
  {
    var x = A.Cast<IRhinoPoint3dListProxy, Point3dList>(this, x => x._Instance).NotNull();
    x.Add(A.Cast<IRhinoPoint3dProxy, Point3d>(this, xx => xx._Instance));
  }
}

[Proxy(
  typeof(NurbsCurveKnotList),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "GetEnumerator" }
)]
public partial interface IRhinoNurbsCurveKnotListProxy : IRhinoNurbsCurveKnotList;

public partial class NurbsCurveKnotListProxy
{
  public IEnumerator<double> GetEnumerator()
  {
    var x = A.Cast<IRhinoNurbsCurveKnotListProxy, NurbsCurveKnotList>(this, x => x._Instance).NotNull();
    foreach (var e in x)
    {
      yield return e;
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

  public void SetKnot(int index, double value) => _Instance[index] = value;
}

[Proxy(
  typeof(NurbsCurvePointList),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "GetEnumerator" }
)]
public partial interface IRhinoNurbsCurvePointListProxy : IRhinoNurbsCurvePointList;

public partial class NurbsCurvePointListProxy
{
  public IEnumerator<IRhinoControlPoint> GetEnumerator()
  {
    var x = A.Cast<IRhinoNurbsCurvePointListProxy, NurbsCurvePointList>(this, x => x._Instance).NotNull();
    foreach (var e in x)
    {
      yield return new ControlPointProxy(e);
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

[Proxy(
  typeof(NurbsSurfaceKnotList),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "GetEnumerator" }
)]
public partial interface IRhinoNurbsSurfaceKnotListProxy : IRhinoNurbsSurfaceKnotList;

public partial class NurbsSurfaceKnotListProxy
{
  public IEnumerator<double> GetEnumerator()
  {
    var x = A.Cast<IRhinoNurbsSurfaceKnotListProxy, NurbsSurfaceKnotList>(this, x => x._Instance).NotNull();
    foreach (var e in x)
    {
      yield return e;
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

  public void SetKnot(int index, double value) => _Instance[index] = value;
}

[Proxy(
  typeof(NurbsSurfacePointList),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "GetEnumerator" }
)]
public partial interface IRhinoNurbsSurfacePointListProxy : IRhinoNurbsSurfacePointList;

public partial class NurbsSurfacePointListProxy
{
  public IEnumerator<IRhinoControlPoint> GetEnumerator()
  {
    var x = A.Cast<IRhinoNurbsSurfacePointListProxy, NurbsSurfacePointList>(this, x => x._Instance).NotNull();
    foreach (var e in x)
    {
      yield return new ControlPointProxy(e);
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

[Proxy(
  typeof(Vector3d),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Equals" }
)]
public partial interface IRhinoVector3dProxy : IRhinoVector3d;

[Proxy(
  typeof(PointCloud),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "SolidOrientation" }
)]
public partial interface IRhinoPointCloudProxy : IRhinoPointCloud;

[Proxy(
  typeof(PointCloudItem),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "SolidOrientation" }
)]
public partial interface IRhinoPointCloudItemProxy : IRhinoPointCloudItem;
