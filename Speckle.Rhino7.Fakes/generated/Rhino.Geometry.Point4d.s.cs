namespace Rhino.Geometry;

public partial struct Point4d : System.Runtime.Serialization.ISerializable,System.IEquatable<Rhino.Geometry.Point4d>,Rhino.IEpsilonComparable<Rhino.Geometry.Point4d>,Rhino.Geometry.IValidable,System.IFormattable
{
	public Point4d() {}
	public Point4d(System.Double x,System.Double y,System.Double z,System.Double w) => throw new System.NotImplementedException();
	public Point4d(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public Point4d(Rhino.Geometry.Point4d point) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Point4d Add(Rhino.Geometry.Point4d point1,Rhino.Geometry.Point4d point2) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Point4d Subtract(Rhino.Geometry.Point4d point1,Rhino.Geometry.Point4d point2) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Point4d Multiply(Rhino.Geometry.Point4d point,System.Double d) => throw new System.NotImplementedException();
	public  System.Boolean Equals(Rhino.Geometry.Point4d point) => throw new System.NotImplementedException();
	public  System.Boolean EpsilonEquals(Rhino.Geometry.Point4d other,System.Double epsilon) => throw new System.NotImplementedException();
	public  void Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public  System.String ToString(System.String format,System.IFormatProvider formatProvider) => throw new System.NotImplementedException();
	void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info,System.Runtime.Serialization.StreamingContext context) => throw new System.NotImplementedException();
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
	public  System.Double W
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public static Rhino.Geometry.Point4d Unset
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Boolean IsValid
	{
		get => throw new System.NotImplementedException();
	}
}
