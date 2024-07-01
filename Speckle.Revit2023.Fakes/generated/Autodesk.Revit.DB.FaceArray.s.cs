namespace Autodesk.Revit.DB;

public partial class FaceArray : Autodesk.Revit.DB.APIObject, System.Collections.IEnumerable
{
  public FaceArray() => throw new System.NotImplementedException();

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FaceArrayIterator ForwardIterator() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FaceArrayIterator ReverseIterator() => throw new System.NotImplementedException();

  public virtual System.Collections.IEnumerator GetEnumerator() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Face get_Item(System.Int32 index) => throw new System.NotImplementedException();

  public virtual void set_Item(System.Int32 index, Autodesk.Revit.DB.Face item) =>
    throw new System.NotImplementedException();

  public virtual void Append(Autodesk.Revit.DB.Face item) => throw new System.NotImplementedException();

  public virtual void Insert(Autodesk.Revit.DB.Face item, System.Int32 index) =>
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
