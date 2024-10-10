namespace Rhino.Geometry;

public partial class HiddenLineDrawingObject
{
  public HiddenLineDrawingObject() { }

  public virtual System.Boolean OccludingSections
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.GeometryBase Geometry
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Transform Transform
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Object Tag
  {
    get => throw new System.NotImplementedException();
  }
}
