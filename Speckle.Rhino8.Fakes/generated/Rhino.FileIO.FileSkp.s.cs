namespace Rhino.FileIO;

public partial class FileSkp
{
  public FileSkp() { }

  public static System.Boolean Write(
    System.String filename,
    Rhino.RhinoDoc doc,
    Rhino.FileIO.FileSkpWriteOptions options
  ) => throw new System.NotImplementedException();

  public static System.Boolean Read(System.String path, Rhino.RhinoDoc doc, Rhino.FileIO.FileSkpReadOptions options) =>
    throw new System.NotImplementedException();
}
