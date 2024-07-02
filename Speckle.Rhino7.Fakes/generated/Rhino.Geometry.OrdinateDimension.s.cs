namespace Rhino.Geometry;

public partial class OrdinateDimension : Rhino.Geometry.Dimension
{
  public OrdinateDimension() { }

  public static Rhino.Geometry.OrdinateDimension Create(
    Rhino.DocObjects.DimensionStyle dimStyle,
    Rhino.Geometry.Plane plane,
    Rhino.Geometry.OrdinateDimension.MeasuredDirection direction,
    Rhino.Geometry.Point3d basepoint,
    Rhino.Geometry.Point3d defpoint,
    Rhino.Geometry.Point3d leaderpoint,
    System.Double kinkoffset1,
    System.Double kinkoffset2
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean AdjustFromPoints(
    Rhino.Geometry.Plane plane,
    Rhino.Geometry.OrdinateDimension.MeasuredDirection direction,
    Rhino.Geometry.Point3d basepoint,
    Rhino.Geometry.Point3d defpoint,
    Rhino.Geometry.Point3d leaderpoint,
    System.Double kinkoffset1,
    System.Double kinkoffset2
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Get3dPoints(
    out Rhino.Geometry.Point3d basepoint,
    out Rhino.Geometry.Point3d defpoint,
    out Rhino.Geometry.Point3d leaderpoint,
    out Rhino.Geometry.Point3d kinkpoint1,
    out Rhino.Geometry.Point3d kinkpoint2
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean GetTextRectangle(out Rhino.Geometry.Point3d[] corners) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetDisplayLines(
    Rhino.DocObjects.DimensionStyle style,
    System.Double scale,
    out System.Collections.Generic.IEnumerable<Rhino.Geometry.Line> lines
  ) => throw new System.NotImplementedException();

  public virtual System.String GetDistanceDisplayText(
    Rhino.UnitSystem unitsystem,
    Rhino.DocObjects.DimensionStyle style
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point2d DefPoint
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point2d LeaderPoint
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point2d KinkPoint1
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point2d KinkPoint2
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double KinkOffset1
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double KinkOffset2
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
