namespace Rhino.Geometry;

public partial class Centermark : Rhino.Geometry.Dimension
{
  public Centermark() { }

  public Centermark(Rhino.Geometry.Plane plane, Rhino.Geometry.Point3d centerPoint, System.Double radius) =>
    throw new System.NotImplementedException();

  public Centermark(Rhino.Geometry.Plane plane, Rhino.Geometry.Curve curve, System.Double curveParameter) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Centermark Create(
    Rhino.DocObjects.DimensionStyle dimStyle,
    Rhino.Geometry.Plane plane,
    Rhino.Geometry.Point3d centerPoint,
    System.Double radius
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Centermark Create(
    Rhino.DocObjects.DimensionStyle dimStyle,
    Rhino.Geometry.Plane plane,
    Rhino.Geometry.Curve curve,
    System.Double curveParameter
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean AdjustFromPoints(Rhino.Geometry.Plane plane, Rhino.Geometry.Point3d centerPoint) =>
    throw new System.NotImplementedException();

  public virtual System.Double Radius
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
