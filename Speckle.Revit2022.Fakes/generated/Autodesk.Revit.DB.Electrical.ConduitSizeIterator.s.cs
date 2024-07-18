namespace Autodesk.Revit.DB.Electrical;

public partial class ConduitSizeIterator
  : System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.Electrical.ConduitSize>,
    System.IDisposable,
    System.Collections.IEnumerator
{
  public ConduitSizeIterator() { }

  public virtual System.Boolean MoveNext() => throw new System.NotImplementedException();

  public virtual System.Boolean IsDone() => throw new System.NotImplementedException();

  public virtual void Reset() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Electrical.ConduitSize GetCurrent() => throw new System.NotImplementedException();

  public virtual System.Boolean HasCurrent() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Electrical.ConduitSize Current
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
