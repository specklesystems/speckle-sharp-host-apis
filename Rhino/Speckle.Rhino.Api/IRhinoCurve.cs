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
// ReSharper disable RedundantExtendsListEntry
// ReSharper disable All

namespace Speckle.Rhino7.Api;

[Proxy(typeof(RhinoDoc), new[] { "Equals", "ModelUnitSystem" })]
public partial interface IRhinoDocProxy : IRhinoDoc;

public partial class RhinoDocProxy
{
  public RhinoUnitSystem ModelUnitSystem => EnumUtility<UnitSystem, RhinoUnitSystem>.Convert(_Instance.ModelUnitSystem);
}

[Proxy(typeof(Curve), new[] { "Duplicate" })]
public partial interface IRhinoCurveProxy : IRhinoCurve;

[Proxy(typeof(GeometryBase), new[] { "Transform" })]
public partial interface IRhinoGeometryBaseProxy : IRhinoGeometryBase;

public partial class GeometryBaseProxy
{
  public bool Transform(IRhinoTransform transform) =>
    _Instance.Transform(transform.To<IRhinoTransformProxy>().NotNull()._Instance);
}

[Proxy(typeof(CommonObject))]
public partial interface IRhinoCommonObjectProxy : IRhinoCommonObject;

[Proxy(typeof(RhinoObject), new[] { "ComponentType" })]
public partial interface IRhinoObjectProxy : IRhinoObject;

[Proxy(
  typeof(ModelComponent)
)]
public partial interface IRhinoModelComponentProxy : IRhinoModelComponent;

[Proxy(typeof(ArcCurve))]
public partial interface IRhinoArcCurveProxy : IRhinoArcCurve;

[Proxy(typeof(Circle))]
public partial interface IRhinoCircleProxy : IRhinoCircle;

[Proxy(typeof(Arc), new[] { "Equals" })]
public partial interface IRhinoArcProxy : IRhinoArc;

[Proxy(typeof(Interval), new[] { "Equals" })]
public partial interface IRhinoIntervalProxy : IRhinoInterval;

[Proxy(typeof(Point3d), new[] { "Equals" })]
public partial interface IRhinoPoint3dProxy : IRhinoPoint3d;

[Proxy(typeof(Box), new[] { "Equals" })]
public partial interface IRhinoBoxProxy : IRhinoBox;

[Proxy(typeof(BoundingBox), new[] { "Equals" })]
public partial interface IRhinoBoundingBoxProxy : IRhinoBoundingBox;

[Proxy(typeof(Brep), new[] { "SolidOrientation" })]
public partial interface IRhinoBrepProxy : IRhinoBrep;

public partial class BrepProxy
{
  public RhinoBrepSolidOrientation SolidOrientation
  {
    get
    {
      var e = _Instance.SolidOrientation;
      return EnumUtility<BrepSolidOrientation, RhinoBrepSolidOrientation>.Convert(e
      );
    }
  }
}

[Proxy(typeof(NurbsSurface))]
public partial interface IRhinoNurbsSurfaceProxy : IRhinoNurbsSurface;

[Proxy(typeof(Surface))]
public partial interface IRhinoSurfaceProxy : IRhinoSurface;

[Proxy(typeof(Mesh), new[] { "CreateRefinedLoopMesh", "GetNgonAndFacesEnumerable", "SetCachedTextureCoordinates" })]
public partial interface IRhinoMeshProxy : IRhinoMesh;

public partial class MeshProxy
{
  public IEnumerable<IRhinoMeshNgon> GetNgonAndFacesEnumerable()
  {
    foreach (var e in _Instance.GetNgonAndFacesEnumerable())
    {
      yield return new MeshNgonProxy(e);
    }
  }
}

[Proxy(typeof(MeshNgon), new[] { "Equals" })]
public partial interface IRhinoMeshNgonProxy : IRhinoMeshNgon;

[Proxy(typeof(MeshNgonList), new[] { "GetEnumerator" })]
public partial interface IRhinoMeshNgonListProxy : IRhinoMeshNgonList;

public partial class MeshNgonListProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

  public IEnumerator<IRhinoMeshNgon> GetEnumerator()
  {
    foreach (var e in _Instance)
    {
      yield return new MeshNgonProxy(e);
    }
  }
}

