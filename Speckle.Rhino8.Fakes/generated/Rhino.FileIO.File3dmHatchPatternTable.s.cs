namespace Rhino.FileIO;

public partial class File3dmHatchPatternTable : Rhino.FileIO.File3dmCommonComponentTable<Rhino.DocObjects.HatchPattern>
{
  public File3dmHatchPatternTable() { }

  public virtual Rhino.DocObjects.HatchPattern FindName(System.String name) =>
    throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.HatchPattern FindNameHash(Rhino.FileIO.NameHash nameHash) =>
    throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.HatchPattern FindIndex(System.Int32 index) =>
    throw new System.NotImplementedException();

  public override Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
}
