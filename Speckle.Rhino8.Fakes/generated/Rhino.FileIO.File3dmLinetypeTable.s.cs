namespace Rhino.FileIO;

public partial class File3dmLinetypeTable : Rhino.FileIO.File3dmCommonComponentTable<Rhino.DocObjects.Linetype>
{
  public File3dmLinetypeTable() { }

  public virtual Rhino.DocObjects.Linetype FindName(System.String name) => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.Linetype FindNameHash(Rhino.FileIO.NameHash nameHash) =>
    throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.Linetype FindIndex(System.Int32 index) => throw new System.NotImplementedException();

  public override Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
}
