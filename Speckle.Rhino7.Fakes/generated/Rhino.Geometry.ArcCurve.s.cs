namespace Rhino.Geometry;

public partial class ArcCurve : Rhino.Geometry.Curve
{
  public ArcCurve() { }

  public ArcCurve(Rhino.Geometry.ArcCurve other) => throw new System.NotImplementedException();

  public ArcCurve(Rhino.Geometry.Arc arc) => throw new System.NotImplementedException();

  public ArcCurve(Rhino.Geometry.Arc arc, System.Double t0, System.Double t1) =>
    throw new System.NotImplementedException();

  public ArcCurve(Rhino.Geometry.Circle circle) => throw new System.NotImplementedException();

  public ArcCurve(Rhino.Geometry.Circle circle, System.Double t0, System.Double t1) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Arc Arc
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsCompleteCircle
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Radius
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double AngleRadians
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double AngleDegrees
  {
    get => throw new System.NotImplementedException();
  }
}
