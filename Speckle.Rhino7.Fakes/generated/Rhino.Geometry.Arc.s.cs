namespace Rhino.Geometry;

public partial struct Arc : System.IEquatable<Rhino.Geometry.Arc>,Rhino.IEpsilonComparable<Rhino.Geometry.Arc>,System.ICloneable
{
	public Arc() {}
	public Arc(Rhino.Geometry.Circle circle,System.Double angleRadians) => throw new System.NotImplementedException();
	public Arc(Rhino.Geometry.Circle circle,Rhino.Geometry.Interval angleIntervalRadians) => throw new System.NotImplementedException();
	public Arc(Rhino.Geometry.Plane plane,System.Double radius,System.Double angleRadians) => throw new System.NotImplementedException();
	public Arc(Rhino.Geometry.Point3d center,System.Double radius,System.Double angleRadians) => throw new System.NotImplementedException();
	public Arc(Rhino.Geometry.Plane plane,Rhino.Geometry.Point3d center,System.Double radius,System.Double angleRadians) => throw new System.NotImplementedException();
	public Arc(Rhino.Geometry.Point3d startPoint,Rhino.Geometry.Point3d pointOnInterior,Rhino.Geometry.Point3d endPoint) => throw new System.NotImplementedException();
	public Arc(Rhino.Geometry.Point3d pointA,Rhino.Geometry.Vector3d tangentA,Rhino.Geometry.Point3d pointB) => throw new System.NotImplementedException();
	public  System.Boolean Trim(Rhino.Geometry.Interval domain) => throw new System.NotImplementedException();
	public  System.Boolean Equals(Rhino.Geometry.Arc other) => throw new System.NotImplementedException();
	public  Rhino.Geometry.BoundingBox BoundingBox() => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d PointAt(System.Double t) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Vector3d TangentAt(System.Double t) => throw new System.NotImplementedException();
	public  System.Double ClosestParameter(Rhino.Geometry.Point3d testPoint) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d ClosestPoint(Rhino.Geometry.Point3d testPoint) => throw new System.NotImplementedException();
	public  void Reverse() => throw new System.NotImplementedException();
	public  System.Boolean Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public  Rhino.Geometry.NurbsCurve ToNurbsCurve() => throw new System.NotImplementedException();
	public  System.Boolean EpsilonEquals(Rhino.Geometry.Arc other,System.Double epsilon) => throw new System.NotImplementedException();
	public  Rhino.Geometry.NurbsCurve ToNurbsCurve(System.Int32 degree,System.Int32 cvCount) => throw new System.NotImplementedException();
	System.Object System.ICloneable.Clone() => throw new System.NotImplementedException();
	public  Rhino.Geometry.Arc Unset
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Boolean IsValid
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Boolean IsCircle
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Plane Plane
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double Radius
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double Diameter
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  Rhino.Geometry.Point3d Center
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double Circumference
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Double Length
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Point3d StartPoint
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Point3d MidPoint
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Point3d EndPoint
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Interval AngleDomain
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double StartAngle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double EndAngle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double Angle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double StartAngleDegrees
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double EndAngleDegrees
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double AngleDegrees
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
