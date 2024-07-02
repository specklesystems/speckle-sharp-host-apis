namespace Rhino.Geometry;

public partial class SubD : Rhino.Geometry.GeometryBase
{
	public SubD() {}
	public virtual Rhino.Geometry.Brep ToBrep(Rhino.Geometry.SubDToBrepOptions options) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep ToBrep() => throw new System.NotImplementedException();
	public static Rhino.Geometry.SubD CreateFromMesh(Rhino.Geometry.Mesh mesh) => throw new System.NotImplementedException();
	public static Rhino.Geometry.SubD CreateFromMesh(Rhino.Geometry.Mesh mesh,Rhino.Geometry.SubDCreationOptions options) => throw new System.NotImplementedException();
	public static Rhino.Geometry.SubD CreateFromSurface(Rhino.Geometry.Surface surface,Rhino.Geometry.SubDFromSurfaceMethods method,System.Boolean corners) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.SubD Offset(System.Double distance,System.Boolean solidify) => throw new System.NotImplementedException();
	public static Rhino.Geometry.SubD CreateFromLoft(System.Collections.Generic.IEnumerable<Rhino.Geometry.NurbsCurve> curves,System.Boolean closed,System.Boolean addCorners,System.Boolean addCreases,System.Int32 divisions) => throw new System.NotImplementedException();
	public static Rhino.Geometry.SubD CreateFromSweep(Rhino.Geometry.NurbsCurve rail1,System.Collections.Generic.IEnumerable<Rhino.Geometry.NurbsCurve> shapes,System.Boolean closed,System.Boolean addCorners,System.Boolean roadlikeFrame,Rhino.Geometry.Vector3d roadlikeNormal) => throw new System.NotImplementedException();
	public static Rhino.Geometry.SubD CreateFromSweep(Rhino.Geometry.NurbsCurve rail1,Rhino.Geometry.NurbsCurve rail2,System.Collections.Generic.IEnumerable<Rhino.Geometry.NurbsCurve> shapes,System.Boolean closed,System.Boolean addCorners) => throw new System.NotImplementedException();
	public virtual System.Boolean MergeAllCoplanarFaces(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean MergeAllCoplanarFaces(System.Double tolerance,System.Double angleTolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.SubD CreateFromCylinder(Rhino.Geometry.Cylinder cylinder,System.UInt32 circumferenceFaceCount,System.UInt32 heightFaceCount,Rhino.Geometry.SubDEndCapStyle endCapStyle,Rhino.Geometry.SubDEdgeTag endCapEdgeTag,Rhino.Geometry.SubDComponentLocation radiusLocation) => throw new System.NotImplementedException();
	public virtual void ClearEvaluationCache() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.SubDComponent ComponentFromComponentIndex(Rhino.Geometry.ComponentIndex componentIndex) => throw new System.NotImplementedException();
	public virtual System.UInt32 UpdateAllTagsAndSectorCoefficients() => throw new System.NotImplementedException();
	public virtual System.Boolean Subdivide(System.Int32 count) => throw new System.NotImplementedException();
	public virtual System.Boolean InterpolateSurfacePoints(Rhino.Geometry.Point3d[] surfacePoints) => throw new System.NotImplementedException();
	public virtual System.Boolean IsSolid
	{
		get => throw new System.NotImplementedException();
	}
}
