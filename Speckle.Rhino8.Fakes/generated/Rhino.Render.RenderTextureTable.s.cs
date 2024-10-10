namespace Rhino.Render;

public partial class RenderTextureTable
  : Rhino.Render.IRenderContentTable<Rhino.Render.RenderTexture>,
    System.Collections.Generic.IEnumerable<Rhino.Render.RenderTexture>,
    System.Collections.IEnumerable,
    Rhino.Collections.IRhinoTable<Rhino.Render.RenderTexture>
{
  public RenderTextureTable() { }

  public virtual System.Boolean Add(Rhino.Render.RenderTexture c) => throw new System.NotImplementedException();

  public virtual System.Boolean Remove(Rhino.Render.RenderTexture c) => throw new System.NotImplementedException();

  public virtual Rhino.Render.RenderTexture Find(System.Guid id) => throw new System.NotImplementedException();

  public virtual void BeginChange(Rhino.Render.RenderContent.ChangeContexts changeContext) =>
    throw new System.NotImplementedException();

  public virtual void EndChange() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.Render.RenderTexture> GetEnumerator() =>
    throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual System.Int32 Count
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Render.RenderTexture this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
  }
}
