namespace Rhino.Geometry;

public partial struct Point3d
{
	public Point3d() {}
	public Point3d(System.Double x,System.Double y,System.Double z) => throw new System.NotImplementedException();
	public Point3d(Rhino.Geometry.Vector3d vector) => throw new System.NotImplementedException();
	public Point3d(Rhino.Geometry.Point3f point) => throw new System.NotImplementedException();
	public Point3d(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public Point3d(Rhino.Geometry.Point4d point) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d Multiply(Rhino.Geometry.Point3d point,System.Double t) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d Multiply(System.Double t,Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d Divide(Rhino.Geometry.Point3d point,System.Double t) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d Add(Rhino.Geometry.Point3d point1,Rhino.Geometry.Point3d point2) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d Add(Rhino.Geometry.Point3d point,Rhino.Geometry.Vector3d vector) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d Add(Rhino.Geometry.Point3d point,Rhino.Geometry.Vector3f vector) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d Add(Rhino.Geometry.Vector3d vector,Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d Subtract(Rhino.Geometry.Point3d point,Rhino.Geometry.Vector3d vector) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Vector3d Subtract(Rhino.Geometry.Point3d point1,Rhino.Geometry.Point3d point2) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d FromPoint3f(Rhino.Geometry.Point3f point) => throw new System.NotImplementedException();
	public  System.Double get_Item(System.Int32 index) => throw new System.NotImplementedException();
	public  void set_Item(System.Int32 index,System.Double value) => throw new System.NotImplementedException();
	public  System.Boolean EpsilonEquals(Rhino.Geometry.Point3d other,System.Double epsilon) => throw new System.NotImplementedException();
	public  System.Int32 CompareTo(Rhino.Geometry.Point3d other) => throw new System.NotImplementedException();
	public  System.Boolean Equals(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public  void Interpolate(Rhino.Geometry.Point3d pA,Rhino.Geometry.Point3d pB,System.Double t) => throw new System.NotImplementedException();
	public  System.String ToString(System.String format,System.IFormatProvider formatProvider) => throw new System.NotImplementedException();
	public  System.Double DistanceTo(Rhino.Geometry.Point3d other) => throw new System.NotImplementedException();
	public  System.Double DistanceToSquared(Rhino.Geometry.Point3d other) => throw new System.NotImplementedException();
	public  void Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d CullDuplicates(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,System.Double tolerance) => throw new System.NotImplementedException();
	public  System.Boolean ArePointsCoplanar(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,System.Double tolerance) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d SortAndCullPointList(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,System.Double minimumDistance) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d Origin
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Point3d Unset
	{
		get => throw new System.NotImplementedException();
	}
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
	public  System.Double Z
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
}
