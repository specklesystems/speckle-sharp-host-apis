namespace Rhino.Geometry;

public partial struct Plane : System.IEquatable<Rhino.Geometry.Plane>,Rhino.IEpsilonComparable<Rhino.Geometry.Plane>,System.ICloneable,Rhino.Geometry.IValidable,System.IFormattable
{
	public Plane() {}
	public Plane(Rhino.Geometry.Plane other) => throw new System.NotImplementedException();
	public Plane(Rhino.Geometry.Point3d origin,Rhino.Geometry.Vector3d normal) => throw new System.NotImplementedException();
	public Plane(Rhino.Geometry.Point3d origin,Rhino.Geometry.Vector3d xDirection,Rhino.Geometry.Vector3d yDirection) => throw new System.NotImplementedException();
	public Plane(Rhino.Geometry.Point3d origin,Rhino.Geometry.Point3d xPoint,Rhino.Geometry.Point3d yPoint) => throw new System.NotImplementedException();
	public Plane(System.Double a,System.Double b,System.Double c,System.Double d) => throw new System.NotImplementedException();
	public static Rhino.Geometry.PlaneFitResult FitPlaneToPoints(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,out Rhino.Geometry.Plane plane) => throw new System.NotImplementedException();
	public static Rhino.Geometry.PlaneFitResult FitPlaneToPoints(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,out Rhino.Geometry.Plane plane,out System.Double maximumDeviation) => throw new System.NotImplementedException();
	public  System.Boolean Equals(Rhino.Geometry.Plane plane) => throw new System.NotImplementedException();
	public  System.String ToString(System.String format,System.IFormatProvider formatProvider) => throw new System.NotImplementedException();
	public  System.Double[] GetPlaneEquation() => throw new System.NotImplementedException();
	public  System.Boolean UpdateEquation() => throw new System.NotImplementedException();
	public  System.Double ValueAt(Rhino.Geometry.Point3d p) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d PointAt(System.Double u,System.Double v) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d PointAt(System.Double u,System.Double v,System.Double w) => throw new System.NotImplementedException();
	public  System.Boolean ExtendThroughBox(Rhino.Geometry.BoundingBox box,out Rhino.Geometry.Interval s,out Rhino.Geometry.Interval t) => throw new System.NotImplementedException();
	public  System.Boolean ExtendThroughBox(Rhino.Geometry.Box box,out Rhino.Geometry.Interval s,out Rhino.Geometry.Interval t) => throw new System.NotImplementedException();
	public  System.Boolean ClosestParameter(Rhino.Geometry.Point3d testPoint,out System.Double s,out System.Double t) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d ClosestPoint(Rhino.Geometry.Point3d testPoint) => throw new System.NotImplementedException();
	public  System.Double DistanceTo(Rhino.Geometry.Point3d testPoint) => throw new System.NotImplementedException();
	public  System.Boolean DistanceTo(Rhino.Geometry.BoundingBox bbox,out System.Double min,out System.Double max) => throw new System.NotImplementedException();
	public  System.Boolean RemapToPlaneSpace(Rhino.Geometry.Point3d ptSample,out Rhino.Geometry.Point3d ptPlane) => throw new System.NotImplementedException();
	public  void Flip() => throw new System.NotImplementedException();
	public  System.Boolean Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public  System.Boolean Translate(Rhino.Geometry.Vector3d delta) => throw new System.NotImplementedException();
	public  System.Boolean Rotate(System.Double sinAngle,System.Double cosAngle,Rhino.Geometry.Vector3d axis) => throw new System.NotImplementedException();
	public  System.Boolean Rotate(System.Double angle,Rhino.Geometry.Vector3d axis) => throw new System.NotImplementedException();
	public  System.Boolean Rotate(System.Double angle,Rhino.Geometry.Vector3d axis,Rhino.Geometry.Point3d centerOfRotation) => throw new System.NotImplementedException();
	public  System.Boolean Rotate(System.Double sinAngle,System.Double cosAngle,Rhino.Geometry.Vector3d axis,Rhino.Geometry.Point3d centerOfRotation) => throw new System.NotImplementedException();
	public  System.Boolean EpsilonEquals(Rhino.Geometry.Plane other,System.Double epsilon) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Plane Clone() => throw new System.NotImplementedException();
	System.Object System.ICloneable.Clone() => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d Origin
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double OriginX
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double OriginY
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double OriginZ
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  Rhino.Geometry.Vector3d XAxis
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  Rhino.Geometry.Vector3d YAxis
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  Rhino.Geometry.Vector3d ZAxis
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public static Rhino.Geometry.Plane WorldXY
	{
		get => throw new System.NotImplementedException();
	}
	public static Rhino.Geometry.Plane WorldYZ
	{
		get => throw new System.NotImplementedException();
	}
	public static Rhino.Geometry.Plane WorldZX
	{
		get => throw new System.NotImplementedException();
	}
	public static Rhino.Geometry.Plane Unset
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Vector3d Normal
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Boolean IsValid
	{
		get => throw new System.NotImplementedException();
	}
}
