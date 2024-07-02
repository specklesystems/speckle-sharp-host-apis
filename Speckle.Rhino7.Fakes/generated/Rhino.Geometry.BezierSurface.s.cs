namespace Rhino.Geometry;

public partial class BezierSurface : System.IDisposable
{
	public BezierSurface() {}
	public virtual void Dispose() => throw new System.NotImplementedException();
	public static Rhino.Geometry.BezierSurface CreateLoftedBezier(System.Collections.Generic.IEnumerable<Rhino.Geometry.BezierCurve> curves) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BoundingBox GetBoundingBox(System.Boolean accurate) => throw new System.NotImplementedException();
	public virtual System.Boolean Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Interval Domain(System.Int32 direction) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BezierSurface Reverse(System.Int32 direction) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BezierSurface Transpose() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d PointAt(System.Double u,System.Double v) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.NurbsSurface ToNurbsSurface() => throw new System.NotImplementedException();
	public virtual System.Int32 ControlVertexCount(System.Int32 direction) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point2d GetControlVertex2d(System.Int32 i,System.Int32 j) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d GetControlVertex3d(System.Int32 i,System.Int32 j) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point4d GetControlVertex4d(System.Int32 i,System.Int32 j) => throw new System.NotImplementedException();
	public virtual System.Boolean MakeRational() => throw new System.NotImplementedException();
	public virtual System.Boolean MakeNonRational() => throw new System.NotImplementedException();
	public virtual System.Boolean Split(System.Int32 direction,System.Double t,out Rhino.Geometry.BezierSurface left,out Rhino.Geometry.BezierSurface right) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValid
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 Dimension
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsRational
	{
		get => throw new System.NotImplementedException();
	}
}
