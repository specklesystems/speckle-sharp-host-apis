namespace Rhino.Geometry.Collections;

public partial class NurbsCurvePointList : System.Collections.Generic.IEnumerable<Rhino.Geometry.ControlPoint>,System.Collections.IEnumerable,Rhino.Collections.IRhinoTable<Rhino.Geometry.ControlPoint>,Rhino.IEpsilonComparable<Rhino.Geometry.Collections.NurbsCurvePointList>,System.Collections.Generic.IList<Rhino.Geometry.ControlPoint>,System.Collections.Generic.ICollection<Rhino.Geometry.ControlPoint>
{
	public NurbsCurvePointList() {}
	public virtual void EnsurePrivateCopy() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Polyline ControlPolygon() => throw new System.NotImplementedException();
	public virtual System.Boolean ChangeEndWeights(System.Double w0,System.Double w1) => throw new System.NotImplementedException();
	public virtual System.Boolean MakeRational() => throw new System.NotImplementedException();
	public virtual System.Boolean MakeNonRational() => throw new System.NotImplementedException();
	public virtual System.Boolean SetPoint(System.Int32 index,System.Double x,System.Double y,System.Double z) => throw new System.NotImplementedException();
	public virtual System.Boolean SetPoint(System.Int32 index,System.Double x,System.Double y,System.Double z,System.Double weight) => throw new System.NotImplementedException();
	public virtual System.Boolean SetPoint(System.Int32 index,Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public virtual System.Boolean SetPoint(System.Int32 index,Rhino.Geometry.Point4d point) => throw new System.NotImplementedException();
	public virtual System.Boolean SetPoint(System.Int32 index,Rhino.Geometry.Point3d point,System.Double weight) => throw new System.NotImplementedException();
	public virtual System.Boolean GetPoint(System.Int32 index,out Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public virtual System.Boolean GetPoint(System.Int32 index,out Rhino.Geometry.Point4d point) => throw new System.NotImplementedException();
	public virtual System.Boolean SetWeight(System.Int32 index,System.Double weight) => throw new System.NotImplementedException();
	public virtual System.Double GetWeight(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Boolean ValidateSpacing(System.Double closeTolerance,System.Double stackTolerance,out System.Int32[] closeIndices,out System.Int32[] stackedIndices) => throw new System.NotImplementedException();
	public virtual System.Boolean UVNDirectionsAt(System.Int32 index,out Rhino.Geometry.Vector3d uDir,out Rhino.Geometry.Vector3d vDir,out Rhino.Geometry.Vector3d nDir) => throw new System.NotImplementedException();
	public virtual System.Boolean EpsilonEquals(Rhino.Geometry.Collections.NurbsCurvePointList other,System.Double epsilon) => throw new System.NotImplementedException();
	public virtual System.Int32 IndexOf(Rhino.Geometry.ControlPoint item) => throw new System.NotImplementedException();
	public virtual System.Boolean Contains(Rhino.Geometry.ControlPoint item) => throw new System.NotImplementedException();
	public virtual void CopyTo(Rhino.Geometry.ControlPoint[] array,System.Int32 arrayIndex) => throw new System.NotImplementedException();
	System.Collections.Generic.IEnumerator<Rhino.Geometry.ControlPoint> System.Collections.Generic.IEnumerable<Rhino.Geometry.ControlPoint>.GetEnumerator() => throw new System.NotImplementedException();
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
	void System.Collections.Generic.IList<Rhino.Geometry.ControlPoint>.Insert(System.Int32 index,Rhino.Geometry.ControlPoint item) => throw new System.NotImplementedException();
	void System.Collections.Generic.IList<Rhino.Geometry.ControlPoint>.RemoveAt(System.Int32 index) => throw new System.NotImplementedException();
	void System.Collections.Generic.ICollection<Rhino.Geometry.ControlPoint>.Add(Rhino.Geometry.ControlPoint item) => throw new System.NotImplementedException();
	void System.Collections.Generic.ICollection<Rhino.Geometry.ControlPoint>.Clear() => throw new System.NotImplementedException();
	System.Boolean System.Collections.Generic.ICollection<Rhino.Geometry.ControlPoint>.Remove(Rhino.Geometry.ControlPoint item) => throw new System.NotImplementedException();
	public virtual System.Int32 Count
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.ControlPoint this[System.Int32 index]
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ControlPolygonLength
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 PointSize
	{
		get => throw new System.NotImplementedException();
	}
	System.Boolean System.Collections.Generic.ICollection<Rhino.Geometry.ControlPoint>.IsReadOnly
	{
		get => throw new System.NotImplementedException();
	}
}
