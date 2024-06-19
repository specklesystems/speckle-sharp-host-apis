namespace Speckle.Rhino7.Interfaces;

public interface IRhinoPointFactory
{
  IRhinoPoint2f Create(double x, double y);
  IRhinoPoint3d Create(double x, double y, double z);
  IRhinoPoint Create(IRhinoPoint3d point3d);
  IRhinoPoint3dList Create(IList<IRhinoPoint3d> list);
}