[Proxy(
  typeof(RefinementSettings)
)]
public partial interface IRhinoRefinementSettingsProxy : IRhinoRefinementSettings;

[Proxy(typeof(BrepVertex))]
public partial interface IRhinoBrepVertexProxy : IRhinoBrepVertex;

[Proxy(
  typeof(BrepVertexList),
  new[] { "GetEnumerator" }
)]
public partial interface IRhinoBrepVertexListProxy : IRhinoBrepVertexList;

public partial class BrepVertexListProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
  public IEnumerator<IRhinoBrepVertex> GetEnumerator()
  {
    foreach (var e in _Instance)
    {
      yield return new BrepVertexProxy(e);
    }
  }
}

[Proxy(typeof(Point))]
public partial interface IRhinoPointProxy : IRhinoPoint;

[Proxy(
  typeof(BrepCurveList),
  new[] { "GetEnumerator" }
)]
public partial interface IRhinoBrepCurveListProxy : IRhinoBrepCurveList;

public partial class BrepCurveListProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
  public IEnumerator<IRhinoCurve> GetEnumerator()
  {
    foreach (var e in _Instance)
    {
      yield return new CurveProxy(e);
    }
  }
}

[Proxy(
  typeof(BrepSurfaceList),
  new[] { "GetEnumerator" }
)]
public partial interface IRhinoBrepSurfaceListProxy : IRhinoBrepSurfaceList;

public partial class BrepSurfaceListProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
  public IEnumerator<IRhinoSurface> GetEnumerator()
  {
    foreach (var e in _Instance)
    {
      yield return new SurfaceProxy(e);
    }
  }
}

[Proxy(typeof(BrepFaceList),
  new[] { "GetEnumerator" })]
public partial interface IRhinoBrepFaceListProxy : IRhinoBrepFaceList;

public partial class BrepFaceListProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
  public IEnumerator<IRhinoBrepFace> GetEnumerator()
  {
    foreach (var e in _Instance)
    {
      yield return new BrepFaceProxy(e);
    }
  }
}

[Proxy(typeof(BrepFace))]
public partial interface IRhinoBrepFaceProxy : IRhinoBrepFace;

[Proxy(typeof(BrepLoopList), new[] { "Add",
  "GetEnumerator"  })]
public partial interface IRhinoBrepLoopListProxy : IRhinoBrepLoopList;

public partial class BrepLoopListProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
  public IEnumerator<IRhinoBrepLoop> GetEnumerator()
  {
    foreach (var e in _Instance)
    {
      yield return new BrepLoopProxy(e);
    }
  }

  public IRhinoBrepLoop Add(RhinoBrepLoopType type, IRhinoBrepFace face)
  {
    return A.Cast<IRhinoBrepLoop, BrepLoop>(
        _Instance.Add(
          EnumUtility<RhinoBrepLoopType, BrepLoopType>.Convert(type),
          face.To<IRhinoBrepFaceProxy>()._Instance
        )
      )
      .NotNull();
  }
}

[Proxy(typeof(BrepLoop), new[] { "LoopType" })]
public partial interface IRhinoBrepLoopProxy : IRhinoBrepLoop;

public partial class BrepLoopProxy
{
  public RhinoBrepLoopType LoopType => EnumUtility<BrepLoopType, RhinoBrepLoopType>.Convert(_Instance.LoopType);
}

[Proxy(typeof(BrepEdgeList),
  new[] { "GetEnumerator" })]
public partial interface IRhinoBrepEdgeListProxy : IRhinoBrepEdgeList;

public partial class BrepEdgeListProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
  public IEnumerator<IRhinoBrepEdge> GetEnumerator()
  {
    foreach (var e in _Instance)
    {
      yield return new BrepEdgeProxy(e);
    }
  }

}

[Proxy(typeof(BrepEdge))]
public partial interface IRhinoBrepEdgeProxy : IRhinoBrepEdge;

[Proxy(typeof(CurveProxy))]
public partial interface IRhinoCurveProxy2Proxy : IRhinoCurveProxy2;

