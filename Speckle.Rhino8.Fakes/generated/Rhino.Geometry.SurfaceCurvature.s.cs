namespace Rhino.Geometry;

public partial class SurfaceCurvature
{
  public SurfaceCurvature() { }

  public virtual Rhino.Geometry.Vector3d Direction(System.Int32 direction) =>
    throw new System.NotImplementedException();

  public virtual System.Double Kappa(System.Int32 direction) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Circle OsculatingCircle(System.Int32 direction) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point2d UVPoint
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point3d Point
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d Normal
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Gaussian
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Mean
  {
    get => throw new System.NotImplementedException();
  }
}
