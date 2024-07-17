namespace Autodesk.Revit.DB;

public partial class ElementArray : Autodesk.Revit.DB.APIObject, System.Collections.IEnumerable
{
  public ElementArray() { }

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementArrayIterator ForwardIterator() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementArrayIterator ReverseIterator() => throw new System.NotImplementedException();

  public virtual System.Collections.IEnumerator GetEnumerator() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Element get_Item(System.Int32 index) => throw new System.NotImplementedException();

  public virtual void set_Item(System.Int32 index, Autodesk.Revit.DB.Element item) =>
    throw new System.NotImplementedException();

  public virtual void Append(Autodesk.Revit.DB.Element item) => throw new System.NotImplementedException();

  public virtual void Insert(Autodesk.Revit.DB.Element item, System.Int32 index) =>
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
