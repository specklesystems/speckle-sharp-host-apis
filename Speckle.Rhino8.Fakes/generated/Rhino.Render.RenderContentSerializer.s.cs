namespace Rhino.Render;

public partial class RenderContentSerializer
{
  public RenderContentSerializer() { }

  public virtual System.Boolean RegisterSerializer(System.Guid id) => throw new System.NotImplementedException();

  public virtual Rhino.Render.RenderContent Read(System.String pathToFile) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Write(
    System.String pathToFile,
    Rhino.Render.RenderContent renderContent,
    Rhino.Render.CreatePreviewEventArgs previewArgs
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean CanLoadMultiple() => throw new System.NotImplementedException();

  public virtual System.Boolean LoadMultiple(
    Rhino.RhinoDoc doc,
    System.Collections.Generic.IEnumerable<System.String> fileNames,
    Rhino.Render.RenderContentKind contentKind,
    Rhino.Render.RenderContentSerializer.LoadMultipleFlags flags
  ) => throw new System.NotImplementedException();

  public virtual void ReportContentAndFile(
    Rhino.Render.RenderContent renderContent,
    System.String pathToFile,
    System.Int32 flags
  ) => throw new System.NotImplementedException();

  public virtual void ReportDeferredContentAndFile(
    Rhino.Render.RenderContent renderContent,
    System.String pathToFile,
    System.Int32 flags
  ) => throw new System.NotImplementedException();

  public virtual System.String FileExtension
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Render.RenderContentKind ContentType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Render.RenderContentKind ContentKind
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean CanRead
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean CanWrite
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String EnglishDescription
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String LocalDescription
  {
    get => throw new System.NotImplementedException();
  }
}
