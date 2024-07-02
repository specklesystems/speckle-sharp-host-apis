namespace Rhino.Render;

public partial class RdkUndo : System.IDisposable
{
	public RdkUndo() {}
	public RdkUndo(System.IntPtr pUndoRecord) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual Rhino.Render.RdkUndoRecord NewUndoRecord() => throw new System.NotImplementedException();
}
