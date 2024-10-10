namespace Rhino.FileIO;

public partial class File3dmPlugInDataTable
  : System.Collections.Generic.IEnumerable<Rhino.FileIO.File3dmPlugInData>,
    System.Collections.IEnumerable,
    Rhino.Collections.IRhinoTable<Rhino.FileIO.File3dmPlugInData>
{
  public File3dmPlugInDataTable() { }

  public virtual System.String Dump() => throw new System.NotImplementedException();

  public virtual System.Boolean TryRead(
    Rhino.FileIO.File3dmPlugInData pluginData,
    System.Func<Rhino.FileIO.File3dm, Rhino.FileIO.BinaryArchiveReader, System.Boolean> dataReader
  ) => throw new System.NotImplementedException();

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.FileIO.File3dmPlugInData> GetEnumerator() =>
    throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual System.Int32 Count
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.File3dmPlugInData this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
  }
}
