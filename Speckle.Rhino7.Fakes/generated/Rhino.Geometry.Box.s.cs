namespace Rhino.Geometry;

public partial struct Box : Rhino.IEpsilonComparable<Rhino.Geometry.Box>,System.ICloneable
{
	public Box() {}
	public Box(Rhino.Geometry.Box other) => throw new System.NotImplementedException();
	public Box(Rhino.Geometry.BoundingBox bbox) => throw new System.NotImplementedException();
	public Box(Rhino.Geometry.Plane basePlane,Rhino.Geometry.Interval xSize,Rhino.Geometry.Interval ySize,Rhino.Geometry.Interval zSize) => throw new System.NotImplementedException();
	public Box(Rhino.Geometry.Plane basePlane,System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points) => throw new System.NotImplementedException();
	public Box(Rhino.Geometry.Plane basePlane,Rhino.Geometry.GeometryBase geometry) => throw new System.NotImplementedException();
	public Box(Rhino.Geometry.Plane basePlane,Rhino.Geometry.BoundingBox boundingbox) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d PointAt(System.Double x,System.Double y,System.Double z) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d ClosestPoint(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d FurthestPoint(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public  void Inflate(System.Double amount) => throw new System.NotImplementedException();
	public  void Inflate(System.Double xAmount,System.Double yAmount,System.Double zAmount) => throw new System.NotImplementedException();
	public  System.Boolean Contains(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public  System.Boolean Contains(Rhino.Geometry.Point3d point,System.Boolean strict) => throw new System.NotImplementedException();
	public  System.Boolean Contains(Rhino.Geometry.BoundingBox box) => throw new System.NotImplementedException();
	public  System.Boolean Contains(Rhino.Geometry.BoundingBox box,System.Boolean strict) => throw new System.NotImplementedException();
	public  System.Boolean Contains(Rhino.Geometry.Box box) => throw new System.NotImplementedException();
	public  System.Boolean Contains(Rhino.Geometry.Box box,System.Boolean strict) => throw new System.NotImplementedException();
	public  void Union(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public  System.Boolean MakeValid() => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d[] GetCorners() => throw new System.NotImplementedException();
	public  System.Boolean Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public  void RepositionBasePlane(Rhino.Geometry.Point3d origin) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Brep ToBrep() => throw new System.NotImplementedException();
	public  Rhino.Geometry.Extrusion ToExtrusion() => throw new System.NotImplementedException();
	public  System.Boolean EpsilonEquals(Rhino.Geometry.Box other,System.Double epsilon) => throw new System.NotImplementedException();
	System.Object System.ICloneable.Clone() => throw new System.NotImplementedException();
	public static Rhino.Geometry.Box Empty
	{
		get => throw new System.NotImplementedException();
	}
	public static Rhino.Geometry.Box Unset
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Boolean IsValid
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Plane Plane
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  Rhino.Geometry.Interval X
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  Rhino.Geometry.Interval Y
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  Rhino.Geometry.Interval Z
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  Rhino.Geometry.Point3d Center
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.BoundingBox BoundingBox
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Double Area
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Double Volume
	{
		get => throw new System.NotImplementedException();
	}
}
