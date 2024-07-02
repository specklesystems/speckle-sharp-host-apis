namespace Rhino.DocObjects;

public partial class RhinoDeselectAllObjectsEventArgs : System.EventArgs
{
  public RhinoDeselectAllObjectsEventArgs() { }

  public virtual System.Int32 ObjectCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.RhinoDoc Document
  {
    get => throw new System.NotImplementedException();
  }
}
