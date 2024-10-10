namespace Rhino.Geometry;

public partial class Rectangle3d : Rhino.IEpsilonComparable<Rhino.Geometry.Rectangle3d>, System.ICloneable
{
  public Rectangle3d() { }

  public Rectangle3d(Rhino.Geometry.Plane plane, System.Double width, System.Double height) =>
    throw new System.NotImplementedException();

  public Rectangle3d(Rhino.Geometry.Plane plane, Rhino.Geometry.Interval width, Rhino.Geometry.Interval height) =>
    throw new System.NotImplementedException();

  public Rectangle3d(Rhino.Geometry.Plane plane, Rhino.Geometry.Point3d cornerA, Rhino.Geometry.Point3d cornerB) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Rectangle3d CreateFromPolyline(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> polyline
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Rectangle3d CreateFromPolyline(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> polyline,
    out System.Double deviation,
    out System.Double angleDeviation
  ) => throw new System.NotImplementedException();

  public virtual void MakeIncreasing() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d Corner(System.Int32 index) => throw new System.NotImplementedException();

  public virtual void RecenterPlane(System.Int32 index) => throw new System.NotImplementedException();

  public virtual void RecenterPlane(Rhino.Geometry.Point3d origin) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d PointAt(System.Double x, System.Double y) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d PointAt(System.Double t) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d ClosestPoint(Rhino.Geometry.Point3d point) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d ClosestPoint(Rhino.Geometry.Point3d point, System.Boolean includeInterior) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.PointContainment Contains(Rhino.Geometry.Point3d pt) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.PointContainment Contains(System.Double x, System.Double y) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Polyline ToPolyline() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.NurbsCurve ToNurbsCurve() => throw new System.NotImplementedException();

  public virtual System.Boolean EpsilonEquals(Rhino.Geometry.Rectangle3d other, System.Double epsilon) =>
    throw new System.NotImplementedException();

  System.Object System.ICloneable.Clone() => throw new System.NotImplementedException();

  public static Rhino.Geometry.Rectangle3d Unset
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Plane Plane
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Interval X
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Interval Y
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Width
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Height
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Area
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Circumference
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.BoundingBox BoundingBox
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point3d Center
  {
    get => throw new System.NotImplementedException();
  }
}
