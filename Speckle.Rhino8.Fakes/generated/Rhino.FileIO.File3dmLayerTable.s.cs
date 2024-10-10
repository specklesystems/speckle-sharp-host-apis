namespace Rhino.FileIO;

public partial class File3dmLayerTable : Rhino.FileIO.File3dmCommonComponentTable<Rhino.DocObjects.Layer>
{
  public File3dmLayerTable() { }

  public virtual System.Int32 AddLayer(System.String name, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 AddLayer(System.String name, System.Drawing.Color color, System.Guid parentId) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 AddDefaultLayer(System.String name, System.Drawing.Color color) =>
    throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.Layer FindName(System.String name, System.Guid parentId) =>
    throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.Layer FindNameHash(Rhino.FileIO.NameHash nameHash) =>
    throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.Layer FindIndex(System.Int32 index) => throw new System.NotImplementedException();

  public override Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
}
