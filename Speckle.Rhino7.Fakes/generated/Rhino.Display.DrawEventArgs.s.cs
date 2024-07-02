namespace Rhino.Display;

public partial class DrawEventArgs : System.EventArgs
{
  public DrawEventArgs() { }

  public virtual Rhino.Display.RhinoViewport Viewport
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Display.DisplayPipeline Display
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.RhinoDoc RhinoDoc
  {
    get => throw new System.NotImplementedException();
  }
}
