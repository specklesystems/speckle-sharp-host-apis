namespace Autodesk.Revit.DB;

public partial class ReferencePointArrayIterator : Autodesk.Revit.DB.APIObject, System.Collections.IEnumerator
{
  public ReferencePointArrayIterator() { }

  public virtual System.Boolean MoveNext() => throw new System.NotImplementedException();

  public virtual void Reset() => throw new System.NotImplementedException();

  public virtual System.Object Current
  {
    get => throw new System.NotImplementedException();
  }
}