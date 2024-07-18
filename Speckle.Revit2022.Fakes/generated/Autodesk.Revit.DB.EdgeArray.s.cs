namespace Autodesk.Revit.DB;

public partial class EdgeArray : Autodesk.Revit.DB.APIObject, System.Collections.IEnumerable
{
  public EdgeArray() { }

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.EdgeArrayIterator ForwardIterator() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.EdgeArrayIterator ReverseIterator() => throw new System.NotImplementedException();

  public virtual System.Collections.IEnumerator GetEnumerator() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Edge get_Item(System.Int32 index) => throw new System.NotImplementedException();

  public virtual void set_Item(System.Int32 index, Autodesk.Revit.DB.Edge item) =>
    throw new System.NotImplementedException();

  public virtual void Append(Autodesk.Revit.DB.Edge item) => throw new System.NotImplementedException();

  public virtual void Insert(Autodesk.Revit.DB.Edge item, System.Int32 index) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsEmpty
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Size
  {
    get => throw new System.NotImplementedException();
  }
}
