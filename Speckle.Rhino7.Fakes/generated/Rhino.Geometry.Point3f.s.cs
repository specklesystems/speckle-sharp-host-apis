namespace Rhino.Geometry;

public partial class Point3f
  : System.IEquatable<Rhino.Geometry.Point3f>,
    System.IComparable<Rhino.Geometry.Point3f>,
    System.IComparable,
    Rhino.IEpsilonFComparable<Rhino.Geometry.Point3f>,
    Rhino.Geometry.IValidable,
    System.IFormattable
{
  public Point3f() { }

  public Point3f(System.Single x, System.Single y, System.Single z) => throw new System.NotImplementedException();

  public virtual System.Boolean Equals(Rhino.Geometry.Point3f point) => throw new System.NotImplementedException();

  public virtual System.Boolean EpsilonEquals(Rhino.Geometry.Point3f other, System.Single epsilon) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 CompareTo(Rhino.Geometry.Point3f other) => throw new System.NotImplementedException();

  public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) =>
    throw new System.NotImplementedException();

  public virtual System.Double DistanceTo(Rhino.Geometry.Point3f other) => throw new System.NotImplementedException();

  public virtual void Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Vector3f Subtract(Rhino.Geometry.Point3f point1, Rhino.Geometry.Point3f point2) =>
    throw new System.NotImplementedException();

  System.Int32 System.IComparable.CompareTo(System.Object obj) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Point3f Origin
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.Point3f Unset
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
  public virtual System.Single Z
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
}
