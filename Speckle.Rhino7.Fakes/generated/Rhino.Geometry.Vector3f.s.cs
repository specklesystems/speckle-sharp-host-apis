namespace Rhino.Geometry;

public partial struct Vector3f : System.IEquatable<Rhino.Geometry.Vector3f>,System.IComparable<Rhino.Geometry.Vector3f>,System.IComparable,Rhino.IEpsilonFComparable<Rhino.Geometry.Vector3f>,Rhino.Geometry.IValidable,System.IFormattable
{
	public Vector3f() {}
	public Vector3f(System.Single x,System.Single y,System.Single z) => throw new System.NotImplementedException();
	public  System.Boolean Equals(Rhino.Geometry.Vector3f vector) => throw new System.NotImplementedException();
	public  System.Boolean EpsilonEquals(Rhino.Geometry.Vector3f other,System.Single epsilon) => throw new System.NotImplementedException();
	public  System.Int32 CompareTo(Rhino.Geometry.Vector3f other) => throw new System.NotImplementedException();
	public  System.String ToString(System.String format,System.IFormatProvider formatProvider) => throw new System.NotImplementedException();
	public  System.Boolean Unitize() => throw new System.NotImplementedException();
	public  void Transform(Rhino.Geometry.Transform transformation) => throw new System.NotImplementedException();
	public  System.Boolean Rotate(System.Double angleRadians,Rhino.Geometry.Vector3f rotationAxis) => throw new System.NotImplementedException();
	public  System.Boolean Reverse() => throw new System.NotImplementedException();
	public  System.Boolean PerpendicularTo(Rhino.Geometry.Vector3f other) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Vector3f Add(Rhino.Geometry.Vector3f vector1,Rhino.Geometry.Vector3f vector2) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Vector3f Subtract(Rhino.Geometry.Vector3f vector1,Rhino.Geometry.Vector3f vector2) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Vector3f Negate(Rhino.Geometry.Vector3f vector) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Point3f Add(Rhino.Geometry.Point3f point,Rhino.Geometry.Vector3f vector) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Vector3f Multiply(Rhino.Geometry.Vector3f vector,System.Single t) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Vector3f Multiply(System.Single t,Rhino.Geometry.Vector3f vector) => throw new System.NotImplementedException();
	public static System.Double Multiply(Rhino.Geometry.Vector3f point1,Rhino.Geometry.Vector3f point2) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Vector3f Divide(Rhino.Geometry.Vector3f vector,System.Double t) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Vector3f Divide(Rhino.Geometry.Vector3f vector,System.Single t) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Vector3f CrossProduct(Rhino.Geometry.Vector3f a,Rhino.Geometry.Vector3f b) => throw new System.NotImplementedException();
	System.Int32 System.IComparable.CompareTo(System.Object obj) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Vector3f Zero
	{
		get => throw new System.NotImplementedException();
	}
	public static Rhino.Geometry.Vector3f XAxis
	{
		get => throw new System.NotImplementedException();
	}
	public static Rhino.Geometry.Vector3f YAxis
	{
		get => throw new System.NotImplementedException();
	}
	public static Rhino.Geometry.Vector3f ZAxis
	{
		get => throw new System.NotImplementedException();
	}
	public static Rhino.Geometry.Vector3f Unset
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Single X
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Single Y
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Single Z
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Boolean IsZero
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Boolean IsUnitVector
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Boolean IsValid
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Single SquareLength
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Single Length
	{
		get => throw new System.NotImplementedException();
	}
}
