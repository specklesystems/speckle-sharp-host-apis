namespace Rhino.FileIO;

public partial class NameHash : System.ICloneable, System.IEquatable<Rhino.FileIO.NameHash>
{
  public NameHash() { }

  public NameHash(System.String name) => throw new System.NotImplementedException();

  public NameHash(System.String name, System.Guid parentId) => throw new System.NotImplementedException();

  public NameHash(System.String name, System.Guid parentId, Rhino.DocObjects.ModelComponentType type) =>
    throw new System.NotImplementedException();

  public NameHash(System.String name, System.Guid parentId, System.Boolean ignoreCase) =>
    throw new System.NotImplementedException();

  public static Rhino.FileIO.NameHash CreateFilePathHash(System.String path) =>
    throw new System.NotImplementedException();

  public virtual Rhino.FileIO.NameHash Clone() => throw new System.NotImplementedException();

  public virtual System.Boolean Equals(Rhino.FileIO.NameHash other) => throw new System.NotImplementedException();

  System.Object System.ICloneable.Clone() => throw new System.NotImplementedException();

  public virtual System.Byte[] Sha1Hash
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.UInt32 MappedCodePoints
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Guid ParentId
  {
    get => throw new System.NotImplementedException();
  }
}
