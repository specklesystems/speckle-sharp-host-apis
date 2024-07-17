namespace Autodesk.Revit.DB;

public partial class FilteredElementIterator
  : System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.Element>,
    System.IDisposable,
    System.Collections.IEnumerator
{
  public FilteredElementIterator() { }

  public virtual Autodesk.Revit.DB.Element GetCurrent() => throw new System.NotImplementedException();

  public virtual System.Boolean MoveNext() => throw new System.NotImplementedException();

  public virtual System.Boolean IsDone() => throw new System.NotImplementedException();

  public virtual void Reset() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Element Current
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
