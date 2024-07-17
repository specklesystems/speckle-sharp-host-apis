namespace Autodesk.Revit.DB;

public partial class FamilySizeTable : System.IDisposable
{
  public FamilySizeTable() { }

  public virtual Autodesk.Revit.DB.FamilySizeTableColumn GetColumnHeader(System.Int32 index) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValidColumnIndex(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.String AsValueString(System.Int32 row, System.Int32 column) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 NumberOfColumns
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 NumberOfRows
  {
    get => throw new System.NotImplementedException();
  }
}
