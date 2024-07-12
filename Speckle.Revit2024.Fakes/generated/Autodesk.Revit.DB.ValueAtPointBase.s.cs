namespace Autodesk.Revit.DB;

public partial class ValueAtPointBase : System.IDisposable
{
  public ValueAtPointBase() { }

  public virtual void SetFlags(System.Int32 flags, System.Int32 measurement) =>
    throw new System.NotImplementedException();

  public virtual void SetFlags(System.Int32 flags) => throw new System.NotImplementedException();

  public virtual void SetFlags(System.Collections.Generic.IList<System.Int32> flags) =>
    throw new System.NotImplementedException();

  public virtual void ClearAllFlags() => throw new System.NotImplementedException();

  public virtual void ClearFlagsAt(System.Int32 measurement) => throw new System.NotImplementedException();

  public virtual System.Int32 GetFlags(System.Int32 measurement) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
