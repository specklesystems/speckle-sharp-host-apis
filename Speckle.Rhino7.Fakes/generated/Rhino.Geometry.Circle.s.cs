namespace Rhino.Geometry;

public partial class Circle : Rhino.IEpsilonComparable<Rhino.Geometry.Circle>, System.ICloneable
{
  public Circle() { }

  public Circle(System.Double radius) => throw new System.NotImplementedException();

  public Circle(Rhino.Geometry.Plane plane, System.Double radius) => throw new System.NotImplementedException();

  public Circle(Rhino.Geometry.Point3d center, System.Double radius) => throw new System.NotImplementedException();

  public Circle(Rhino.Geometry.Arc arc) => throw new System.NotImplementedException();

  public Circle(Rhino.Geometry.Point3d point1, Rhino.Geometry.Point3d point2, Rhino.Geometry.Point3d point3) =>
    throw new System.NotImplementedException();

  public Circle(Rhino.Geometry.Plane plane, Rhino.Geometry.Point3d center, System.Double radius) =>
    throw new System.NotImplementedException();

  public Circle(
    Rhino.Geometry.Point3d startPoint,
    Rhino.Geometry.Vector3d tangentAtP,
    Rhino.Geometry.Point3d pointOnCircle
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Circle TryFitCircleTT(
    Rhino.Geometry.Curve c1,
    Rhino.Geometry.Curve c2,
    System.Double t1,
    System.Double t2
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Circle TryFitCircleTTT(
    Rhino.Geometry.Curve c1,
    Rhino.Geometry.Curve c2,
    Rhino.Geometry.Curve c3,
    System.Double t1,
    System.Double t2,
    System.Double t3
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsInPlane(Rhino.Geometry.Plane plane, System.Double tolerance) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d PointAt(System.Double t) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Vector3d TangentAt(System.Double t) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Vector3d DerivativeAt(System.Int32 derivative, System.Double t) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean ClosestParameter(Rhino.Geometry.Point3d testPoint, out System.Double t) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d ClosestPoint(Rhino.Geometry.Point3d testPoint) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();

  public virtual System.Boolean Rotate(System.Double sinAngle, System.Double cosAngle, Rhino.Geometry.Vector3d axis) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Rotate(
    System.Double sinAngle,
    System.Double cosAngle,
    Rhino.Geometry.Vector3d axis,
    Rhino.Geometry.Point3d point
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Rotate(System.Double angle, Rhino.Geometry.Vector3d axis) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Rotate(
    System.Double angle,
    Rhino.Geometry.Vector3d axis,
    Rhino.Geometry.Point3d point
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Translate(Rhino.Geometry.Vector3d delta) => throw new System.NotImplementedException();

  public virtual void Reverse() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.NurbsCurve ToNurbsCurve() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.NurbsCurve ToNurbsCurve(System.Int32 degree, System.Int32 cvCount) =>
    throw new System.NotImplementedException();

  public static System.Boolean TryFitCircleToPoints(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,
    out Rhino.Geometry.Circle circle
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean EpsilonEquals(Rhino.Geometry.Circle other, System.Double epsilon) =>
    throw new System.NotImplementedException();

  System.Object System.ICloneable.Clone() => throw new System.NotImplementedException();

  public static Rhino.Geometry.Circle Unset
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Radius
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Diameter
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Plane Plane
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point3d Center
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Vector3d Normal
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Circumference
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.BoundingBox BoundingBox
  {
    get => throw new System.NotImplementedException();
  }
}
