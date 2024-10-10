namespace Rhino.Geometry;

public partial class Vector2f
  : System.IEquatable<Rhino.Geometry.Vector2f>,
    System.IComparable<Rhino.Geometry.Vector2f>,
    System.IComparable,
    Rhino.IEpsilonFComparable<Rhino.Geometry.Vector2f>,
    Rhino.Geometry.IValidable,
    System.IFormattable
{
  public Vector2f() { }

  public Vector2f(System.Single x, System.Single y) => throw new System.NotImplementedException();

  public virtual System.Boolean Equals(Rhino.Geometry.Vector2f vector) => throw new System.NotImplementedException();

  public virtual System.Boolean EpsilonEquals(Rhino.Geometry.Vector2f other, System.Single epsilon) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 CompareTo(Rhino.Geometry.Vector2f other) => throw new System.NotImplementedException();

  public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Unitize() => throw new System.NotImplementedException();

  public virtual System.Boolean Reverse() => throw new System.NotImplementedException();

  public virtual System.Boolean PerpendicularTo(Rhino.Geometry.Vector2f other) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector2f Add(Rhino.Geometry.Vector2f vector1, Rhino.Geometry.Vector2f vector2) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector2f Subtract(Rhino.Geometry.Vector2f vector1, Rhino.Geometry.Vector2f vector2) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector2f Negate(Rhino.Geometry.Vector2f vector) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Point2f Add(Rhino.Geometry.Point2f point, Rhino.Geometry.Vector2f vector) =>
    throw new System.NotImplementedException();

  public static System.Double Multiply(Rhino.Geometry.Vector2f point1, Rhino.Geometry.Vector2f point2) =>
    throw new System.NotImplementedException();

  System.Int32 System.IComparable.CompareTo(System.Object obj) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector2f Zero
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.Vector2f XAxis
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.Vector2f YAxis
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.Vector2f Unset
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Single X
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single Y
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsZero
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsUnitVector
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Single SquareLength
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Length
  {
    get => throw new System.NotImplementedException();
  }
}
