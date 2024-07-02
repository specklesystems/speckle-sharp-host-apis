namespace Autodesk.Revit.DB;

public partial class FilteredElementIdIterator
  : System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.ElementId>,
    System.IDisposable,
    System.Collections.IEnumerator
{
  public FilteredElementIdIterator() { }

  public virtual Autodesk.Revit.DB.ElementId GetCurrent() => throw new System.NotImplementedException();

  public virtual System.Boolean MoveNext() => throw new System.NotImplementedException();

  public virtual System.Boolean IsDone() => throw new System.NotImplementedException();

  public virtual void Reset() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId Current
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
