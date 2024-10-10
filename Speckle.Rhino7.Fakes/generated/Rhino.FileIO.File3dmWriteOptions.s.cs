namespace Rhino.FileIO;

public partial class File3dmWriteOptions
{
  public File3dmWriteOptions() { }

  public virtual void EnableRenderMeshes(Rhino.DocObjects.ObjectType objectType, System.Boolean enable) =>
    throw new System.NotImplementedException();

  public virtual void EnableAnalysisMeshes(Rhino.DocObjects.ObjectType objectType, System.Boolean enable) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 Version
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SaveRenderMeshes
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SaveAnalysisMeshes
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SaveUserData
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
