namespace Rhino.Render;

public partial class RenderContentType : System.IDisposable
{
  public RenderContentType() { }

  public RenderContentType(System.Guid typeId) => throw new System.NotImplementedException();

  public static Rhino.Render.RenderContentType[] GetAllAvailableTypes() => throw new System.NotImplementedException();

  public virtual Rhino.Render.RenderContent NewRenderContent() => throw new System.NotImplementedException();

  public static Rhino.Render.RenderContent NewContentFromTypeId(System.Guid typeId) =>
    throw new System.NotImplementedException();

  public static Rhino.Render.RenderContent NewContentFromTypeId(System.Guid typeId, Rhino.RhinoDoc doc) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Guid Id
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String InternalName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Guid RenderEngineId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Guid PlugInId
  {
    get => throw new System.NotImplementedException();
  }
}
