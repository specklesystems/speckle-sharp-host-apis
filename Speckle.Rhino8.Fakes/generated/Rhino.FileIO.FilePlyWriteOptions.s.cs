namespace Rhino.FileIO;

public partial class FilePlyWriteOptions
{
  public FilePlyWriteOptions() { }

  public FilePlyWriteOptions(Rhino.FileIO.FileWriteOptions writeOptions) => throw new System.NotImplementedException();

  public Rhino.FileIO.FileWriteOptions WriteOptions;
  public virtual System.Boolean UseSimpleDialog
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ExportASCII
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ExportDoubles
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ExportNormals
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ExportColors
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ExportMaterial
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.MeshingParameters MeshingParameters
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
