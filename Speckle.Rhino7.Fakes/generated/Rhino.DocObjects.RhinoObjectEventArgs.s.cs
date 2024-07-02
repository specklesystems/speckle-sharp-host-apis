namespace Rhino.DocObjects;

public partial class RhinoObjectEventArgs : System.EventArgs
{
  public RhinoObjectEventArgs() { }

  public virtual System.Guid ObjectId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.RhinoObject TheObject
  {
    get => throw new System.NotImplementedException();
  }
}
