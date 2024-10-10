namespace Rhino.FileIO;

public partial class FileReference : System.IDisposable
{
  public FileReference() { }

  public FileReference(
    System.String fullPath,
    System.String relativePath,
    Rhino.FileIO.ContentHash hash,
    Rhino.FileIO.FileReferenceStatus status
  ) => throw new System.NotImplementedException();

  public static Rhino.FileIO.FileReference CreateFromFullPath(System.String fullPath) =>
    throw new System.NotImplementedException();

  public static Rhino.FileIO.FileReference CreateFromFullAndRelativePaths(
    System.String fullPath,
    System.String relativePath
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.String FullPath
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String RelativePath
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.ContentHash ContentHash
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.FileReferenceStatus FullPathStatus
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsSet
  {
    get => throw new System.NotImplementedException();
  }
}
