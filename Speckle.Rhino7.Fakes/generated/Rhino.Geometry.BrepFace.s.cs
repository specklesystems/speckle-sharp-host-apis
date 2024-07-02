namespace Rhino.Geometry;

public partial class BrepFace : Rhino.Geometry.SurfaceProxy
{
	public BrepFace() {}
	public virtual Rhino.Geometry.Point3d[] PullPointsToFace(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep RemoveHoles(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep CreateExtrusion(Rhino.Geometry.Curve pathCurve,System.Boolean cap) => throw new System.NotImplementedException();
	public virtual System.Boolean ShrinkFace(Rhino.Geometry.BrepFace.ShrinkDisableSide disableSide) => throw new System.NotImplementedException();
	public virtual System.Boolean ShrinkSurfaceToEdge() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep DuplicateFace(System.Boolean duplicateMeshes) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Surface DuplicateSurface() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Surface UnderlyingSurface() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep Split(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.PointFaceRelation IsPointOnFace(System.Double u,System.Double v) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.PointFaceRelation IsPointOnFace(System.Double u,System.Double v,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Interval[] TrimAwareIsoIntervals(System.Int32 direction,System.Double constantParameter) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] TrimAwareIsoCurve(System.Int32 direction,System.Double constantParameter) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Mesh GetMesh(Rhino.Geometry.MeshType meshType) => throw new System.NotImplementedException();
	public virtual System.Boolean SetMesh(Rhino.Geometry.MeshType meshType,Rhino.Geometry.Mesh mesh) => throw new System.NotImplementedException();
	public virtual System.Int32[] AdjacentEdges() => throw new System.NotImplementedException();
	public virtual System.Int32[] AdjacentFaces() => throw new System.NotImplementedException();
	public virtual System.Boolean ChangeSurface(System.Int32 surfaceIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean RebuildEdges(System.Double tolerance,System.Boolean rebuildSharedEdges,System.Boolean rebuildVertices) => throw new System.NotImplementedException();
	public virtual void ClearMaterialChannelIndex() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep Brep
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean OrientationIsReversed
	{
		get => throw new System.NotImplementedException();
		set {}
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
		set {}
	}
	public virtual System.Guid Id
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
