namespace Rhino.Geometry.Collections;

public partial class SubDEdgeList : System.Collections.Generic.IEnumerable<Rhino.Geometry.SubDEdge>,System.Collections.IEnumerable
{
	public SubDEdgeList() {}
	public virtual Rhino.Geometry.SubDEdge Find(System.UInt32 id) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.SubDEdge Find(System.Int32 id) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerator<Rhino.Geometry.SubDEdge> GetEnumerator() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.SubDEdge Add(Rhino.Geometry.SubDEdgeTag tag,Rhino.Geometry.SubDVertex v0,Rhino.Geometry.SubDVertex v1) => throw new System.NotImplementedException();
	public virtual void SetEdgeTags(System.Collections.Generic.IEnumerable<System.Int32> edgeIndices,Rhino.Geometry.SubDEdgeTag tag) => throw new System.NotImplementedException();
	public virtual void SetEdgeTags(System.Collections.Generic.IEnumerable<Rhino.Geometry.SubDEdge> edges,Rhino.Geometry.SubDEdgeTag tag) => throw new System.NotImplementedException();
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
	public virtual System.Int32 Count
	{
		get => throw new System.NotImplementedException();
	}
}
