namespace Rhino.Display;

public partial class DisplayPoint
{
  public DisplayPoint() { }

  public DisplayPoint(Rhino.Geometry.Point3d location) => throw new System.NotImplementedException();

  public virtual Rhino.Display.DisplayPoint WithAttributes(Rhino.Display.DisplayPointAttributes attributes) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d Location
  {
    get => throw new System.NotImplementedException();
  }
}
