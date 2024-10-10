namespace Rhino.Geometry;

public partial class Point2d
  : System.Runtime.Serialization.ISerializable,
    System.IEquatable<Rhino.Geometry.Point2d>,
    System.IComparable<Rhino.Geometry.Point2d>,
    System.IComparable,
    Rhino.IEpsilonComparable<Rhino.Geometry.Point2d>,
    Rhino.Geometry.IValidable,
    System.IFormattable
{
  public Point2d() { }

  public Point2d(System.Double x, System.Double y) => throw new System.NotImplementedException();

  public Point2d(Rhino.Geometry.Vector2d vector) => throw new System.NotImplementedException();

  public Point2d(Rhino.Geometry.Point2d point) => throw new System.NotImplementedException();

  public Point2d(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Point2d Multiply(Rhino.Geometry.Point2d point, System.Double t) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Point2d Multiply(System.Double t, Rhino.Geometry.Point2d point) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Point2d Divide(Rhino.Geometry.Point2d point, System.Double t) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Point2d Add(Rhino.Geometry.Point2d point, Rhino.Geometry.Vector2d vector) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Point2d Add(Rhino.Geometry.Vector2d vector, Rhino.Geometry.Point2d point) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Point2d Add(Rhino.Geometry.Point2d point1, Rhino.Geometry.Point2d point2) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Point2d Subtract(Rhino.Geometry.Point2d point, Rhino.Geometry.Vector2d vector) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector2d Subtract(Rhino.Geometry.Point2d point1, Rhino.Geometry.Point2d point2) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Equals(Rhino.Geometry.Point2d point) => throw new System.NotImplementedException();

  public virtual System.Int32 CompareTo(Rhino.Geometry.Point2d other) => throw new System.NotImplementedException();

  public virtual System.Boolean EpsilonEquals(Rhino.Geometry.Point2d other, System.Double epsilon) =>
    throw new System.NotImplementedException();

  public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) =>
    throw new System.NotImplementedException();

  public virtual System.Double DistanceTo(Rhino.Geometry.Point2d other) => throw new System.NotImplementedException();

  public virtual System.Double DistanceToSquared(Rhino.Geometry.Point2d other) =>
    throw new System.NotImplementedException();

  public virtual void Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();

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
  public virtual System.Double this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double MinimumCoordinate
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double MaximumCoordinate
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.Point2d Origin
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.Point2d Unset
  {
    get => throw new System.NotImplementedException();
  }
}
