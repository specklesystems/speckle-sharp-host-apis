namespace Rhino.Geometry.Collections;

public partial class BrepVertexList : System.Collections.Generic.IEnumerable<Rhino.Geometry.BrepVertex>,System.Collections.IEnumerable,Rhino.Collections.IRhinoTable<Rhino.Geometry.BrepVertex>
{
	public BrepVertexList() {}
	public virtual Rhino.Geometry.BrepVertex Add() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BrepVertex Add(Rhino.Geometry.Point3d point,System.Double vertexTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BrepVertex AddPointOnFace(Rhino.Geometry.BrepFace face,System.Double s,System.Double t) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerator<Rhino.Geometry.BrepVertex> GetEnumerator() => throw new System.NotImplementedException();
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
	public virtual System.Int32 Count
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.BrepVertex this[System.Int32 index]
	{
		get => throw new System.NotImplementedException();
	}
}
