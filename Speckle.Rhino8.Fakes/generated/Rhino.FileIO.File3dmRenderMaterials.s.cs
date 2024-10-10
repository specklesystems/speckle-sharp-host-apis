namespace Rhino.FileIO;

public partial class File3dmRenderMaterials
  : System.Collections.Generic.IEnumerable<Rhino.FileIO.File3dmRenderMaterial>,
    System.Collections.IEnumerable
{
  public File3dmRenderMaterials() { }

  public File3dmRenderMaterials(Rhino.FileIO.File3dm f) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.FileIO.File3dmRenderMaterial> GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual Rhino.FileIO.File3dmRenderMaterial Find(System.Guid g) => throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();
}
