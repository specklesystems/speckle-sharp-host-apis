namespace Rhino.Geometry;

public partial struct Vector2f : System.IEquatable<Rhino.Geometry.Vector2f>,System.IComparable<Rhino.Geometry.Vector2f>,System.IComparable,Rhino.IEpsilonFComparable<Rhino.Geometry.Vector2f>,Rhino.Geometry.IValidable,System.IFormattable
{
	public Vector2f() {}
	public Vector2f(System.Single x,System.Single y) => throw new System.NotImplementedException();
	public  System.Boolean Equals(Rhino.Geometry.Vector2f vector) => throw new System.NotImplementedException();
	public  System.Boolean EpsilonEquals(Rhino.Geometry.Vector2f other,System.Single epsilon) => throw new System.NotImplementedException();
	public  System.Int32 CompareTo(Rhino.Geometry.Vector2f other) => throw new System.NotImplementedException();
	public  System.String ToString(System.String format,System.IFormatProvider formatProvider) => throw new System.NotImplementedException();
	public  System.Double Multiply(Rhino.Geometry.Vector2f point1,Rhino.Geometry.Vector2f point2) => throw new System.NotImplementedException();
	System.Int32 System.IComparable.CompareTo(System.Object obj) => throw new System.NotImplementedException();
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
	public  System.Single SquareLength
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Boolean IsValid
	{
		get => throw new System.NotImplementedException();
	}
}
