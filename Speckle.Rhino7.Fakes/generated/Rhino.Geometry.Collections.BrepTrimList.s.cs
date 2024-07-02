namespace Rhino.Geometry.Collections;

public partial class BrepTrimList : System.Collections.Generic.IEnumerable<Rhino.Geometry.BrepTrim>,System.Collections.IEnumerable,Rhino.Collections.IRhinoTable<Rhino.Geometry.BrepTrim>
{
	public BrepTrimList() {}
	public virtual Rhino.Geometry.BrepTrim Add(System.Int32 curve2dIndex) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BrepTrim Add(System.Boolean rev3d,Rhino.Geometry.BrepLoop loop,System.Int32 curve2dIndex) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BrepTrim Add(System.Boolean rev3d,Rhino.Geometry.BrepEdge edge,System.Int32 curve2dIndex) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BrepTrim Add(Rhino.Geometry.BrepEdge edge,System.Boolean rev3d,Rhino.Geometry.BrepLoop loop,System.Int32 curve2dIndex) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BrepTrim AddSingularTrim(Rhino.Geometry.BrepVertex vertex,Rhino.Geometry.BrepLoop loop,Rhino.Geometry.IsoStatus iso,System.Int32 curve2dIndex) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BrepTrim AddCurveOnFace(Rhino.Geometry.BrepFace face,Rhino.Geometry.BrepEdge edge,System.Boolean rev3d,System.Int32 curve2dIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean MatchEnds() => throw new System.NotImplementedException();
	public virtual System.Boolean MatchEnds(System.Int32 trimIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean MatchEnds(Rhino.Geometry.BrepTrim trim0,Rhino.Geometry.BrepTrim trim1) => throw new System.NotImplementedException();
	public virtual System.Boolean MatchEnds(Rhino.Geometry.BrepLoop loop) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerator<Rhino.Geometry.BrepTrim> GetEnumerator() => throw new System.NotImplementedException();
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
	public virtual System.Int32 Count
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.BrepTrim this[System.Int32 index]
	{
		get => throw new System.NotImplementedException();
	}
}
