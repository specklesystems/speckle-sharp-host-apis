namespace Rhino.Geometry;

public partial class HiddenLineDrawingPoint
{
  public HiddenLineDrawingPoint() { }

  public virtual Rhino.Geometry.HiddenLineDrawingObject SourceObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.ComponentIndex SourceObjectComponentIndex
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 ClippingPlaneIndex
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point3d Location
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Index
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.HiddenLineDrawingPoint.Visibility PointVisibility
  {
    get => throw new System.NotImplementedException();
  }
}
