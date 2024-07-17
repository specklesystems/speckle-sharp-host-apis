namespace Autodesk.Revit.DB;

public partial class ExternalResourceLoadContext : System.IDisposable
{
  public ExternalResourceLoadContext() { }

  public virtual Autodesk.Revit.DB.ExternalResourceReference GetCurrentlyLoadedReference() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ModelPath GetCallingDocumentModelPath() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CallingDocumentHasModelPath() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.LoadOperationType LoadOperationType
  {
    get => throw new System.NotImplementedException();
  }
}
