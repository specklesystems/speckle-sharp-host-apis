namespace Rhino.Display;

public partial class Text3d : System.IDisposable
{
  public Text3d() { }

  public Text3d(System.String text) => throw new System.NotImplementedException();

  public Text3d(System.String text, Rhino.Geometry.Plane plane, System.Double height) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.String Text
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Plane TextPlane
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Height
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String FontFace
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean Bold
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean Italic
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.BoundingBox BoundingBox
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.TextHorizontalAlignment HorizontalAlignment
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.TextVerticalAlignment VerticalAlignment
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
