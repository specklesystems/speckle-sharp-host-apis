namespace Autodesk.Revit.DB;

public partial class KeyBasedTreeEntriesIterator
  : System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.KeyBasedTreeEntry>,
    System.IDisposable,
    System.Collections.IEnumerator
{
  public KeyBasedTreeEntriesIterator() { }

  public virtual System.Boolean MoveNext() => throw new System.NotImplementedException();

  public virtual System.Boolean IsDone() => throw new System.NotImplementedException();

  public virtual void Reset() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.KeyBasedTreeEntry Current
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
