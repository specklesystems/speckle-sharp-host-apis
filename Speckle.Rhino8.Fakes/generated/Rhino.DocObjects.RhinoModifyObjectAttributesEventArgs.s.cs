namespace Rhino.DocObjects;

public partial class RhinoModifyObjectAttributesEventArgs : System.EventArgs
{
  public RhinoModifyObjectAttributesEventArgs() { }

  public virtual Rhino.RhinoDoc Document
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.RhinoObject RhinoObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.ObjectAttributes OldAttributes
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.ObjectAttributes NewAttributes
  {
    get => throw new System.NotImplementedException();
  }
}
