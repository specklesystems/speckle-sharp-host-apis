namespace Speckle.Rhino7.Interfaces;

public interface IRhinoBoxFactory
{
  IRhinoBox CreateBox(IRhinoBoundingBox boundingBox);
}
public interface IRhinoSurfaceFactory
{
  IRhinoNurbsSurface Create(
    int dimension,
    bool isRational,
    int order0,
    int order1,
    int controlPointCount0,
    int controlPointCount1);
}
public interface IRhinoMeshFactory
{
  IRhinoMesh Create();
  IEnumerable<IRhinoMesh> CreateFromBrep(IRhinoBrep brep, double density, double minimumEdgeLength);
}

public interface IRhinoArcFactory
{
  IRhinoArc Create(IRhinoPoint3d startPoint, IRhinoPoint3d midPoint, IRhinoPoint3d endPoint);
  IRhinoArcCurve Create(IRhinoArc arc, IRhinoInterval domain);
}

public interface IRhinoPointFactory
{
  IRhinoPoint3d Create(double x, double y, double z);
  IRhinoPoint Create(IRhinoPoint3d point3d);
  IRhinoPoint3dList Create(IList<IRhinoPoint3d> list);
}
public interface IRhinoIntervalFactory
{
  IRhinoInterval Create(double x, double y);
}

public interface IRhinoCircleFactory
{
  IRhinoCircle Create(IRhinoPlane plane, double radius);
  IRhinoArcCurve Create(IRhinoCircle circle, IRhinoInterval domain);
}
public interface IRhinoCurveFactory
{
  IRhinoNurbsCurve Create(int degree, int pointCount);
  IRhinoPolyCurve Create();
}
public interface IRhinoLineFactory
{
  IRhinoLine Create(IRhinoPoint3d start, IRhinoPoint3d end);
  IRhinoLineCurve Create(IRhinoLine line);
  IRhinoPolyline Create(IRhinoPoint3dList list);
}

public interface IRhinoPlaneFactory
{
  IRhinoPlane Create(IRhinoPoint3d origin, IRhinoVector3d xdir, IRhinoVector3d ydir);
}
public interface IRhinoPointCloudFactory
{
  IRhinoPointCloud Create(IRhinoPoint3dList list);
}
public interface IRhinoVectorFactory
{
  IRhinoVector3d Create(double x, double y, double z);
}
public interface IRhinoEllipseFactory
{
  IRhinoEllipse Create(IRhinoPlane plane, double firstRadius, double secondRaduis);
}
