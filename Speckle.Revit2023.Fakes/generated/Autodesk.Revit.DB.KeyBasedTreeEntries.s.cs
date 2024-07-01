namespace Autodesk.Revit.DB;

public partial class KeyBasedTreeEntries
  : System.Collections.Generic.IEnumerable<Autodesk.Revit.DB.KeyBasedTreeEntry>,
    System.IDisposable
{
  public virtual Autodesk.Revit.DB.KeyBasedTreeEntry FindEntry(System.String key) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.KeyBasedTreeEntriesIterator GetKeyBasedTreeEntriesIterator() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.KeyBasedTreeEntry> GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
