namespace Rhino.Render;

public partial class RenderContentChangedEventArgs : Rhino.Render.RenderContentEventArgs
{
	public RenderContentChangedEventArgs() {}
	public virtual Rhino.Render.RenderContent.ChangeContexts ChangeContext
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RenderContent OldContent
	{
		get => throw new System.NotImplementedException();
	}
}
