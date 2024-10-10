namespace Rhino;

public partial class DocumentSaveEventArgs : Rhino.DocumentEventArgs
{
  public DocumentSaveEventArgs() { }

  public virtual System.String FileName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean ExportSelected
  {
    get => throw new System.NotImplementedException();
  }
}
