namespace Rhino.FileIO;

public partial class File3dmStringTable
{
  public File3dmStringTable() { }

  public virtual System.String GetKey(System.Int32 i) => throw new System.NotImplementedException();

  public virtual System.String GetValue(System.Int32 i) => throw new System.NotImplementedException();

  public virtual System.String GetValue(System.String key) => throw new System.NotImplementedException();

  public virtual System.String GetValue(System.String section, System.String entry) =>
    throw new System.NotImplementedException();

  public virtual System.String[] GetSectionNames() => throw new System.NotImplementedException();

  public virtual System.String[] GetEntryNames(System.String section) => throw new System.NotImplementedException();

  public virtual System.String SetString(System.String section, System.String entry, System.String value) =>
    throw new System.NotImplementedException();

  public virtual System.String SetString(System.String key, System.String value) =>
    throw new System.NotImplementedException();

  public virtual void Delete(System.String section, System.String entry) => throw new System.NotImplementedException();

  public virtual void Delete(System.String key) => throw new System.NotImplementedException();

  public virtual System.Int32 Count
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 DocumentUserTextCount
  {
    get => throw new System.NotImplementedException();
  }
}
