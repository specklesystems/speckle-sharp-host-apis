namespace Rhino.FileIO;

public partial class File3dmRenderTexture : Rhino.FileIO.File3dmRenderContent
{
  public File3dmRenderTexture() { }

  public virtual Rhino.DocObjects.Texture ToTexture() => throw new System.NotImplementedException();

  public virtual System.String Filename
  {
    get => throw new System.NotImplementedException();
  }
}
