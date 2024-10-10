namespace Rhino.Display;

public partial class DisplayPipelineAttributes
{
  public enum ContextsForDraw
  {
    Unset,
    FilePreview,
    ViewCapture,
    Printing,
    UIPreview,
    Mask,
    RenderOverlays,
  }
}
