namespace Autodesk.Revit.DB;

public partial class KeyBasedTreeEntryError : System.IDisposable
{
  public KeyBasedTreeEntryError() { }

  public virtual Autodesk.Revit.DB.KeyBasedTreeEntry GetEntry() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.KeyBasedTreeEntryErrorType ErrorType
  {
    get => throw new System.NotImplementedException();
  }
}
