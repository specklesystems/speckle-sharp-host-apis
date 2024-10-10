namespace Rhino.FileIO;

public partial class BinaryArchiveFile : System.IDisposable
{
  public BinaryArchiveFile() { }

  public BinaryArchiveFile(System.String filename, Rhino.FileIO.BinaryArchiveMode mode) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Open() => throw new System.NotImplementedException();

  public virtual void Close() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual Rhino.FileIO.BinaryArchiveReader Reader
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.BinaryArchiveWriter Writer
  {
    get => throw new System.NotImplementedException();
  }
}
