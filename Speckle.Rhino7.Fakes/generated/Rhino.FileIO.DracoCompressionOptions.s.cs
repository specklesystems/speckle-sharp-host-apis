namespace Rhino.FileIO;

public partial class DracoCompressionOptions
{
  public DracoCompressionOptions() { }

  public System.Boolean IncludeNormals;
  public System.Boolean IncludeTextureCoordinates;
  public System.Boolean IncludeVertexColors;
  public Rhino.FileIO.DracoColorFormat VertexColorFormat;
  public virtual System.Int32 CompressionLevel
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 PositionQuantizationBits
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 TextureCoordintateQuantizationBits
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 NormalQuantizationBits
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
