namespace Rhino.Display;

public partial class ViewCapture
{
  public ViewCapture() { }

  public virtual System.Drawing.Bitmap CaptureToBitmap(Rhino.Display.RhinoView sourceView) =>
    throw new System.NotImplementedException();

  public static System.Drawing.Bitmap CaptureToBitmap(Rhino.Display.ViewCaptureSettings settings) =>
    throw new System.NotImplementedException();

  public static System.Xml.XmlDocument CaptureToSvg(Rhino.Display.ViewCaptureSettings settings) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 Width
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 Height
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ScaleScreenItems
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DrawGrid
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DrawAxes
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DrawGridAxes
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean TransparentBackground
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean Preview
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 RealtimeRenderPasses
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
