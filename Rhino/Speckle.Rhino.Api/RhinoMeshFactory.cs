using Rhino;
using Rhino.Collections;
using Rhino.Geometry;
using Speckle.ProxyGenerator;
using Speckle.Rhino7.Interfaces;
using Speckle.Shared;

namespace Speckle.Rhino7.Api;

public class RhinoMeshFactory : IRhinoMeshFactory
{
  public IRhinoMesh Create() => new MeshProxy(new Mesh());

  public IEnumerable<IRhinoMesh> CreateFromBrep(IRhinoBrep brep, double density, double minimumEdgeLength)
  {
    var b = brep.To<IRhinoBrepProxy>()._Instance;
    return Mesh.CreateFromBrep(b, new MeshingParameters(density, minimumEdgeLength)).Select(x => new MeshProxy(x));
  }
}

public class RhinoArcFactory : IRhinoArcFactory
{
  public IRhinoArc Create(IRhinoPoint3d startPoint, IRhinoPoint3d midPoint, IRhinoPoint3d endPoint) =>
    new ArcProxy(
      new Arc(
        startPoint.To<IRhinoPoint3dProxy>()._Instance,
        midPoint.To<IRhinoPoint3dProxy>()._Instance,
        endPoint.To<IRhinoPoint3dProxy>()._Instance
      )
    );

  public IRhinoArcCurve Create(IRhinoArc arc, IRhinoInterval domain) =>
    new ArcCurveProxy(
      new ArcCurve(arc.To<IRhinoArcProxy>()._Instance) { Domain = domain.To<IRhinoIntervalProxy>()._Instance }
    );
}

public class RhinoPointFactory : IRhinoPointFactory
{
  public IRhinoPoint2f Create(double x, double y) => new Point2fProxy(new Point2f(x, y));

  public IRhinoPoint3d Create(double x, double y, double z) => new Point3dProxy(new Point3d(x, y, z));

  public IRhinoPoint Create(IRhinoPoint3d point3d) =>
    new PointProxy(new Point(point3d.To<IRhinoPoint3dProxy>()._Instance));

  public IRhinoPoint3dList Create(IList<IRhinoPoint3d> list) =>
    new Point3dListProxy(new Point3dList(list.Select(x => x.To<IRhinoPoint3dProxy>()._Instance)));
}

public class RhinoIntervalFactory : IRhinoIntervalFactory
{
  public IRhinoInterval Create(double x, double y) => new IntervalProxy(new Interval(x, y));
}

public class RhinoCircleFactory : IRhinoCircleFactory
{
  public IRhinoCircle Create(IRhinoPlane plane, double raduis) =>
    new CircleProxy(new Circle(plane.To<IRhinoPlaneProxy>()._Instance, raduis));

  public IRhinoArcCurve Create(IRhinoCircle arc, IRhinoInterval domain) =>
    new ArcCurveProxy(
      new ArcCurve(arc.To<IRhinoCircleProxy>()._Instance) { Domain = domain.To<IRhinoIntervalProxy>()._Instance }
    );
}

public class RhinoCurveFactory : IRhinoCurveFactory
{
  public IRhinoNurbsCurve Create(int degree, int pointCount) => new NurbsCurveProxy(new NurbsCurve(degree, pointCount));

  public IRhinoPolyCurve Create() => new PolyCurveProxy(new PolyCurve());
}

public class RhinoLineFactory : IRhinoLineFactory
{
  public IRhinoLine Create(IRhinoPoint3d start, IRhinoPoint3d end) =>
    new LineProxy(new Line(start.To<IRhinoPoint3dProxy>()._Instance, end.To<IRhinoPoint3dProxy>()._Instance));

  public IRhinoLineCurve Create(IRhinoLine line) =>
    new LineCurveProxy(new LineCurve(line.To<IRhinoLineProxy>()._Instance));

  public IRhinoPolyline Create(IRhinoPoint3dList list) =>
    new PolylineProxy(new Polyline(list.Select(x => x.To<IRhinoPoint3dProxy>()._Instance)));
}

public class RhinoPlaneFactory : IRhinoPlaneFactory
{
  public IRhinoPlane Create(IRhinoPoint3d origin, IRhinoVector3d xdir, IRhinoVector3d ydir) =>
    new PlaneProxy(
      new Plane(
        origin.To<IRhinoPoint3dProxy>()._Instance,
        xdir.To<IRhinoVector3dProxy>()._Instance,
        ydir.To<IRhinoVector3dProxy>()._Instance
      )
    );
}

public class RhinoSurfaceFactory : IRhinoSurfaceFactory
{
  public IRhinoNurbsSurface Create(
    int dimension,
    bool isRational,
    int order0,
    int order1,
    int controlPointCount0,
    int controlPointCount1
  ) =>
    new NurbsSurfaceProxy(
      NurbsSurface.Create(dimension, isRational, order0, order1, controlPointCount0, controlPointCount1)
    );
}

public class RhinoTransformFactory : IRhinoTransformFactory
{
  public IRhinoPoint3d Origin => new Point3dProxy(Point3d.Origin);
  public IRhinoTransform Identity => new TransformProxy(Transform.Identity);

  public IRhinoTransform Scale(IRhinoPoint3d origin, double y) =>
    new TransformProxy(Transform.Scale(origin.To<IRhinoPoint3dProxy>()._Instance, y));
}

public class RhinoPointCloudFactory : IRhinoPointCloudFactory
{
  public IRhinoPointCloud Create(IRhinoPoint3dList list) =>
    new PointCloudProxy(new PointCloud(list.To<IRhinoPoint3dListProxy>()._Instance));
}

public class RhinoVectorFactory : IRhinoVectorFactory
{
  public IRhinoVector3d Create(double x, double y, double z) => new Vector3dProxy(new Vector3d(x, y, z));
}

public class RhinoEllipseFactory : IRhinoEllipseFactory
{
  public IRhinoEllipse Create(IRhinoPlane plane, double firstRadius, double secondRaduis) =>
    new EllipseProxy(new Ellipse(plane.To<IRhinoPlaneProxy>()._Instance, firstRadius, secondRaduis));
}

public class RhinoBrepFactory : IRhinoBrepFactory
{
  public IRhinoBrep Create() => new BrepProxy(new Brep());
}

public class RhinoNgonFactory : IRhinoNgonFactory
{
  public IRhinoMeshNgon Create(IList<int> faces, IList<int> indices) =>
    new MeshNgonProxy(MeshNgon.Create(faces, indices));
}

public class RhinoDocFactory : IRhinoDocFactory
{
  public IRhinoDoc ActiveDoc() => new RhinoDocProxy(RhinoDoc.ActiveDoc);
}
