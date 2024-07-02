namespace Rhino.Geometry;

public partial class Point : Rhino.Geometry.GeometryBase
{
  public Point() { }

  public Point(Rhino.Geometry.Point3d location) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d Location
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
