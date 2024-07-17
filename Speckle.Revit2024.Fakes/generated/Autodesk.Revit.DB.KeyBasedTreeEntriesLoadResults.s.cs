namespace Autodesk.Revit.DB;

public partial class KeyBasedTreeEntriesLoadResults : System.IDisposable
{
  public KeyBasedTreeEntriesLoadResults() { }

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FailureMessage> GetFailureMessages() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.String> GetFileSyntaxErrors() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.KeyBasedTreeEntryError> GetKeyBasedTreeEntryErrors(
    Autodesk.Revit.DB.KeyBasedTreeEntryErrorType type
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.KeyBasedTreeEntryError> GetKeyBasedTreeEntryErrors() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.String> GetFileReadErrors() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
