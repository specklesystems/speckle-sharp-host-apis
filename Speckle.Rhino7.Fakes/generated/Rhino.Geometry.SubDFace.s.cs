namespace Rhino.Geometry;

public partial class SubDFace : Rhino.Geometry.SubDComponent
{
	public SubDFace() {}
	public virtual Rhino.Geometry.ComponentIndex ComponentIndex() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.SubDEdge EdgeAt(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Boolean EdgeDirectionMatchesFaceOrientation(System.Int32 index) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.SubDVertex VertexAt(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Int32 EdgeCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 VertexCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Drawing.Color PerFaceColor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Point3d LimitSurfaceCenterPoint
	{
		get => throw new System.NotImplementedException();
	}
}
