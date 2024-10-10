namespace Rhino.FileIO;

public partial class File3dmDimStyleTable : Rhino.FileIO.File3dmCommonComponentTable<Rhino.DocObjects.DimensionStyle>
{
  public File3dmDimStyleTable() { }

  public virtual Rhino.DocObjects.DimensionStyle FindName(System.String name) =>
    throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.DimensionStyle FindNameHash(Rhino.FileIO.NameHash nameHash) =>
    throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.DimensionStyle FindIndex(System.Int32 index) =>
    throw new System.NotImplementedException();

  public override Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
}
