namespace Rhino.Render;

public partial class AsyncRenderContext : System.IDisposable
{
	public AsyncRenderContext() {}
	public virtual System.Boolean StartRenderThread(System.Threading.ThreadStart threadStart,System.String threadName) => throw new System.NotImplementedException();
	public virtual void JoinRenderThread() => throw new System.NotImplementedException();
	public virtual void StopRendering() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderWindow RenderWindow
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Threading.Thread RenderThread
	{
		get => throw new System.NotImplementedException();
	}
}
