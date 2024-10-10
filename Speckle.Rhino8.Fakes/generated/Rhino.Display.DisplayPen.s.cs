namespace Rhino.Display;

public partial class DisplayPen
{
  public DisplayPen() { }

  public virtual Rhino.Display.DisplayPen Duplicate() => throw new System.NotImplementedException();

  public static Rhino.Display.DisplayPen FromLinetype(
    Rhino.DocObjects.Linetype linetype,
    System.Drawing.Color color,
    System.Double patternScale
  ) => throw new System.NotImplementedException();

  public virtual void SetPattern(System.Collections.Generic.IEnumerable<System.Single> dashesAndGaps) =>
    throw new System.NotImplementedException();

  public virtual System.Single[] PatternAsArray() => throw new System.NotImplementedException();

  public virtual void SetTaper(
    System.Single startThickness,
    System.Single endThickness,
    Rhino.Geometry.Point2f taperPoint
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point2f[] TaperAsArray() => throw new System.NotImplementedException();

  public virtual System.Drawing.Color Color
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single Thickness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.CoordinateSystem ThicknessSpace
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.LineCapStyle CapStyle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.LineJoinStyle JoinStyle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single HaloThickness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color HaloColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single PatternOffset
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean PatternBySegment
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean PatternLengthInWorldUnits
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
