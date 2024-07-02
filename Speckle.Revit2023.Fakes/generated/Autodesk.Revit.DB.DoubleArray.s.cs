namespace Autodesk.Revit.DB;

public partial class DoubleArray : Autodesk.Revit.DB.APIObject, System.Collections.IEnumerable
{
  public DoubleArray() { }

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.DoubleArrayIterator ForwardIterator() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.DoubleArrayIterator ReverseIterator() => throw new System.NotImplementedException();

  public virtual System.Collections.IEnumerator GetEnumerator() => throw new System.NotImplementedException();

  public virtual System.Double get_Item(System.Int32 index) => throw new System.NotImplementedException();

  public virtual void set_Item(System.Int32 index, System.Double item) => throw new System.NotImplementedException();

  public virtual System.Boolean IsEmpty
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Size
  {
    get => throw new System.NotImplementedException();
  }
}
