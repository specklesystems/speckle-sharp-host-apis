namespace Rhino.FileIO;

public partial class File3dmRenderTextures
  : System.Collections.Generic.IEnumerable<Rhino.FileIO.File3dmRenderTexture>,
    System.Collections.IEnumerable
{
  public File3dmRenderTextures() { }

  public File3dmRenderTextures(Rhino.FileIO.File3dm f) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.FileIO.File3dmRenderTexture> GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual Rhino.FileIO.File3dmRenderTexture Find(System.Guid g) => throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();
}
