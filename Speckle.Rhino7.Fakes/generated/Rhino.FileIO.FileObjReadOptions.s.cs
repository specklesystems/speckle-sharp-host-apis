namespace Rhino.FileIO;

public partial class FileObjReadOptions
{
  public FileObjReadOptions() { }

  public FileObjReadOptions(Rhino.FileIO.FileReadOptions readOptions) => throw new System.NotImplementedException();

  public Rhino.FileIO.FileReadOptions ReadOptions;

  public virtual Rhino.Geometry.Transform GetTransform() => throw new System.NotImplementedException();

  public virtual Rhino.FileIO.FileObjReadOptions.UseObjGsAs UseObjGroupsAs
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseObjObjects
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean MapYtoZ
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean MorphTargetOnly
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ReverseGroupOrder
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IgnoreTextures
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DisplayColorFromObjMaterial
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean Split32BitTextures
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
