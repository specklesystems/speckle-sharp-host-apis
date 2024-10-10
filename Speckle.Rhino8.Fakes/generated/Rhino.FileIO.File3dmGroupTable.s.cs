namespace Rhino.FileIO;

public partial class File3dmGroupTable : Rhino.FileIO.File3dmCommonComponentTable<Rhino.DocObjects.Group>
{
  public File3dmGroupTable() { }

  public virtual Rhino.DocObjects.Group FindName(System.String name) => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.Group FindNameHash(Rhino.FileIO.NameHash nameHash) =>
    throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.Group FindIndex(System.Int32 groupIndex) =>
    throw new System.NotImplementedException();

  public virtual Rhino.FileIO.File3dmObject[] GroupMembers(System.Int32 groupIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 AddGroup() => throw new System.NotImplementedException();

  public override Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
}
