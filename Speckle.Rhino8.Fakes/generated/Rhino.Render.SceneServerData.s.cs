namespace Rhino.Render;

public partial class SceneServerData : System.IDisposable
{
  public SceneServerData() { }

  public SceneServerData(
    Rhino.Render.PreviewGeometry geo,
    Rhino.Render.PreviewBackground back,
    Rhino.Render.PreviewLighting light,
    Rhino.Render.SceneServerDataUsage usage
  ) => throw new System.NotImplementedException();

  public SceneServerData(Rhino.Render.PreviewAppearance appearance, Rhino.Render.SceneServerDataUsage usage) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.IntPtr CppPointer
  {
    get => throw new System.NotImplementedException();
  }
}
