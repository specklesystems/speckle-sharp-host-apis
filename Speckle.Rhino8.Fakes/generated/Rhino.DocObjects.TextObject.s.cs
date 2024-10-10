namespace Rhino.DocObjects;

public partial class TextObject : Rhino.DocObjects.AnnotationObjectBase
{
  public TextObject() { }

  public virtual Rhino.Geometry.Point3d[] GetTextCorners(Rhino.Display.RhinoViewport viewport) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.TextEntity TextGeometry
  {
    get => throw new System.NotImplementedException();
  }
}
