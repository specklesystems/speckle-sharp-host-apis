namespace Rhino.Render;

public partial class RenderPipeline : System.IDisposable
{
  public RenderPipeline() { }

  public virtual System.Boolean SaveImage(System.String fileName, System.Boolean saveAlpha) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CloseWindow() => throw new System.NotImplementedException();

  public static System.String LocalizeRenderReturnCode(Rhino.Render.RenderPipeline.RenderReturnCode rc) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Commands.Result CommandResult() => throw new System.NotImplementedException();

  public virtual Rhino.Render.RenderPipeline.RenderReturnCode Render() => throw new System.NotImplementedException();

  public virtual Rhino.Render.RenderPipeline.RenderReturnCode RenderWindow(
    Rhino.Display.RhinoView view,
    System.Drawing.Rectangle rect,
    System.Boolean inWindow
  ) => throw new System.NotImplementedException();

  public static System.Drawing.Size RenderSize() => throw new System.NotImplementedException();

  public static System.Drawing.Size RenderSize(Rhino.RhinoDoc doc) => throw new System.NotImplementedException();

  public static System.Drawing.Size RenderSize(Rhino.RhinoDoc doc, System.Boolean fromRenderSources) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Render.RenderWindow GetRenderWindow(System.Boolean withWireframeChannel) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Render.RenderWindow GetRenderWindow(
    System.Boolean withWireframeChannel,
    System.Boolean fromRenderViewSource
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Render.RenderWindow GetRenderWindow(
    Rhino.DocObjects.ViewportInfo viewportInfo,
    System.Boolean fromRenderViewSource
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Render.RenderWindow GetRenderWindow() => throw new System.NotImplementedException();

  public virtual Rhino.Render.RenderWindow GetRenderWindowFromRenderViewSource(System.Boolean fromRenderViewSource) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SupportsPause() => throw new System.NotImplementedException();

  public virtual void PauseRendering() => throw new System.NotImplementedException();

  public virtual void ResumeRendering() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Guid RenderSessionId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 ConfirmationSeconds
  {
    set { }
  }
}
