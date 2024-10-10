namespace Rhino.FileIO;

public partial class SHA1OpenNURBS : System.Security.Cryptography.SHA1
{
  public SHA1OpenNURBS() { }

  public static System.Byte[] StringHash(System.String input) => throw new System.NotImplementedException();

  public static System.Byte[] FileSystemPathHash(System.String path, System.Nullable<System.Boolean> ignoreCase) =>
    throw new System.NotImplementedException();
}
