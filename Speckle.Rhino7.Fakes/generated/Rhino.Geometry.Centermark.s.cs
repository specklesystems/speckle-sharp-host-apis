namespace Rhino.Geometry;

public partial class Centermark : Rhino.Geometry.Dimension
{
  public Centermark() { }

  public static Rhino.Geometry.Centermark Create(
    Rhino.DocObjects.DimensionStyle dimStyle,
    Rhino.Geometry.Plane plane,
    Rhino.Geometry.Point3d centerpoint,
    System.Double radius
  ) => throw new System.NotImplementedException();
}
