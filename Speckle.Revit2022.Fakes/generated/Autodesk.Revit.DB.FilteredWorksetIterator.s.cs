namespace Autodesk.Revit.DB;

public partial class FilteredWorksetIterator
  : System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.Workset>,
    System.IDisposable,
    System.Collections.IEnumerator
{
  public FilteredWorksetIterator() { }

  public virtual Autodesk.Revit.DB.Workset GetCurrent() => throw new System.NotImplementedException();

  public virtual System.Boolean MoveNext() => throw new System.NotImplementedException();

  public virtual System.Boolean IsDone() => throw new System.NotImplementedException();

  public virtual void Reset() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Workset Current
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
