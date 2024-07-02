namespace Rhino.Display;

public partial class InitFrameBufferEventArgs : System.EventArgs
{
  public InitFrameBufferEventArgs() { }

  public virtual void SetFill(System.Drawing.Color color) => throw new System.NotImplementedException();

  public virtual void SetFill(System.Drawing.Color top, System.Drawing.Color bottom) =>
    throw new System.NotImplementedException();

  public virtual void SetFill(
    System.Drawing.Color topLeft,
    System.Drawing.Color bottomLeft,
    System.Drawing.Color topRight,
    System.Drawing.Color bottomRight
  ) => throw new System.NotImplementedException();
}
