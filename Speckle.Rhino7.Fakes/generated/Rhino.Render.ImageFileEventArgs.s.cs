namespace Rhino.Render;

public partial class ImageFileEventArgs : System.EventArgs
{
  public ImageFileEventArgs() { }

  public virtual Rhino.Render.ImageFileEvent Event
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String FileName
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String RenderEngine
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Guid RenderEngineId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Guid SessionId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 EllapsedTime
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
