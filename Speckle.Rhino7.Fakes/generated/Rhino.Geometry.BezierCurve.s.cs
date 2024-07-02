namespace Rhino.Geometry;

public partial class BezierCurve : System.IDisposable,System.Runtime.Serialization.ISerializable
{
	public BezierCurve() {}
	public BezierCurve(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point2d> controlPoints) => throw new System.NotImplementedException();
	public BezierCurve(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> controlPoints) => throw new System.NotImplementedException();
	public BezierCurve(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point4d> controlPoints) => throw new System.NotImplementedException();
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info,System.Runtime.Serialization.StreamingContext context) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public static Rhino.Geometry.BezierCurve CreateLoftedBezier(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points) => throw new System.NotImplementedException();
	public static Rhino.Geometry.BezierCurve CreateLoftedBezier(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point2d> points) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BoundingBox GetBoundingBox(System.Boolean accurate) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d PointAt(System.Double t) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Vector3d TangentAt(System.Double t) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Vector3d CurvatureAt(System.Double t) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.NurbsCurve ToNurbsCurve() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point2d GetControlVertex2d(System.Int32 index) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d GetControlVertex3d(System.Int32 index) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point4d GetControlVertex4d(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Boolean MakeRational() => throw new System.NotImplementedException();
	public virtual System.Boolean MakeNonRational() => throw new System.NotImplementedException();
	public virtual System.Boolean IncreaseDegree(System.Int32 desiredDegree) => throw new System.NotImplementedException();
	public virtual System.Boolean ChangeDimension(System.Int32 desiredDimension) => throw new System.NotImplementedException();
	public static Rhino.Geometry.BezierCurve CreateCubicBeziers(Rhino.Geometry.Curve sourceCurve,System.Double distanceTolerance,System.Double kinkTolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.BezierCurve CreateBeziers(Rhino.Geometry.Curve sourceCurve) => throw new System.NotImplementedException();
	public virtual System.Int32 Dimension
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsValid
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsRational
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 ControlVertexCount
	{
		get => throw new System.NotImplementedException();
	}
}
