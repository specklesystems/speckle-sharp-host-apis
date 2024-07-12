namespace Autodesk.Revit.DB;

public partial class ExportLinetypeTableIterator
  : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<
    Autodesk.Revit.DB.ExportLinetypeKey,
    Autodesk.Revit.DB.ExportLinetypeInfo
  >>,
    System.IDisposable,
    System.Collections.IEnumerator
{
  public ExportLinetypeTableIterator() { }

  public virtual System.Boolean MoveNext() => throw new System.NotImplementedException();

  public virtual System.Boolean IsDone() => throw new System.NotImplementedException();

  public virtual void Reset() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.KeyValuePair<
    Autodesk.Revit.DB.ExportLinetypeKey,
    Autodesk.Revit.DB.ExportLinetypeInfo
  > Current
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
