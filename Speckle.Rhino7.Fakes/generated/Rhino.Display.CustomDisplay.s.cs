namespace Rhino.Display;

public partial class CustomDisplay : System.IDisposable
{
	public CustomDisplay() {}
	public CustomDisplay(System.Boolean enable) => throw new System.NotImplementedException();
	public virtual void Clear() => throw new System.NotImplementedException();
	public virtual void AddPoint(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public virtual void AddPoints(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points) => throw new System.NotImplementedException();
	public virtual void AddLine(Rhino.Geometry.Line line) => throw new System.NotImplementedException();
	public virtual void AddVector(Rhino.Geometry.Point3d anchor,Rhino.Geometry.Vector3d span) => throw new System.NotImplementedException();
	public virtual void AddArc(Rhino.Geometry.Arc arc) => throw new System.NotImplementedException();
	public virtual void AddCircle(Rhino.Geometry.Circle circle) => throw new System.NotImplementedException();
	public virtual void AddCurve(Rhino.Geometry.Curve curve) => throw new System.NotImplementedException();
	public virtual void AddText(System.String text,Rhino.Geometry.Plane plane,System.Double size) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean Enabled
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsDisposed
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.BoundingBox ClippingBox
	{
		get => throw new System.NotImplementedException();
	}
}
