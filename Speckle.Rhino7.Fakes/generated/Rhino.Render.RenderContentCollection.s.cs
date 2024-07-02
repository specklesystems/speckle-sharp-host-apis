namespace Rhino.Render;

public partial class RenderContentCollection : System.IDisposable, System.Collections.IEnumerable
{
  public RenderContentCollection() { }

  public RenderContentCollection(System.IntPtr nativePtr) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual Rhino.Render.FilterContentByUsage GetFilterContentByUsage() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetForcedVaries() => throw new System.NotImplementedException();

  public virtual void SetForcedVaries(System.Boolean b) => throw new System.NotImplementedException();

  public virtual void SetSearchPattern(System.String pattern) => throw new System.NotImplementedException();

  public virtual System.String GetSearchPattern() => throw new System.NotImplementedException();

  public virtual System.String FirstTag() => throw new System.NotImplementedException();

  public virtual System.String NextTag() => throw new System.NotImplementedException();

  public virtual System.Boolean ContentNeedsPreviewThumbnail(
    Rhino.Render.RenderContent c,
    System.Boolean includeChildren
  ) => throw new System.NotImplementedException();

  public virtual void Remove(Rhino.Render.RenderContentCollection collection) =>
    throw new System.NotImplementedException();

  public virtual void Add(Rhino.Render.RenderContentCollection collection) =>
    throw new System.NotImplementedException();

  public virtual void Set(Rhino.Render.RenderContentCollection collection) =>
    throw new System.NotImplementedException();

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual void Append(Rhino.Render.RenderContent content) => throw new System.NotImplementedException();

  public virtual System.Int32 Count() => throw new System.NotImplementedException();

  public virtual Rhino.Render.ContentCollectionIterator Iterator() => throw new System.NotImplementedException();

  public virtual Rhino.Render.RenderContent Find_Sel(System.Guid uuid) => throw new System.NotImplementedException();

  public virtual Rhino.Render.RenderContent ContentAt(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Collections.IEnumerator GetEnumerator() => throw new System.NotImplementedException();

  public virtual System.IntPtr CppPointer
  {
    get => throw new System.NotImplementedException();
  }
}
