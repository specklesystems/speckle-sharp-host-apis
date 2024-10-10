namespace Rhino.Geometry;

public partial class ClippingPlaneSurface : Rhino.Geometry.PlaneSurface
{
  public ClippingPlaneSurface() { }

  public ClippingPlaneSurface(Rhino.Geometry.Plane plane)
    : base(plane) => throw new System.NotImplementedException();

  public ClippingPlaneSurface(Rhino.Geometry.PlaneSurface planeSurface) => throw new System.NotImplementedException();

  public virtual System.Guid[] ViewportIds() => throw new System.NotImplementedException();

  public virtual System.Boolean AddClipViewportId(System.Guid viewportId) => throw new System.NotImplementedException();

  public virtual System.Boolean RemoveClipViewportId(System.Guid viewportId) =>
    throw new System.NotImplementedException();

  public virtual void SetClipParticipation(
    System.Collections.Generic.IEnumerable<System.Guid> objectIds,
    System.Collections.Generic.IEnumerable<System.Int32> layerIndices,
    System.Boolean isExclusionList
  ) => throw new System.NotImplementedException();

  public virtual void GetClipParticipation(
    out System.Collections.Generic.IEnumerable<System.Guid> objectIds,
    out System.Collections.Generic.IEnumerable<System.Int32> layerIndices,
    out System.Boolean isExclusionList
  ) => throw new System.NotImplementedException();

  public virtual void ClearClipParticipationLists() => throw new System.NotImplementedException();

  public virtual System.Double PlaneDepth
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean PlaneDepthEnabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ParticipationListsEnabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
