namespace Rhino.Geometry;

public partial class BrepFace : Rhino.Geometry.SurfaceProxy
{
  public BrepFace() { }

  public virtual Rhino.Geometry.Point3d[] PullPointsToFace(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,
    System.Double tolerance
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean DraftAnglePoint(
    Rhino.Geometry.Point2d testPoint,
    System.Double testAngle,
    Rhino.Geometry.Vector3d pullDirection,
    System.Boolean edge,
    out Rhino.Geometry.Point3d draftPoint,
    out System.Double draftAngle
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep RemoveHoles(System.Double tolerance) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep CreateExtrusion(Rhino.Geometry.Curve pathCurve, System.Boolean cap) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean ShrinkFace(Rhino.Geometry.BrepFace.ShrinkDisableSide disableSide) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean ShrinkSurfaceToEdge() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep DuplicateFace(System.Boolean duplicateMeshes) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Surface DuplicateSurface() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Surface UnderlyingSurface() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep Split(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves,
    System.Double tolerance
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.PointFaceRelation IsPointOnFace(System.Double u, System.Double v) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.PointFaceRelation IsPointOnFace(
    System.Double u,
    System.Double v,
    System.Double tolerance
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Interval[] TrimAwareIsoIntervals(
    System.Int32 direction,
    System.Double constantParameter
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Curve[] TrimAwareIsoCurve(System.Int32 direction, System.Double constantParameter) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh GetMesh(Rhino.Geometry.MeshType meshType) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetMesh(Rhino.Geometry.MeshType meshType, Rhino.Geometry.Mesh mesh) =>
    throw new System.NotImplementedException();

  public virtual System.Int32[] AdjacentEdges() => throw new System.NotImplementedException();

  public virtual System.Int32[] AdjacentFaces() => throw new System.NotImplementedException();

  public virtual System.Boolean ChangeSurface(System.Int32 surfaceIndex) => throw new System.NotImplementedException();

  public virtual System.Boolean RebuildEdges(
    System.Double tolerance,
    System.Boolean rebuildSharedEdges,
    System.Boolean rebuildVertices
  ) => throw new System.NotImplementedException();

  public virtual void SetPackId(System.UInt32 packId) => throw new System.NotImplementedException();

  public virtual void ClearPackId() => throw new System.NotImplementedException();

  public virtual void ClearMaterialChannelIndex() => throw new System.NotImplementedException();

  public virtual System.Boolean FilletSurfaceToRail(
    Rhino.Geometry.Curve curveOnFace,
    Rhino.Geometry.BrepFace secondFace,
    System.Double u1,
    System.Double v1,
    System.Int32 railDegree,
    System.Int32 arcDegree,
    System.Collections.Generic.IEnumerable<System.Double> arcSliders,
    System.Int32 numBezierSrfs,
    System.Boolean extend,
    Rhino.Geometry.FilletSurfaceSplitType split_type,
    System.Double tolerance,
    System.Collections.Generic.List<Rhino.Geometry.Brep> out_fillets,
    System.Collections.Generic.List<Rhino.Geometry.Brep> out_breps0,
    System.Collections.Generic.List<Rhino.Geometry.Brep> out_breps1,
    out System.Double[] fitResults
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean FilletSurfaceToCurve(
    Rhino.Geometry.Curve curve,
    System.Double t,
    System.Double u,
    System.Double v,
    System.Double radius,
    System.Int32 alignToCurve,
    System.Int32 railDegree,
    System.Int32 arcDegree,
    System.Collections.Generic.IEnumerable<System.Double> arcSliders,
    System.Int32 numBezierSrfs,
    System.Double tolerance,
    System.Collections.Generic.List<Rhino.Geometry.Brep> out_fillets,
    out System.Double[] fitResults
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep Brep
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean OrientationIsReversed
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsSurface
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 FaceIndex
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 SurfaceIndex
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Collections.BrepLoopList Loops
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.BrepLoop OuterLoop
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 MaterialChannelIndex
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.UInt32 PackId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.UInt32 ProxyBrepSubDFaceId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Guid Id
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color PerFaceColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
