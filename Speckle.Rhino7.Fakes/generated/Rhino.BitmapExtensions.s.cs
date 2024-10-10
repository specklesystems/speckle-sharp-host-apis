namespace Rhino;

public partial class BitmapExtensions
{
  public BitmapExtensions() { }

  public static System.Boolean IsNormalMap(
    System.Drawing.Bitmap bitmap,
    System.Boolean bLossyCompressionSource,
    out System.Boolean bPositiveZComponent
  ) => throw new System.NotImplementedException();

  public static System.Drawing.Bitmap ConvertToNormalMap(
    System.Drawing.Bitmap bitmap,
    System.Boolean bLossyCompressionSource,
    out System.Boolean bPositiveZComponent
  ) => throw new System.NotImplementedException();

  public static Rhino.FileIO.FileReference BitmapAsTextureFileReference(
    System.Drawing.Bitmap bitmap,
    System.UInt32 crc
  ) => throw new System.NotImplementedException();
}
