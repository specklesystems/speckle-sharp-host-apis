namespace Rhino.Render;

public partial class PreviewGeometry
{
  public PreviewGeometry() { }

  public PreviewGeometry(System.IntPtr pPreviewGeometry) => throw new System.NotImplementedException();

  public virtual void SetUpPreview(
    System.IntPtr sceneServerPointer,
    System.IntPtr pRenderContent,
    System.Boolean bCopy
  ) => throw new System.NotImplementedException();

  public virtual System.String ElementKind() => throw new System.NotImplementedException();

  public virtual System.IntPtr CppPointer
  {
    get => throw new System.NotImplementedException();
  }
}
