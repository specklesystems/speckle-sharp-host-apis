namespace Rhino.Runtime;

public partial class CommonObject : System.IDisposable, System.Runtime.Serialization.ISerializable
{
  public CommonObject() { }

  public virtual void EnsurePrivateCopy() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidWithLog(out System.String log) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual void GetObjectData(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context
  ) => throw new System.NotImplementedException();

  public static Rhino.Runtime.CommonObject FromBase64String(
    System.Int32 archive3dm,
    System.Int32 opennurbs,
    System.String base64Data
  ) => throw new System.NotImplementedException();

  public static Rhino.Runtime.CommonObject FromJSON(System.String json) => throw new System.NotImplementedException();

  public static Rhino.Runtime.CommonObject FromJSON(
    System.Collections.Generic.Dictionary<System.String, System.String> jsonDictionary
  ) => throw new System.NotImplementedException();

  public static System.Boolean PerformCorruptionTesting
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsDocumentControlled
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Disposed
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean HasUserData
  {
    get => throw new System.NotImplementedException();
  }
}
