namespace Autodesk.Revit.DB;

public partial class CurveArray : Autodesk.Revit.DB.APIObject, System.Collections.IEnumerable
{
  public CurveArray() => throw new System.NotImplementedException();

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveArrayIterator ForwardIterator() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveArrayIterator ReverseIterator() => throw new System.NotImplementedException();

  public virtual System.Collections.IEnumerator GetEnumerator() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Curve get_Item(System.Int32 index) => throw new System.NotImplementedException();

  public virtual void set_Item(System.Int32 index, Autodesk.Revit.DB.Curve item) =>
    throw new System.NotImplementedException();

  public virtual void Append(Autodesk.Revit.DB.Curve item) => throw new System.NotImplementedException();

  public virtual void Insert(Autodesk.Revit.DB.Curve item, System.Int32 index) =>
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
