namespace Rhino.Geometry;

public partial class MeshNgon : System.IEquatable<Rhino.Geometry.MeshNgon>,System.IComparable<Rhino.Geometry.MeshNgon>,System.IComparable
{
	public MeshNgon() {}
	public static Rhino.Geometry.MeshNgon Create(System.Collections.Generic.IList<System.Int32> meshVertexIndexList,System.Collections.Generic.IList<System.Int32> meshFaceIndexList) => throw new System.NotImplementedException();
	public virtual System.Int32 get_Item(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.UInt32[] BoundaryVertexIndexList() => throw new System.NotImplementedException();
	public virtual System.UInt32[] FaceIndexList() => throw new System.NotImplementedException();
	public virtual void Set(System.Collections.Generic.IList<System.Int32> meshVertexIndexList,System.Collections.Generic.IList<System.Int32> meshFaceIndexList) => throw new System.NotImplementedException();
	public virtual System.Boolean Equals(Rhino.Geometry.MeshNgon otherNgon) => throw new System.NotImplementedException();
	public virtual System.Int32 CompareTo(Rhino.Geometry.MeshNgon otherNgon) => throw new System.NotImplementedException();
	public static  Rhino.Geometry.MeshNgon Empty
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 BoundaryVertexCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 FaceCount
	{
		get => throw new System.NotImplementedException();
	}
}
