namespace Rhino.Display;

public partial class DrawForegroundEventArgs : Rhino.Display.DrawEventArgs
{
	public DrawForegroundEventArgs() {}
	public virtual System.Boolean WorldAxesDrawn
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean DrawWorldAxes
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
