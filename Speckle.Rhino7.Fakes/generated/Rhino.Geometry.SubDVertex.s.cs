namespace Rhino.Geometry;

public partial class SubDVertex : Rhino.Geometry.SubDComponent
{
	public SubDVertex() {}
	public virtual Rhino.Geometry.SubDEdge EdgeAt(System.Int32 index) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.SubDFace FaceAt(System.Int32 index) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d SurfacePoint() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d ControlNetPoint
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 EdgeCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 FaceCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.SubDVertex Next
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.SubDVertex Previous
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.SubDVertexTag Tag
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Collections.Generic.IEnumerable<Rhino.Geometry.SubDEdge> Edges
	{
		get => throw new System.NotImplementedException();
	}
}
