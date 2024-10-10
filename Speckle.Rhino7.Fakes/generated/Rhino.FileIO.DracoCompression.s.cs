namespace Rhino.FileIO;

public partial class DracoCompression : System.IDisposable
{
  public DracoCompression() { }

  public virtual void Dispose() => throw new System.NotImplementedException();

  public static Rhino.FileIO.DracoCompression Compress(Rhino.Geometry.Mesh mesh) =>
    throw new System.NotImplementedException();

  public static Rhino.FileIO.DracoCompression Compress(
    Rhino.Geometry.Mesh mesh,
    Rhino.FileIO.DracoCompressionOptions options
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Write(System.String path) => throw new System.NotImplementedException();

  public static Rhino.Geometry.GeometryBase DecompressFile(System.String path) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.GeometryBase DecompressByteArray(System.Byte[] bytes) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.GeometryBase DecompressBase64String(System.String encoded) =>
    throw new System.NotImplementedException();

  public virtual System.String ToBase64String() => throw new System.NotImplementedException();

  public virtual System.Int32 VertexAttributePosition
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 NormalAttributePosition
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 TextureCoordinatesAttributePosition
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 VertexColorAttributePosition
  {
    get => throw new System.NotImplementedException();
  }
}
