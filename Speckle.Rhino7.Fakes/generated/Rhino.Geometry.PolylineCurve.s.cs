namespace Rhino.Geometry;

public partial class PolylineCurve : Rhino.Geometry.Curve
{
	public PolylineCurve() {}
	public PolylineCurve(Rhino.Geometry.PolylineCurve other) => throw new System.NotImplementedException();
	public PolylineCurve(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d Point(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void SetPoint(System.Int32 index,Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public virtual System.Double Parameter(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void SetParameter(System.Int32 index,System.Double parameter) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Polyline ToPolyline() => throw new System.NotImplementedException();
	public virtual System.Int32 PointCount
	{
		get => throw new System.NotImplementedException();
	}
}
