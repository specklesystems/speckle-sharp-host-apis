namespace Rhino.Render;

public partial class PreviewRenderedEventArgs : System.EventArgs
{
  public PreviewRenderedEventArgs() { }

  public virtual Rhino.Render.PreviewJobSignature PreviewJobSignature
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Bitmap Bitmap
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Render.Utilities.PreviewQuality Quality
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
