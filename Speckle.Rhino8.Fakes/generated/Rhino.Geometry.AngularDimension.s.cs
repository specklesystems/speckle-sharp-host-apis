namespace Rhino.Geometry;

public partial class AngularDimension : Rhino.Geometry.Dimension
{
  public AngularDimension() { }

  public AngularDimension(Rhino.Geometry.Arc arc, System.Double offset) => throw new System.NotImplementedException();

  public AngularDimension(
    Rhino.Geometry.Plane plane,
    Rhino.Geometry.Vector3d horizontal,
    Rhino.Geometry.Point3d centerpoint,
    Rhino.Geometry.Point3d defpoint1,
    Rhino.Geometry.Point3d defpoint2,
    Rhino.Geometry.Point3d dimlinepoint
  ) => throw new System.NotImplementedException();

  public AngularDimension(
    Rhino.Geometry.Plane plane,
    Rhino.Geometry.Vector3d horizontal,
    Rhino.Geometry.Point3d extpoint1,
    Rhino.Geometry.Point3d extpoint2,
    Rhino.Geometry.Point3d dirpoint1,
    Rhino.Geometry.Point3d dirpoint2,
    Rhino.Geometry.Point3d dimlinepoint
  ) => throw new System.NotImplementedException();

  public AngularDimension(
    Rhino.Geometry.Line line1,
    Rhino.Geometry.Point3d pointOnLine1,
    Rhino.Geometry.Line line2,
    Rhino.Geometry.Point3d pointOnLine2,
    Rhino.Geometry.Point3d pointOnAngularDimensionArc,
    System.Boolean bSetExtensionPoints
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.AngularDimension Create(
    Rhino.DocObjects.DimensionStyle dimStyle,
    Rhino.Geometry.Plane plane,
    Rhino.Geometry.Vector3d horizontal,
    Rhino.Geometry.Point3d centerpoint,
    Rhino.Geometry.Point3d defpoint1,
    Rhino.Geometry.Point3d defpoint2,
    Rhino.Geometry.Point3d dimlinepoint
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean AdjustFromPoints(
    Rhino.Geometry.Plane plane,
    Rhino.Geometry.Point3d centerpoint,
    Rhino.Geometry.Point3d defpoint1,
    Rhino.Geometry.Point3d defpoint2,
    Rhino.Geometry.Point3d dimlinepoint
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.AngularDimension Create(
    System.Guid styleId,
    Rhino.Geometry.Plane plane,
    Rhino.Geometry.Point3d extpoint1,
    Rhino.Geometry.Point3d extpoint2,
    Rhino.Geometry.Point3d dirpoint1,
    Rhino.Geometry.Point3d dirpoint2,
    Rhino.Geometry.Point3d dimlinepoint
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.AngularDimension Create(
    Rhino.DocObjects.DimensionStyle dimStyle,
    Rhino.Geometry.Plane plane,
    Rhino.Geometry.Vector3d horizontal,
    Rhino.Geometry.Point3d extpoint1,
    Rhino.Geometry.Point3d extpoint2,
    Rhino.Geometry.Point3d dirpoint1,
    Rhino.Geometry.Point3d dirpoint2,
    Rhino.Geometry.Point3d dimlinepoint
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean AdjustFromPoints(
    Rhino.Geometry.Plane plane,
    Rhino.Geometry.Point3d extpoint1,
    Rhino.Geometry.Point3d extpoint2,
    Rhino.Geometry.Point3d dirpoint1,
    Rhino.Geometry.Point3d dirpoint2,
    Rhino.Geometry.Point3d dimlinepoint
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.AngularDimension Create(
    Rhino.DocObjects.DimensionStyle dimStyle,
    Rhino.Geometry.Line line1,
    Rhino.Geometry.Point3d pointOnLine1,
    Rhino.Geometry.Line line2,
    Rhino.Geometry.Point3d pointOnLine2,
    Rhino.Geometry.Point3d pointOnAngularDimensionArc,
    System.Boolean bSetExtensionPoints
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Get3dPoints(
    out Rhino.Geometry.Point3d centerpoint,
    out Rhino.Geometry.Point3d defpoint1,
    out Rhino.Geometry.Point3d defpoint2,
    out Rhino.Geometry.Point3d arrowpoint1,
    out Rhino.Geometry.Point3d arrowpoint2,
    out Rhino.Geometry.Point3d dimlinepoint,
    out Rhino.Geometry.Point3d textpoint
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean GetTextRectangle(out Rhino.Geometry.Point3d[] corners) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetDisplayLines(
    Rhino.DocObjects.DimensionStyle style,
    System.Double scale,
    out Rhino.Geometry.Line[] lines,
    out Rhino.Geometry.Arc[] arcs
  ) => throw new System.NotImplementedException();

  public virtual System.String GetAngleDisplayText(Rhino.DocObjects.DimensionStyle style) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point2d CenterPoint
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point2d DefPoint1
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point2d DefPoint2
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point2d DimlinePoint
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point2d ArrowPoint1
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point2d ArrowPoint2
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.DimensionStyle.AngleDisplayFormat AngleFormat
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 AngleResolution
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double AngleRoundoff
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.ZeroSuppression AngleZeroSuppression
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
