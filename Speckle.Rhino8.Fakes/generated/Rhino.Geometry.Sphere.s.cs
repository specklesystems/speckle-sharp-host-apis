namespace Rhino.Geometry;

public partial class Sphere : Rhino.IEpsilonComparable<Rhino.Geometry.Sphere>
{
  public Sphere() { }

  public Sphere(Rhino.Geometry.Point3d center, System.Double radius) => throw new System.NotImplementedException();

  public Sphere(Rhino.Geometry.Plane equatorialPlane, System.Double radius) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Sphere FitSphereToPoints(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Circle LatitudeRadians(System.Double radians) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Circle LatitudeDegrees(System.Double degrees) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Circle LongitudeRadians(System.Double radians) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Circle LongitudeDegrees(System.Double degrees) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d PointAt(System.Double longitudeRadians, System.Double latitudeRadians) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Vector3d NormalAt(System.Double longitudeRadians, System.Double latitudeRadians) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d ClosestPoint(Rhino.Geometry.Point3d testPoint) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean ClosestParameter(
    Rhino.Geometry.Point3d testPoint,
    out System.Double longitudeRadians,
    out System.Double latitudeRadians
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Rotate(
    System.Double sinAngle,
    System.Double cosAngle,
    Rhino.Geometry.Vector3d axisOfRotation
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Rotate(System.Double angleRadians, Rhino.Geometry.Vector3d axisOfRotation) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Rotate(
    System.Double sinAngle,
    System.Double cosAngle,
    Rhino.Geometry.Vector3d axisOfRotation,
    Rhino.Geometry.Point3d centerOfRotation
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Rotate(
    System.Double angleRadians,
    Rhino.Geometry.Vector3d axisOfRotation,
    Rhino.Geometry.Point3d centerOfRotation
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Translate(Rhino.Geometry.Vector3d delta) => throw new System.NotImplementedException();

  public virtual System.Boolean Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep ToBrep() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.NurbsSurface ToNurbsSurface() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.RevSurface ToRevSurface() => throw new System.NotImplementedException();

  public virtual System.Boolean EpsilonEquals(Rhino.Geometry.Sphere other, System.Double epsilon) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Sphere Unset
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.BoundingBox BoundingBox
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Diameter
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Radius
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Plane EquitorialPlane
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Plane EquatorialPlane
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point3d Center
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point3d NorthPole
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point3d SouthPole
  {
    get => throw new System.NotImplementedException();
  }
}
