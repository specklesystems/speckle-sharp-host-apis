namespace Rhino.Geometry.Collections;

public partial class NurbsSurfacePointList : System.Collections.Generic.IEnumerable<Rhino.Geometry.ControlPoint>,System.Collections.IEnumerable,Rhino.IEpsilonComparable<Rhino.Geometry.Collections.NurbsSurfacePointList>
{
	public NurbsSurfacePointList() {}
	public virtual void EnsurePrivateCopy() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point2d GetGrevillePoint(System.Int32 u,System.Int32 v) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.ControlPoint GetControlPoint(System.Int32 u,System.Int32 v) => throw new System.NotImplementedException();
	public virtual System.Boolean SetControlPoint(System.Int32 u,System.Int32 v,Rhino.Geometry.ControlPoint cp) => throw new System.NotImplementedException();
	public virtual System.Boolean SetControlPoint(System.Int32 u,System.Int32 v,Rhino.Geometry.Point3d cp) => throw new System.NotImplementedException();
	public virtual System.Boolean SetPoint(System.Int32 u,System.Int32 v,System.Double x,System.Double y,System.Double z) => throw new System.NotImplementedException();
	public virtual System.Boolean SetPoint(System.Int32 u,System.Int32 v,System.Double x,System.Double y,System.Double z,System.Double weight) => throw new System.NotImplementedException();
	public virtual System.Boolean SetPoint(System.Int32 u,System.Int32 v,Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public virtual System.Boolean SetPoint(System.Int32 u,System.Int32 v,Rhino.Geometry.Point4d point) => throw new System.NotImplementedException();
	public virtual System.Boolean SetPoint(System.Int32 u,System.Int32 v,Rhino.Geometry.Point3d point,System.Double weight) => throw new System.NotImplementedException();
	public virtual System.Boolean SetWeight(System.Int32 u,System.Int32 v,System.Double weight) => throw new System.NotImplementedException();
	public virtual System.Double GetWeight(System.Int32 u,System.Int32 v) => throw new System.NotImplementedException();
	public virtual System.Boolean EpsilonEquals(Rhino.Geometry.Collections.NurbsSurfacePointList other,System.Double epsilon) => throw new System.NotImplementedException();
	System.Collections.Generic.IEnumerator<Rhino.Geometry.ControlPoint> System.Collections.Generic.IEnumerable<Rhino.Geometry.ControlPoint>.GetEnumerator() => throw new System.NotImplementedException();
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
	public virtual System.Int32 CountU
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 CountV
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 PointSize
	{
		get => throw new System.NotImplementedException();
	}
}
