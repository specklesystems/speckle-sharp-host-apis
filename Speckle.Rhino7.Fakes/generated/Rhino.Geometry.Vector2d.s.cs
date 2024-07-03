namespace Rhino.Geometry;

public partial class Vector2d
  : System.Runtime.Serialization.ISerializable,
    System.IEquatable<Rhino.Geometry.Vector2d>,
    System.IComparable<Rhino.Geometry.Vector2d>,
    System.IComparable,
    Rhino.IEpsilonComparable<Rhino.Geometry.Vector2d>,
    Rhino.Geometry.IValidable,
    System.IFormattable
{
  public Vector2d() { }

  public Vector2d(System.Double x, System.Double y) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector2d Multiply(Rhino.Geometry.Vector2d vector, System.Double t) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector2d Multiply(System.Double t, Rhino.Geometry.Vector2d vector) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector2d Divide(Rhino.Geometry.Vector2d vector, System.Double t) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector2d Add(Rhino.Geometry.Vector2d vector1, Rhino.Geometry.Vector2d vector2) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector2d Subtract(Rhino.Geometry.Vector2d vector1, Rhino.Geometry.Vector2d vector2) =>
    throw new System.NotImplementedException();

  public static System.Double Multiply(Rhino.Geometry.Vector2d vector1, Rhino.Geometry.Vector2d vector2) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector2d Negate(Rhino.Geometry.Vector2d vector) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Equals(Rhino.Geometry.Vector2d vector) => throw new System.NotImplementedException();

  public virtual System.Boolean EpsilonEquals(Rhino.Geometry.Vector2d other, System.Double epsilon) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 CompareTo(Rhino.Geometry.Vector2d other) => throw new System.NotImplementedException();

  public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsTiny(System.Double tolerance) => throw new System.NotImplementedException();

  public virtual System.Boolean IsTiny() => throw new System.NotImplementedException();

  public virtual System.Boolean Unitize() => throw new System.NotImplementedException();

  public virtual System.Boolean Rotate(System.Double angleRadians) => throw new System.NotImplementedException();

  void System.Runtime.Serialization.ISerializable.GetObjectData(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context
  ) => throw new System.NotImplementedException();

  System.Int32 System.IComparable.CompareTo(System.Object obj) => throw new System.NotImplementedException();

  public virtual System.Double X
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Y
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Length
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.Vector2d Zero
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.Vector2d Unset
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double SquareLength
  {
    get => throw new System.NotImplementedException();
  }
}
