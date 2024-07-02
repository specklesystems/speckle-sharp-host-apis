namespace Rhino.Geometry;

public partial class MeshPoint
{
	public MeshPoint() {}
	public virtual System.Boolean GetTriangle(out System.Int32 a,out System.Int32 b,out System.Int32 c) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Mesh Mesh
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double EdgeParameter
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.ComponentIndex ComponentIndex
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 EdgeIndex
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 FaceIndex
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Char Triangle
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double[] T
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Point3d Point
	{
		get => throw new System.NotImplementedException();
	}
}
