namespace Rhino.DocObjects;

public partial class RhinoObjectSelectionEventArgs : System.EventArgs
{
	public RhinoObjectSelectionEventArgs() {}
	public virtual System.Boolean Selected
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.RhinoDoc Document
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.RhinoObject[] RhinoObjects
	{
		get => throw new System.NotImplementedException();
	}
}
