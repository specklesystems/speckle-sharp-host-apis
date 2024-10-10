namespace Rhino.Render;

public partial class RenderChannels : Rhino.Render.DocumentOrFreeFloatingBase, System.IDisposable
{
  public RenderChannels() { }

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual Rhino.Render.RenderChannels.Modes Mode
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Guid[] CustomList
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
