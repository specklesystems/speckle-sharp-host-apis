namespace Rhino.Geometry.Collections;

public partial class BrepLoopList : System.Collections.Generic.IEnumerable<Rhino.Geometry.BrepLoop>,System.Collections.IEnumerable,Rhino.Collections.IRhinoTable<Rhino.Geometry.BrepLoop>
{
	public BrepLoopList() {}
	public virtual Rhino.Geometry.BrepLoop Add(Rhino.Geometry.BrepLoopType loopType) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BrepLoop Add(Rhino.Geometry.BrepLoopType loopType,Rhino.Geometry.BrepFace face) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BrepLoop AddOuterLoop(System.Int32 faceIndex) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BrepLoop AddPlanarFaceLoop(System.Int32 faceIndex,Rhino.Geometry.BrepLoopType loopType,System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> boundaryCurves) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerator<Rhino.Geometry.BrepLoop> GetEnumerator() => throw new System.NotImplementedException();
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
	public virtual System.Int32 Count
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.BrepLoop this[System.Int32 index]
	{
		get => throw new System.NotImplementedException();
	}
}
