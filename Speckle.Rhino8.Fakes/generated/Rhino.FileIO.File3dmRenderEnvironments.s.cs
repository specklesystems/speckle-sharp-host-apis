namespace Rhino.FileIO;

public partial class File3dmRenderEnvironments
  : System.Collections.Generic.IEnumerable<Rhino.FileIO.File3dmRenderEnvironment>,
    System.Collections.IEnumerable
{
  public File3dmRenderEnvironments() { }

  public File3dmRenderEnvironments(Rhino.FileIO.File3dm f) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.FileIO.File3dmRenderEnvironment> GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual Rhino.FileIO.File3dmRenderEnvironment Find(System.Guid g) =>
    throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();
}
