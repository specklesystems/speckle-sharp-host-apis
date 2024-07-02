namespace Rhino.Geometry;

public partial class BrepVertex : Rhino.Geometry.Point
{
	public BrepVertex() {}
	public virtual System.Int32[] EdgeIndices() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep Brep
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 VertexIndex
	{
		get => throw new System.NotImplementedException();
	}
}
