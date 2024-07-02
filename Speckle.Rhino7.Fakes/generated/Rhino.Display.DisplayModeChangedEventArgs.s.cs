namespace Rhino.Display;

public partial class DisplayModeChangedEventArgs : System.EventArgs
{
	public DisplayModeChangedEventArgs() {}
	public virtual Rhino.Display.RhinoViewport Viewport
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.RhinoDoc RhinoDoc
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid OldDisplayModeId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid ChangedDisplayModeId
	{
		get => throw new System.NotImplementedException();
	}
}
