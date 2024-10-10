namespace Rhino.FileIO;

public partial class SerializationOptions
{
  public SerializationOptions() { }

  public virtual System.Int32 RhinoVersion
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean WriteUserData
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean WriteRenderMeshes
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean WriteAnalysisMeshes
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
