namespace Rhino.Render;

public partial class RenderWindow : System.IDisposable
{
	public RenderWindow() {}
	public virtual void Dispose() => throw new System.NotImplementedException();
	public static System.Guid ChannelId(Rhino.Render.RenderWindow.StandardChannels ch) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderWindow.StandardChannels StandardChannelForGuid(System.Guid id) => throw new System.NotImplementedException();
	public virtual void SetView(Rhino.DocObjects.ViewInfo view) => throw new System.NotImplementedException();
	public virtual void SetProgress(System.String text,System.Single progress) => throw new System.NotImplementedException();
	public virtual void EndAsyncRender(Rhino.Render.RenderWindow.RenderSuccessCode successCode) => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderWindow.Channel OpenChannel(Rhino.Render.RenderWindow.StandardChannels id) => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderWindow.StandardChannels[] GetRequestedRenderChannelsAsStandardChannels() => throw new System.NotImplementedException();
	public virtual System.Guid[] GetRequestedRenderChannels() => throw new System.NotImplementedException();
	public virtual System.Boolean IsChannelAvailable(System.Guid id) => throw new System.NotImplementedException();
	public virtual System.Boolean IsChannelShown(System.Guid id) => throw new System.NotImplementedException();
	public virtual System.Boolean AddChannel(Rhino.Render.RenderWindow.StandardChannels channel) => throw new System.NotImplementedException();
	public virtual void Invalidate() => throw new System.NotImplementedException();
	public virtual void SaveDibAsBitmap(System.String filename) => throw new System.NotImplementedException();
	public virtual void SaveRenderImageAs(System.String filename,System.Guid renderEngineGuid,System.Boolean saveAlpha) => throw new System.NotImplementedException();
	public virtual void SaveRenderImageAs(System.String filename,System.Boolean saveAlpha) => throw new System.NotImplementedException();
	public virtual void SetIsRendering(System.Boolean is_rendering) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderWindow FromSessionId(System.Guid sessionId) => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderWindow.ImageAdjust GetAdjust() => throw new System.NotImplementedException();
	public virtual void SetAdjust(Rhino.Render.RenderWindow.ImageAdjust imageAdjust) => throw new System.NotImplementedException();
	public virtual System.Guid SessionId
	{
		get => throw new System.NotImplementedException();
	}
}
