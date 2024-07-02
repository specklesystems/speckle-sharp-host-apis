namespace Rhino.Geometry.Collections;

public partial class NurbsSurfaceKnotList : System.Collections.Generic.IEnumerable<System.Double>,System.Collections.IEnumerable,Rhino.Collections.IRhinoTable<System.Double>,Rhino.IEpsilonComparable<Rhino.Geometry.Collections.NurbsSurfaceKnotList>
{
	public NurbsSurfaceKnotList() {}
	public virtual System.Double SuperfluousKnot(System.Boolean start) => throw new System.NotImplementedException();
	public virtual void EnsurePrivateCopy() => throw new System.NotImplementedException();
	public virtual System.Boolean InsertKnot(System.Double value) => throw new System.NotImplementedException();
	public virtual System.Boolean InsertKnot(System.Double value,System.Int32 multiplicity) => throw new System.NotImplementedException();
	public virtual System.Int32 KnotMultiplicity(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Boolean CreateUniformKnots(System.Double knotSpacing) => throw new System.NotImplementedException();
	public virtual System.Boolean CreatePeriodicKnots(System.Double knotSpacing) => throw new System.NotImplementedException();
	public virtual System.Int32 RemoveMultipleKnots(System.Int32 minimumMultiplicity,System.Int32 maximumMultiplicity,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean RemoveKnots(System.Int32 index0,System.Int32 index1) => throw new System.NotImplementedException();
	public virtual System.Boolean RemoveKnotsAt(System.Double u,System.Double v) => throw new System.NotImplementedException();
	public virtual System.Boolean EpsilonEquals(Rhino.Geometry.Collections.NurbsSurfaceKnotList other,System.Double epsilon) => throw new System.NotImplementedException();
	System.Collections.Generic.IEnumerator<System.Double> System.Collections.Generic.IEnumerable<System.Double>.GetEnumerator() => throw new System.NotImplementedException();
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
	public virtual System.Int32 Count
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean ClampedAtStart
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean ClampedAtEnd
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.KnotStyle KnotStyle
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double this[System.Int32 index]
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