[Proxy(typeof(BrepTrimList), new[] { "AddSingularTrim", "GetEnumerator" })]
public partial interface IRhinoBrepTrimListProxy : IRhinoBrepTrimList;

public partial class BrepTrimListProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
  public IEnumerator<IRhinoBrepTrim> GetEnumerator()
  {
    foreach (var e in _Instance)
    {
      yield return new BrepTrimProxy(e);
    }
  }

  public IRhinoBrepTrim AddSingularTrim(
    IRhinoBrepVertex vertex,
    IRhinoBrepLoop loop,
    RhinoIsoStatus status,
    int curveIndex
  ) =>
    A.Cast<IRhinoBrepTrim, BrepTrim>(
        _Instance.AddSingularTrim(
          vertex.To<IRhinoBrepVertexProxy>()._Instance,
          loop.To<IRhinoBrepLoopProxy>()._Instance,
          EnumUtility<RhinoIsoStatus, IsoStatus>.Convert(status),
          curveIndex
        )
      )
      .NotNull();
}

[Proxy(typeof(BrepTrim), new[] { "IsoStatus", "TrimType" })]
public partial interface IRhinoBrepTrimProxy : IRhinoBrepTrim;

public partial class BrepTrimProxy
{
  public RhinoIsoStatus IsoStatus
  {
    get => EnumUtility<IsoStatus, RhinoIsoStatus>.Convert(_Instance.IsoStatus);
    set => _Instance.IsoStatus = EnumUtility<RhinoIsoStatus, IsoStatus>.Convert(value);
  }

  public RhinoBrepTrimType TrimType
  {
    get => EnumUtility<BrepTrimType, RhinoBrepTrimType>.Convert(_Instance.TrimType);
    set => _Instance.TrimType = EnumUtility<RhinoBrepTrimType, BrepTrimType>.Convert(value);
  }
}

[Proxy(typeof(ControlPoint))]
public partial interface IRhinoControlPointProxy : IRhinoControlPoint;

[Proxy(typeof(PolyCurve))]
public partial interface IRhinoPolyCurveProxy : IRhinoPolyCurve;

[Proxy(
  typeof(PolylineCurve)
)]
public partial interface IRhinoPolylineCurveProxy : IRhinoPolylineCurve;

[Proxy(typeof(NurbsCurve))]
public partial interface IRhinoNurbsCurveProxy : IRhinoNurbsCurve;

[Proxy(typeof(LineCurve))]
public partial interface IRhinoLineCurveProxy : IRhinoLineCurve;

[Proxy(
  typeof(Transform),
  new[]
  {
    "Equals",
    "M00",
    "M01",
    "M02",
    "M03",
    "M10",
    "M11",
    "M12",
    "M13",
    "M20",
    "M21",
    "M22",
    "M23",
    "M30",
    "M31",
    "M32",
    "M33",
    "get_Item"
  }
)]
public partial interface IRhinoTransformProxy : IRhinoTransform;

[Proxy(typeof(Ellipse))]
public partial interface IRhinoEllipseProxy : IRhinoEllipse;

[Proxy(typeof(Line), new[] { "Equals" })]
public partial interface IRhinoLineProxy : IRhinoLine;

[Proxy(typeof(Point3f), new[] { "Equals" })]
public partial interface IRhinoPoint3fProxy : IRhinoPoint3f;

[Proxy(typeof(MeshVertexList), new[] { "GetEnumerator" })]
public partial interface IRhinoMeshVertexListProxy : IRhinoMeshVertexList;

