namespace Rhino.Geometry;

public partial class SumSurface : Rhino.Geometry.Surface
{
  public SumSurface() { }

  public static Rhino.Geometry.SumSurface Create(Rhino.Geometry.Curve curveA, Rhino.Geometry.Curve curveB) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.SumSurface Create(
    Rhino.Geometry.Curve curve,
    Rhino.Geometry.Vector3d extrusionDirection
  ) => throw new System.NotImplementedException();
}
