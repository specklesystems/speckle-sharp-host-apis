namespace Rhino.FileIO;

public partial class File3dmCommonComponentTable<T> : Rhino.FileIO.CommonComponentTable<T>
{
  public File3dmCommonComponentTable() { }

  public virtual void Delete(System.Int32 index) => throw new System.NotImplementedException();

  public virtual void Add(T item) => throw new System.NotImplementedException();

  public virtual System.String Dump() => throw new System.NotImplementedException();
}