public partial class MeshVertexListProxy
{
  public IEnumerator<IRhinoPoint3f> GetEnumerator()
  {
    foreach (var e in _Instance)
    {
      yield return new Point3fProxy(e);
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

[Proxy(typeof(MeshFace), new[] { "Equals", "IsValidEx", "RepairEx" })]
public partial interface IRhinoMeshFaceProxy : IRhinoMeshFace;

[Proxy(typeof(MeshFaceList), new[] { "GetEnumerator" })]
public partial interface IRhinoMeshFaceListProxy : IRhinoMeshFaceList;

public partial class MeshFaceListProxy
{
  public IEnumerator<IRhinoMeshFace> GetEnumerator()
  {
    foreach (var e in _Instance)
    {
      yield return new MeshFaceProxy(e);
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

[Proxy(typeof(Point2f), new[] { "Equals" })]
public partial interface IRhinoPoint2fProxy : IRhinoPoint2f;

[Proxy(typeof(MeshTextureCoordinateList), new[] { "GetEnumerator" })]
public partial interface IRhinoMeshTextureCoordinateListProxy : IRhinoMeshTextureCoordinateList;

public partial class MeshTextureCoordinateListProxy
{
  public IEnumerator<IRhinoPoint2f> GetEnumerator()
  {
    foreach (var e in _Instance)
    {
      yield return new Point2fProxy(e);
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

[Proxy(typeof(MeshVertexColorList), new[] { "GetEnumerator" })]
public partial interface IRhinoMeshVertexColorListProxy : IRhinoMeshVertexColorList;

public partial class MeshVertexColorListProxy
{
  public IEnumerator<System.Drawing.Color> GetEnumerator()
  {
    foreach (var e in _Instance)
    {
      yield return e;
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

[Proxy(typeof(Polyline), new[] { "Add", "GetEnumerator" })]
public partial interface IRhinoPolylineProxy : IRhinoPolyline;

public partial class PolylineProxy
{
  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

[Proxy(typeof(Point3dList), new[] { "Equals", "Duplicate", "GetEnumerator" })]
public partial interface IRhinoPoint3dListProxy : IRhinoPoint3dList;

public partial class Point3dListProxy
{
  public IEnumerator<IRhinoPoint3d> GetEnumerator()
  {
    foreach (var e in _Instance)
    {
      yield return new Point3dProxy(e);
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

  public int Count => _Instance.Count;

  public IRhinoPoint3d this[int index] => A.Call<IRhinoPoint3d>(() => _Instance[index]).NotNull();

  public void Add(IRhinoPoint3d point3d)
  {
    _Instance.Add(A.Cast<IRhinoPoint3dProxy, Point3d>(point3d, x => x._Instance));
  }
}

[Proxy(typeof(NurbsCurveKnotList), new[] { "GetEnumerator" })]
public partial interface IRhinoNurbsCurveKnotListProxy : IRhinoNurbsCurveKnotList;

public partial class NurbsCurveKnotListProxy
{
  public IEnumerator<double> GetEnumerator()
  {
    foreach (var e in _Instance)
    {
      yield return e;
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

  public void SetKnot(int index, double value) => _Instance[index] = value;
}

[Proxy(typeof(NurbsCurvePointList), new[] { "GetEnumerator" })]
public partial interface IRhinoNurbsCurvePointListProxy : IRhinoNurbsCurvePointList;

public partial class NurbsCurvePointListProxy
{
  public IEnumerator<IRhinoControlPoint> GetEnumerator()
  {
    foreach (var e in _Instance)
    {
      yield return new ControlPointProxy(e);
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

[Proxy(typeof(NurbsSurfaceKnotList), new[] { "GetEnumerator" })]
public partial interface IRhinoNurbsSurfaceKnotListProxy : IRhinoNurbsSurfaceKnotList;

public partial class NurbsSurfaceKnotListProxy
{
  public IEnumerator<double> GetEnumerator()
  {
    foreach (var e in _Instance)
    {
      yield return e;
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

  public void SetKnot(int index, double value) => _Instance[index] = value;
}

[Proxy(typeof(NurbsSurfacePointList), new[] { "GetEnumerator" })]
public partial interface IRhinoNurbsSurfacePointListProxy : IRhinoNurbsSurfacePointList;

public partial class NurbsSurfacePointListProxy
{
  public IEnumerator<IRhinoControlPoint> GetEnumerator()
  {
    foreach (var e in _Instance)
    {
      yield return new ControlPointProxy(e);
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

[Proxy(typeof(Vector3d), new[] { "Equals" })]
public partial interface IRhinoVector3dProxy : IRhinoVector3d;

[Proxy(typeof(PointCloud), new[] { "SolidOrientation" })]
public partial interface IRhinoPointCloudProxy : IRhinoPointCloud;

[Proxy(typeof(PointCloudItem), new[] { "SolidOrientation" })]
public partial interface IRhinoPointCloudItemProxy : IRhinoPointCloudItem;
