namespace Rhino.Geometry;

public partial class RevSurface : Rhino.Geometry.Surface
{
  public RevSurface() { }

  public static Rhino.Geometry.RevSurface Create(
    Rhino.Geometry.Curve revoluteCurve,
    Rhino.Geometry.Line axisOfRevolution,
    System.Double startAngleRadians,
    System.Double endAngleRadians
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.RevSurface Create(
    Rhino.Geometry.Curve revoluteCurve,
    Rhino.Geometry.Line axisOfRevolution
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.RevSurface Create(
    Rhino.Geometry.Line revoluteLine,
    Rhino.Geometry.Line axisOfRevolution,
    System.Double startAngleRadians,
    System.Double endAngleRadians
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.RevSurface Create(
    Rhino.Geometry.Line revoluteLine,
    Rhino.Geometry.Line axisOfRevolution
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.RevSurface Create(
    Rhino.Geometry.Polyline revolutePolyline,
    Rhino.Geometry.Line axisOfRevolution,
    System.Double startAngleRadians,
    System.Double endAngleRadians
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.RevSurface Create(
    Rhino.Geometry.Polyline revolutePolyline,
    Rhino.Geometry.Line axisOfRevolution
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.RevSurface CreateFromCone(Rhino.Geometry.Cone cone) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.RevSurface CreateFromCylinder(Rhino.Geometry.Cylinder cylinder) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.RevSurface CreateFromSphere(Rhino.Geometry.Sphere sphere) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.RevSurface CreateFromTorus(Rhino.Geometry.Torus torus) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Curve Curve
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Line Axis
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Interval Angle
  {
    get => throw new System.NotImplementedException();
  }
}
