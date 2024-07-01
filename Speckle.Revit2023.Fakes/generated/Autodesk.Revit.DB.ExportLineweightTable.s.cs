namespace Autodesk.Revit.DB;

public partial class ExportLineweightTable
  : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<
    Autodesk.Revit.DB.ExportLineweightKey,
    Autodesk.Revit.DB.ExportLineweightInfo
  >>,
    System.IDisposable
{
  public ExportLineweightTable() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ExportLineweightTableIterator GetLineweightTableIterator() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ExportLineweightInfo get_Item(Autodesk.Revit.DB.ExportLineweightKey lineweightKey) =>
    throw new System.NotImplementedException();

  public virtual void set_Item(
    Autodesk.Revit.DB.ExportLineweightKey LineweightKey,
    Autodesk.Revit.DB.ExportLineweightInfo LineweightInfo
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean ContainsKey(Autodesk.Revit.DB.ExportLineweightKey exportLineweightKey) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ExportLineweightInfo GetExportLineweightInfo(
    Autodesk.Revit.DB.ExportLineweightKey exportLineweightKey
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ExportLineweightKey> GetKeys() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ExportLineweightInfo> GetValues() =>
    throw new System.NotImplementedException();

  public virtual void Add(
    Autodesk.Revit.DB.ExportLineweightKey exportLineweightKey,
    Autodesk.Revit.DB.ExportLineweightInfo exportLineweightInfo
  ) => throw new System.NotImplementedException();

  public virtual void Remove(Autodesk.Revit.DB.ExportLineweightKey exportLineweightKey) =>
    throw new System.NotImplementedException();

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<
    Autodesk.Revit.DB.ExportLineweightKey,
    Autodesk.Revit.DB.ExportLineweightInfo
  >> GetEnumerator() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Count
  {
    get => throw new System.NotImplementedException();
  }
}
