namespace Rhino.Geometry;

public partial class ClippingPlaneSurface : Rhino.Geometry.PlaneSurface
{
  public ClippingPlaneSurface() { }

  public virtual System.Guid[] ViewportIds() => throw new System.NotImplementedException();

  public virtual System.Boolean AddClipViewportId(System.Guid viewportId) => throw new System.NotImplementedException();

  public virtual System.Boolean RemoveClipViewportId(System.Guid viewportId) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Plane Plane
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
