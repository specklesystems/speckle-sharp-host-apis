namespace Rhino.DocObjects;

public partial class RhinoReplaceObjectEventArgs : System.EventArgs
{
  public RhinoReplaceObjectEventArgs() { }

  public virtual System.Guid ObjectId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.RhinoObject OldRhinoObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.RhinoObject NewRhinoObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.RhinoDoc Document
  {
    get => throw new System.NotImplementedException();
  }
}
