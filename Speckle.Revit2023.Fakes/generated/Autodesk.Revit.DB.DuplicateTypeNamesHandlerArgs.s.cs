namespace Autodesk.Revit.DB;

public partial class DuplicateTypeNamesHandlerArgs : System.IDisposable
{
  public DuplicateTypeNamesHandlerArgs() { }

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetTypeIds() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Document Document
  {
    get => throw new System.NotImplementedException();
  }
}
