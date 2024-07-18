namespace Autodesk.Revit.DB;

public partial class ReferenceArray : Autodesk.Revit.DB.APIObject, System.Collections.IEnumerable
{
  public ReferenceArray() { }

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ReferenceArrayIterator ForwardIterator() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ReferenceArrayIterator ReverseIterator() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.IEnumerator GetEnumerator() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Reference get_Item(System.Int32 index) => throw new System.NotImplementedException();

  public virtual void set_Item(System.Int32 index, Autodesk.Revit.DB.Reference item) =>
    throw new System.NotImplementedException();

  public virtual void Append(Autodesk.Revit.DB.Reference item) => throw new System.NotImplementedException();

  public virtual void Insert(Autodesk.Revit.DB.Reference item, System.Int32 index) =>
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
