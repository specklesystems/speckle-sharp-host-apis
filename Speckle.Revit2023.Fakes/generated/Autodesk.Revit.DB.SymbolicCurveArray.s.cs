namespace Autodesk.Revit.DB;

public partial class SymbolicCurveArray : Autodesk.Revit.DB.APIObject, System.Collections.IEnumerable
{
  public SymbolicCurveArray() { }

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.SymbolicCurveArrayIterator ForwardIterator() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.SymbolicCurveArrayIterator ReverseIterator() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.IEnumerator GetEnumerator() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.SymbolicCurve get_Item(System.Int32 index) =>
    throw new System.NotImplementedException();

  public virtual void set_Item(System.Int32 index, Autodesk.Revit.DB.SymbolicCurve item) =>
    throw new System.NotImplementedException();

  public virtual void Append(Autodesk.Revit.DB.SymbolicCurve item) => throw new System.NotImplementedException();

  public virtual void Insert(Autodesk.Revit.DB.SymbolicCurve item, System.Int32 index) =>
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
