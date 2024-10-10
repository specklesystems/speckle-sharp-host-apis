namespace Rhino.FileIO;

public partial class File3dmEmbeddedFiles
  : System.Collections.Generic.IEnumerable<Rhino.FileIO.File3dmEmbeddedFile>,
    System.Collections.IEnumerable
{
  public File3dmEmbeddedFiles() { }

  public File3dmEmbeddedFiles(Rhino.FileIO.File3dm f) => throw new System.NotImplementedException();

  public virtual System.Boolean Add(System.String filename) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.FileIO.File3dmEmbeddedFile> GetEnumerator() =>
    throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();
}
