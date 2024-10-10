namespace Rhino.FileIO;

public partial class ContentHash : System.ICloneable, System.IEquatable<Rhino.FileIO.ContentHash>
{
  public ContentHash() { }

  public static Rhino.FileIO.ContentHash CreateFromFile(System.String path) =>
    throw new System.NotImplementedException();

  public virtual Rhino.FileIO.ContentHash Clone() => throw new System.NotImplementedException();

  public virtual System.Boolean Equals(Rhino.FileIO.ContentHash other) => throw new System.NotImplementedException();

  System.Object System.ICloneable.Clone() => throw new System.NotImplementedException();

  public virtual System.Byte[] Sha1NameHash
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.UInt64 ByteCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Byte[] Sha1ContentHash
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.DateTime HashTime
  {
    get => throw new System.NotImplementedException();
  }
}
