namespace Rhino.Geometry;

public partial struct Point2d
{
	public Point2d() {}
	public Point2d(System.Double x,System.Double y) => throw new System.NotImplementedException();
	public Point2d(Rhino.Geometry.Vector2d vector) => throw new System.NotImplementedException();
	public Point2d(Rhino.Geometry.Point2d point) => throw new System.NotImplementedException();
	public Point2d(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point2d Multiply(Rhino.Geometry.Point2d point,System.Double t) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point2d Multiply(System.Double t,Rhino.Geometry.Point2d point) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point2d Divide(Rhino.Geometry.Point2d point,System.Double t) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point2d Add(Rhino.Geometry.Point2d point,Rhino.Geometry.Vector2d vector) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point2d Add(Rhino.Geometry.Vector2d vector,Rhino.Geometry.Point2d point) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point2d Add(Rhino.Geometry.Point2d point1,Rhino.Geometry.Point2d point2) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point2d Subtract(Rhino.Geometry.Point2d point,Rhino.Geometry.Vector2d vector) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Vector2d Subtract(Rhino.Geometry.Point2d point1,Rhino.Geometry.Point2d point2) => throw new System.NotImplementedException();
	public  System.Boolean Equals(Rhino.Geometry.Point2d point) => throw new System.NotImplementedException();
	public  System.Int32 CompareTo(Rhino.Geometry.Point2d other) => throw new System.NotImplementedException();
	public  System.Boolean EpsilonEquals(Rhino.Geometry.Point2d other,System.Double epsilon) => throw new System.NotImplementedException();
	public  System.String ToString(System.String format,System.IFormatProvider formatProvider) => throw new System.NotImplementedException();
	public  System.Double get_Item(System.Int32 index) => throw new System.NotImplementedException();
	public  void set_Item(System.Int32 index,System.Double value) => throw new System.NotImplementedException();
	public  System.Double DistanceTo(Rhino.Geometry.Point2d other) => throw new System.NotImplementedException();
	public  void Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public  System.Double X
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double Y
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Boolean IsValid
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Double MinimumCoordinate
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Double MaximumCoordinate
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Point2d Origin
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Point2d Unset
	{
		get => throw new System.NotImplementedException();
	}
}