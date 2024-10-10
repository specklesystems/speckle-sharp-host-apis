namespace Rhino.FileIO;

public partial class File3dmRenderMaterial : Rhino.FileIO.File3dmRenderContent
{
  public File3dmRenderMaterial() { }

  public virtual Rhino.DocObjects.Material ToMaterial() => throw new System.NotImplementedException();
}
