namespace Rhino.Geometry;

public partial class PlaneSurface : Rhino.Geometry.Surface
{
  public PlaneSurface() { }

  public PlaneSurface(Rhino.Geometry.Plane plane, Rhino.Geometry.Interval xExtents, Rhino.Geometry.Interval yExtents) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.PlaneSurface CreateThroughBox(
    Rhino.Geometry.Line lineInPlane,
    Rhino.Geometry.Vector3d vectorInPlane,
    Rhino.Geometry.BoundingBox box
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.PlaneSurface CreateThroughBox(
    Rhino.Geometry.Plane plane,
    Rhino.Geometry.BoundingBox box
  ) => throw new System.NotImplementedException();
}
