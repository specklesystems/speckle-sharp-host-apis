namespace Rhino.Geometry;

public partial struct Plane
{
	public Plane() {}
	public Plane(Rhino.Geometry.Plane other) => throw new System.NotImplementedException();
	public Plane(Rhino.Geometry.Point3d origin,Rhino.Geometry.Vector3d normal) => throw new System.NotImplementedException();
	public Plane(Rhino.Geometry.Point3d origin,Rhino.Geometry.Vector3d xDirection,Rhino.Geometry.Vector3d yDirection) => throw new System.NotImplementedException();
	public Plane(Rhino.Geometry.Point3d origin,Rhino.Geometry.Point3d xPoint,Rhino.Geometry.Point3d yPoint) => throw new System.NotImplementedException();
	public Plane(System.Double a,System.Double b,System.Double c,System.Double d) => throw new System.NotImplementedException();
	public  System.Boolean Equals(Rhino.Geometry.Plane plane) => throw new System.NotImplementedException();
	public  System.String ToString(System.String format,System.IFormatProvider formatProvider) => throw new System.NotImplementedException();
	public  System.Double[] GetPlaneEquation() => throw new System.NotImplementedException();
	public  System.Boolean UpdateEquation() => throw new System.NotImplementedException();
	public  System.Double ValueAt(Rhino.Geometry.Point3d p) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d PointAt(System.Double u,System.Double v) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d PointAt(System.Double u,System.Double v,System.Double w) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d ClosestPoint(Rhino.Geometry.Point3d testPoint) => throw new System.NotImplementedException();
	public  System.Double DistanceTo(Rhino.Geometry.Point3d testPoint) => throw new System.NotImplementedException();
	public  void Flip() => throw new System.NotImplementedException();
	public  System.Boolean Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public  System.Boolean Translate(Rhino.Geometry.Vector3d delta) => throw new System.NotImplementedException();
	public  System.Boolean Rotate(System.Double sinAngle,System.Double cosAngle,Rhino.Geometry.Vector3d axis) => throw new System.NotImplementedException();
	public  System.Boolean Rotate(System.Double angle,Rhino.Geometry.Vector3d axis) => throw new System.NotImplementedException();
	public  System.Boolean Rotate(System.Double angle,Rhino.Geometry.Vector3d axis,Rhino.Geometry.Point3d centerOfRotation) => throw new System.NotImplementedException();
	public  System.Boolean Rotate(System.Double sinAngle,System.Double cosAngle,Rhino.Geometry.Vector3d axis,Rhino.Geometry.Point3d centerOfRotation) => throw new System.NotImplementedException();
	public  System.Boolean EpsilonEquals(Rhino.Geometry.Plane other,System.Double epsilon) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Plane Clone() => throw new System.NotImplementedException();
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
	public  Rhino.Geometry.Plane WorldXY
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Plane WorldYZ
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Plane WorldZX
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Plane Unset
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