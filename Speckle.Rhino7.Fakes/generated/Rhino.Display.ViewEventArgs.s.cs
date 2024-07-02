namespace Rhino.Display;

public partial class ViewEventArgs : System.EventArgs
{
	public ViewEventArgs() {}
	public virtual Rhino.Display.RhinoView View
	{
		get => throw new System.NotImplementedException();
	}
}
