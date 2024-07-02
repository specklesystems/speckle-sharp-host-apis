namespace Rhino.Render;

public partial class RenderContentEventArgs : System.EventArgs
{
  public RenderContentEventArgs() { }

  public virtual Rhino.Render.RenderContent Content
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.RhinoDoc Document
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Render.RenderContentChangeReason Reason
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Render.RenderEnvironment.Usage EnvironmentUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
