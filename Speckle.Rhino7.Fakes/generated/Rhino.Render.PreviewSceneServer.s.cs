namespace Rhino.Render;

public partial class PreviewSceneServer
{
  public PreviewSceneServer() { }

  public PreviewSceneServer(System.IntPtr pPreviewSceneServer) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual void ApplyRotation(
    System.Double X,
    System.Double Y,
    Rhino.Render.IRhRdkPreviewSceneServer_eRotationType type
  ) => throw new System.NotImplementedException();

  public virtual void SetSceneScale(System.Double scale) => throw new System.NotImplementedException();

  public virtual System.IntPtr CppPointer
  {
    get => throw new System.NotImplementedException();
  }
}
