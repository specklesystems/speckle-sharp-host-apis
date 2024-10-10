namespace Rhino.FileIO;

public partial class File3dmRenderEnvironment : Rhino.FileIO.File3dmRenderContent
{
  public File3dmRenderEnvironment() { }

  public virtual Rhino.DocObjects.Environment ToEnvironment() => throw new System.NotImplementedException();
}
