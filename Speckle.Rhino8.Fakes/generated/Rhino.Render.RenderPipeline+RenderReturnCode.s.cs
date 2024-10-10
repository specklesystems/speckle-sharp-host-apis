namespace Rhino.Render;

public partial class RenderPipeline
{
  public enum RenderReturnCode
  {
    Ok,
    EmptyScene,
    Cancel,
    NoActiveView,
    OnPreCreateWindow,
    NoFrameWndPointer,
    ErrorCreatingWindow,
    ErrorStartingRender,
    EnterModalLoop,
    ExitModalLoop,
    ExitRhino,
    InternalError,
  }
}
