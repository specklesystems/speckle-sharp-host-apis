namespace Rhino.Geometry;

public partial struct Quaternion : System.IEquatable<Rhino.Geometry.Quaternion>,Rhino.IEpsilonComparable<Rhino.Geometry.Quaternion>
{
	public Quaternion() {}
	public Quaternion(System.Double a,System.Double b,System.Double c,System.Double d) => throw new System.NotImplementedException();
	public  System.Boolean Equals(Rhino.Geometry.Quaternion other) => throw new System.NotImplementedException();
	public  System.Boolean EpsilonEquals(Rhino.Geometry.Quaternion other,System.Double epsilon) => throw new System.NotImplementedException();
	public  void Set(System.Double a,System.Double b,System.Double c,System.Double d) => throw new System.NotImplementedException();
	public  System.Boolean Invert() => throw new System.NotImplementedException();
	public  System.Double DistanceTo(Rhino.Geometry.Quaternion q) => throw new System.NotImplementedException();
	public static System.Double Distance(Rhino.Geometry.Quaternion p,Rhino.Geometry.Quaternion q) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Transform MatrixForm() => throw new System.NotImplementedException();
	public  System.Boolean Unitize() => throw new System.NotImplementedException();
	public  void SetRotation(System.Double angle,Rhino.Geometry.Vector3d axisOfRotation) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Quaternion Rotation(System.Double angle,Rhino.Geometry.Vector3d axisOfRotation) => throw new System.NotImplementedException();
	public  void SetRotation(Rhino.Geometry.Plane plane0,Rhino.Geometry.Plane plane1) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Quaternion Rotation(Rhino.Geometry.Plane plane0,Rhino.Geometry.Plane plane1) => throw new System.NotImplementedException();
	public  System.Boolean GetRotation(out System.Double angle,out Rhino.Geometry.Vector3d axis) => throw new System.NotImplementedException();
	public  System.Boolean GetRotation(out Rhino.Geometry.Plane plane) => throw new System.NotImplementedException();
	public  System.Boolean GetRotation(out Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Vector3d Rotate(Rhino.Geometry.Vector3d v) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Quaternion Product(Rhino.Geometry.Quaternion p,Rhino.Geometry.Quaternion q) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Quaternion CrossProduct(Rhino.Geometry.Quaternion p,Rhino.Geometry.Quaternion q) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Quaternion Zero
	{
		get => throw new System.NotImplementedException();
	}
	public static Rhino.Geometry.Quaternion Identity
	{
		get => throw new System.NotImplementedException();
	}
	public static Rhino.Geometry.Quaternion I
	{
		get => throw new System.NotImplementedException();
	}
	public static Rhino.Geometry.Quaternion J
	{
		get => throw new System.NotImplementedException();
	}
	public static Rhino.Geometry.Quaternion K
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Double A
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double B
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double C
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double D
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Boolean IsValid
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Quaternion Conjugate
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Quaternion Inverse
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Double Length
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Double LengthSquared
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Vector3d Vector
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Double Scalar
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Boolean IsZero
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Boolean IsScalar
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Boolean IsVector
	{
		get => throw new System.NotImplementedException();
	}
}
