namespace Autodesk.Revit.DB;

public partial class GroupSet : Autodesk.Revit.DB.APIObject, System.Collections.IEnumerable
{
  public GroupSet() { }

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.GroupSetIterator ForwardIterator() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.GroupSetIterator ReverseIterator() => throw new System.NotImplementedException();

  public virtual System.Collections.IEnumerator GetEnumerator() => throw new System.NotImplementedException();

  public virtual System.Boolean Contains(Autodesk.Revit.DB.Group item) => throw new System.NotImplementedException();

  public virtual System.Boolean Insert(Autodesk.Revit.DB.Group item) => throw new System.NotImplementedException();

  public virtual System.Int32 Erase(Autodesk.Revit.DB.Group item) => throw new System.NotImplementedException();

  public virtual System.Boolean IsEmpty
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Size
  {
    get => throw new System.NotImplementedException();
  }
}
