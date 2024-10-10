namespace Rhino.Display;

public partial class DrawObjectEventArgs : Rhino.Display.DrawEventArgs
{
  public DrawObjectEventArgs() { }

  public virtual Rhino.DocObjects.RhinoObject RhinoObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean DrawObject
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
