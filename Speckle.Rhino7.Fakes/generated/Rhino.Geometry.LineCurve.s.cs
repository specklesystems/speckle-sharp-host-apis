namespace Rhino.Geometry;

public partial class LineCurve : Rhino.Geometry.Curve
{
  public LineCurve() { }

  public LineCurve(Rhino.Geometry.LineCurve other) => throw new System.NotImplementedException();

  public LineCurve(Rhino.Geometry.Point2d from, Rhino.Geometry.Point2d to) =>
    throw new System.NotImplementedException();

  public LineCurve(Rhino.Geometry.Point3d from, Rhino.Geometry.Point3d to) =>
    throw new System.NotImplementedException();

  public LineCurve(Rhino.Geometry.Line line) => throw new System.NotImplementedException();

  public LineCurve(Rhino.Geometry.Line line, System.Double t0, System.Double t1) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Line Line
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
