namespace Rhino.Geometry;

public partial class LinearDimension : Rhino.Geometry.Dimension
{
  public LinearDimension() { }

  public LinearDimension(
    Rhino.Geometry.Plane dimensionPlane,
    Rhino.Geometry.Point2d extensionLine1End,
    Rhino.Geometry.Point2d extensionLine2End,
    Rhino.Geometry.Point2d pointOnDimensionLine
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.LinearDimension FromPoints(
    Rhino.Geometry.Point3d extensionLine1End,
    Rhino.Geometry.Point3d extensionLine2End,
    Rhino.Geometry.Point3d pointOnDimensionLine
  ) => throw new System.NotImplementedException();

  public virtual void SetLocations(
    Rhino.Geometry.Point2d extensionLine1End,
    Rhino.Geometry.Point2d extensionLine2End,
    Rhino.Geometry.Point2d pointOnDimensionLine
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.LinearDimension Create(
    Rhino.Geometry.AnnotationType dimtype,
    Rhino.DocObjects.DimensionStyle dimStyle,
    Rhino.Geometry.Plane plane,
    Rhino.Geometry.Vector3d horizontal,
    Rhino.Geometry.Point3d defpoint1,
    Rhino.Geometry.Point3d defpoint2,
    Rhino.Geometry.Point3d dimlinepoint,
    System.Double rotationInPlane
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Get3dPoints(
    out Rhino.Geometry.Point3d extensionLine1End,
    out Rhino.Geometry.Point3d extensionLine2End,
    out Rhino.Geometry.Point3d arrowhead1End,
    out Rhino.Geometry.Point3d arrowhead2End,
    out Rhino.Geometry.Point3d dimlinepoint,
    out Rhino.Geometry.Point3d textpoint
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

  public virtual System.Double DistanceBetweenArrowTips
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Aligned
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point2d ExtensionLine1End
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point2d ExtensionLine2End
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point2d Arrowhead1End
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point2d Arrowhead2End
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point2d DimensionLinePoint
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
