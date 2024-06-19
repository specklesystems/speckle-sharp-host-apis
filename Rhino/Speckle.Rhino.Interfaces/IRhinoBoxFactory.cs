namespace Speckle.Rhino7.Interfaces;

public interface IRhinoBoxFactory
{
  IRhinoBox CreateBox(IRhinoBoundingBox boundingBox);
}

public interface IRhinoIntervalFactory
{
  IRhinoInterval Create(double x, double y);
}

public interface IRhinoCurveFactory
{
  IRhinoNurbsCurve Create(int degree, int pointCount);
  IRhinoPolyCurve Create();
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

public interface IRhinoBrepFactory
{
  IRhinoBrep Create();
}

public interface IRhinoNgonFactory
{
  IRhinoMeshNgon Create(IList<int> faces, IList<int> indices);
}
