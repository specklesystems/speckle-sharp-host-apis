namespace Rhino.FileIO;

public partial class File3dmEmbeddedFile : Rhino.DocObjects.ModelComponent
{
  public File3dmEmbeddedFile() { }

  public virtual System.Boolean SaveToFile(System.String filename) => throw new System.NotImplementedException();

  public virtual System.String Filename
  {
    get => throw new System.NotImplementedException();
  }
  public new Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
}
