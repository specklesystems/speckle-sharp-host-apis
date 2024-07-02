namespace Rhino.Render;

public partial class RenderWindowClonedEventArgs : System.EventArgs
{
	public RenderWindowClonedEventArgs() {}
	public virtual System.Guid OldSessionId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid NewSessionId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RenderWindow OldRenderWindow
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RenderWindow NewRenderWindow
	{
		get => throw new System.NotImplementedException();
	}
}
