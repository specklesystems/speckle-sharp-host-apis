namespace Rhino.Geometry;

public partial class Vector3d
  : System.Runtime.Serialization.ISerializable,
    System.IEquatable<Rhino.Geometry.Vector3d>,
    System.IComparable<Rhino.Geometry.Vector3d>,
    System.IComparable,
    Rhino.IEpsilonComparable<Rhino.Geometry.Vector3d>,
    System.ICloneable,
    Rhino.Geometry.IValidable,
    System.IFormattable
{
  public Vector3d() { }

  public Vector3d(System.Double x, System.Double y, System.Double z) => throw new System.NotImplementedException();

  public Vector3d(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();

  public Vector3d(Rhino.Geometry.Vector3f vector) => throw new System.NotImplementedException();

  public Vector3d(Rhino.Geometry.Vector3d vector) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector3d Multiply(Rhino.Geometry.Vector3d vector, System.Double t) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector3d Multiply(System.Double t, Rhino.Geometry.Vector3d vector) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector3d Divide(Rhino.Geometry.Vector3d vector, System.Double t) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector3d Add(Rhino.Geometry.Vector3d vector1, Rhino.Geometry.Vector3d vector2) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector3d Subtract(Rhino.Geometry.Vector3d vector1, Rhino.Geometry.Vector3d vector2) =>
    throw new System.NotImplementedException();

  public static System.Double Multiply(Rhino.Geometry.Vector3d vector1, Rhino.Geometry.Vector3d vector2) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector3d Negate(Rhino.Geometry.Vector3d vector) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector3d CrossProduct(Rhino.Geometry.Vector3d a, Rhino.Geometry.Vector3d b) =>
    throw new System.NotImplementedException();

  public static System.Double VectorAngle(Rhino.Geometry.Vector3d a, Rhino.Geometry.Vector3d b) =>
    throw new System.NotImplementedException();

  public static System.Double VectorAngle(
    Rhino.Geometry.Vector3d a,
    Rhino.Geometry.Vector3d b,
    Rhino.Geometry.Plane plane
  ) => throw new System.NotImplementedException();

  public static System.Double VectorAngle(
    Rhino.Geometry.Vector3d v1,
    Rhino.Geometry.Vector3d v2,
    Rhino.Geometry.Vector3d vNormal
  ) => throw new System.NotImplementedException();

  public static System.Boolean AreOrthogonal(
    Rhino.Geometry.Vector3d x,
    Rhino.Geometry.Vector3d y,
    Rhino.Geometry.Vector3d z
  ) => throw new System.NotImplementedException();

  public static System.Boolean AreOrthonormal(
    Rhino.Geometry.Vector3d x,
    Rhino.Geometry.Vector3d y,
    Rhino.Geometry.Vector3d z
  ) => throw new System.NotImplementedException();

  public static System.Boolean AreRighthanded(
    Rhino.Geometry.Vector3d x,
    Rhino.Geometry.Vector3d y,
    Rhino.Geometry.Vector3d z
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsTiny(System.Double tolerance) => throw new System.NotImplementedException();

  public virtual System.Boolean IsTiny() => throw new System.NotImplementedException();

  public virtual System.Boolean Equals(Rhino.Geometry.Vector3d vector) => throw new System.NotImplementedException();

  public virtual System.Boolean EpsilonEquals(Rhino.Geometry.Vector3d other, System.Double epsilon) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 CompareTo(Rhino.Geometry.Vector3d other) => throw new System.NotImplementedException();

  public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Unitize() => throw new System.NotImplementedException();

  public virtual void Transform(Rhino.Geometry.Transform transformation) => throw new System.NotImplementedException();

  public virtual System.Boolean Rotate(System.Double angleRadians, Rhino.Geometry.Vector3d rotationAxis) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Reverse() => throw new System.NotImplementedException();

  public virtual System.Int32 IsParallelTo(Rhino.Geometry.Vector3d other) => throw new System.NotImplementedException();

  public virtual System.Int32 IsParallelTo(Rhino.Geometry.Vector3d other, System.Double angleTolerance) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsPerpendicularTo(Rhino.Geometry.Vector3d other) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsPerpendicularTo(Rhino.Geometry.Vector3d other, System.Double angleTolerance) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean PerpendicularTo(Rhino.Geometry.Vector3d other) =>
    throw new System.NotImplementedException();

  void System.Runtime.Serialization.ISerializable.GetObjectData(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context
  ) => throw new System.NotImplementedException();

  System.Int32 System.IComparable.CompareTo(System.Object obj) => throw new System.NotImplementedException();

  System.Object System.ICloneable.Clone() => throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector3d Zero
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.Vector3d XAxis
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.Vector3d YAxis
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.Vector3d ZAxis
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.Vector3d Unset
  {
    get => throw new System.NotImplementedException();
  }
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
  public virtual System.Double Z
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
  public virtual System.Double Length
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double SquareLength
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsUnitVector
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsZero
  {
    get => throw new System.NotImplementedException();
  }
}
