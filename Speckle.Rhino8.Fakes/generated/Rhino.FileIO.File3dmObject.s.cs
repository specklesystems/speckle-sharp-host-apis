namespace Rhino.FileIO;

public partial class File3dmObject : Rhino.DocObjects.ModelComponent, System.IEquatable<Rhino.FileIO.File3dmObject>
{
  public File3dmObject() { }

  public virtual System.Boolean Equals(Rhino.FileIO.File3dmObject other) => throw new System.NotImplementedException();

  public virtual System.Boolean TryReadUserData(
    System.Guid userDataId,
    System.Boolean readFromAttributes,
    System.Func<Rhino.FileIO.File3dm, Rhino.FileIO.BinaryArchiveReader, System.Boolean> dataReader
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Render.TextureMapping GetTextureMapping(
    System.Int32 mappingChannelId,
    out Rhino.Geometry.Transform xform
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.GeometryBase Geometry
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.ObjectAttributes Attributes
  {
    get => throw new System.NotImplementedException();
  }
  public new System.String Name
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public new Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
}
