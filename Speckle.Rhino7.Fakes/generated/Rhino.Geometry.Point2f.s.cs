namespace Rhino.Geometry;

public partial class Point2f
  : System.IEquatable<Rhino.Geometry.Point2f>,
    System.IComparable<Rhino.Geometry.Point2f>,
    System.IComparable,
    Rhino.IEpsilonFComparable<Rhino.Geometry.Point2f>,
    Rhino.Geometry.IValidable,
    System.IFormattable
{
  public Point2f() { }

  public Point2f(System.Single x, System.Single y) => throw new System.NotImplementedException();

  public Point2f(System.Double x, System.Double y) => throw new System.NotImplementedException();

  public virtual System.Boolean Equals(Rhino.Geometry.Point2f point) => throw new System.NotImplementedException();

  public virtual System.Boolean EpsilonEquals(Rhino.Geometry.Point2f other, System.Single epsilon) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 CompareTo(Rhino.Geometry.Point2f other) => throw new System.NotImplementedException();

  public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) =>
    throw new System.NotImplementedException();

  System.Int32 System.IComparable.CompareTo(System.Object obj) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Point2f Unset
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValid
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
  public virtual System.Single this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
