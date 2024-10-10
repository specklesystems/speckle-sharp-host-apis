namespace Rhino.FileIO;

public partial class File3dmMaterialTable : Rhino.FileIO.File3dmCommonComponentTable<Rhino.DocObjects.Material>
{
  public File3dmMaterialTable() { }

  public virtual Rhino.DocObjects.Material FindIndex(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Int32 AddMaterial(Rhino.DocObjects.Material material) =>
    throw new System.NotImplementedException();

  public override Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
}
