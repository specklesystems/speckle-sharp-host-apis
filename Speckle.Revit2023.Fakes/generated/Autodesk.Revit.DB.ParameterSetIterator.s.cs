namespace Autodesk.Revit.DB;

public partial class ParameterSetIterator : Autodesk.Revit.DB.APIObject, System.Collections.IEnumerator
{
  public ParameterSetIterator() { }

  public virtual System.Boolean MoveNext() => throw new System.NotImplementedException();

  public virtual void Reset() => throw new System.NotImplementedException();

  public virtual System.Object Current
  {
    get => throw new System.NotImplementedException();
  }
}
