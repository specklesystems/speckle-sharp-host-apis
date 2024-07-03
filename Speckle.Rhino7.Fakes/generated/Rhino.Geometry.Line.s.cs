namespace Rhino.Geometry;

public partial class Line
  : System.IEquatable<Rhino.Geometry.Line>,
    Rhino.IEpsilonComparable<Rhino.Geometry.Line>,
    System.ICloneable,
    System.IFormattable
{
  public Line() { }

  public Line(Rhino.Geometry.Point3d from, Rhino.Geometry.Point3d to) => throw new System.NotImplementedException();

  public Line(Rhino.Geometry.Point3d start, Rhino.Geometry.Vector3d span) => throw new System.NotImplementedException();

  public Line(Rhino.Geometry.Point3d start, Rhino.Geometry.Vector3d direction, System.Double length) =>
    throw new System.NotImplementedException();

  public Line(
    System.Double x0,
    System.Double y0,
    System.Double z0,
    System.Double x1,
    System.Double y1,
    System.Double z1
  ) => throw new System.NotImplementedException();

  public static System.Boolean TryFitLineToPoints(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,
    out Rhino.Geometry.Line fitLine
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Equals(Rhino.Geometry.Line other) => throw new System.NotImplementedException();

  public virtual System.Boolean EpsilonEquals(Rhino.Geometry.Line other, System.Double epsilon) =>
    throw new System.NotImplementedException();

  public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) =>
    throw new System.NotImplementedException();

  public virtual void Flip() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d PointAt(System.Double t) => throw new System.NotImplementedException();

  public virtual System.Double ClosestParameter(Rhino.Geometry.Point3d testPoint) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d ClosestPoint(
    Rhino.Geometry.Point3d testPoint,
    System.Boolean limitToFiniteSegment
  ) => throw new System.NotImplementedException();

  public virtual System.Double DistanceTo(Rhino.Geometry.Point3d testPoint, System.Boolean limitToFiniteSegment) =>
    throw new System.NotImplementedException();

  public virtual System.Double MinimumDistanceTo(Rhino.Geometry.Point3d testPoint) =>
    throw new System.NotImplementedException();

  public virtual System.Double MinimumDistanceTo(Rhino.Geometry.Line testLine) =>
    throw new System.NotImplementedException();

  public virtual System.Double MaximumDistanceTo(Rhino.Geometry.Point3d testPoint) =>
    throw new System.NotImplementedException();

  public virtual System.Double MaximumDistanceTo(Rhino.Geometry.Line testLine) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.NurbsCurve ToNurbsCurve() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d PointAtLength(System.Double distance) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Extend(System.Double startLength, System.Double endLength) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean ExtendThroughBox(Rhino.Geometry.BoundingBox box) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean ExtendThroughBox(Rhino.Geometry.BoundingBox box, System.Double additionalLength) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean ExtendThroughBox(Rhino.Geometry.Box box) => throw new System.NotImplementedException();

  public virtual System.Boolean ExtendThroughBox(Rhino.Geometry.Box box, System.Double additionalLength) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetPlane(out Rhino.Geometry.Plane plane) =>
    throw new System.NotImplementedException();

  System.Object System.ICloneable.Clone() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d From
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double FromX
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double FromY
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double FromZ
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point3d To
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ToX
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ToY
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ToZ
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public static Rhino.Geometry.Line Unset
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Length
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Vector3d Direction
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d UnitTangent
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.BoundingBox BoundingBox
  {
    get => throw new System.NotImplementedException();
  }
}
