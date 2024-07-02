namespace Rhino.Render;

public partial class ContentUndoBlocker : System.IDisposable
{
	public ContentUndoBlocker() {}
	public virtual void Dispose() => throw new System.NotImplementedException();
}
