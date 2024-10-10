namespace Rhino.Render;

public partial class CreateTexture2dPreviewEventArgs : System.EventArgs
{
  public CreateTexture2dPreviewEventArgs() { }

  public virtual System.Drawing.Size PreviewImageSize
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Drawing.Bitmap PreviewImage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
