namespace Rhino.Render;

public partial class RealtimeDisplayMode
{
	public RealtimeDisplayMode() {}
	public static Rhino.Render.RealtimeDisplayModeClassInfo RegisterDisplayModes(System.Reflection.Assembly assembly,System.Guid pluginId) => throw new System.NotImplementedException();
	public static void UnregisterDisplayModes(System.Reflection.Assembly assembly,System.Guid pluginId) => throw new System.NotImplementedException();
	public virtual void PostConstruct() => throw new System.NotImplementedException();
	public virtual void SignalRedraw() => throw new System.NotImplementedException();
	public virtual System.UInt32 ComputeViewportCrc(Rhino.DocObjects.ViewInfo view) => throw new System.NotImplementedException();
	public virtual void SetView(Rhino.DocObjects.ViewInfo view) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.ViewInfo GetView() => throw new System.NotImplementedException();
	public static void RemoveRealtimeViewport(System.IntPtr realtimeViewport) => throw new System.NotImplementedException();
	public static Rhino.Render.RealtimeDisplayMode GetRealtimeViewport(System.IntPtr realtimeViewport) => throw new System.NotImplementedException();
	public static Rhino.Render.RealtimeDisplayMode GetRealtimeViewport(System.IntPtr realtimeViewport,System.Boolean create) => throw new System.NotImplementedException();
	public virtual System.Boolean StartRenderer(System.Int32 w,System.Int32 h,Rhino.RhinoDoc doc,Rhino.DocObjects.ViewInfo view,Rhino.DocObjects.ViewportInfo viewportInfo,System.Boolean forCapture,Rhino.Render.RenderWindow renderWindow) => throw new System.NotImplementedException();
	public virtual void ShutdownRenderer() => throw new System.NotImplementedException();
	public virtual System.Int32 LastRenderedPass() => throw new System.NotImplementedException();
	public virtual System.Boolean ShowCaptureProgress() => throw new System.NotImplementedException();
	public virtual System.Double CaptureProgress() => throw new System.NotImplementedException();
	public virtual System.Boolean OnRenderSizeChanged(System.Int32 width,System.Int32 height) => throw new System.NotImplementedException();
	public virtual System.Boolean IsRendererStarted() => throw new System.NotImplementedException();
	public virtual System.Boolean IsFrameBufferAvailable(Rhino.DocObjects.ViewInfo view) => throw new System.NotImplementedException();
	public virtual System.Boolean IsCompleted() => throw new System.NotImplementedException();
	public virtual System.Boolean DrawOpenGl() => throw new System.NotImplementedException();
	public virtual System.Boolean UseFastDraw() => throw new System.NotImplementedException();
	public virtual void SetUseDrawOpenGl(System.Boolean use) => throw new System.NotImplementedException();
	public virtual System.Int32 OpenGlVersion() => throw new System.NotImplementedException();
	public virtual System.String HudProductName() => throw new System.NotImplementedException();
	public virtual System.String HudCustomStatusText() => throw new System.NotImplementedException();
	public virtual System.Int32 HudMaximumPasses() => throw new System.NotImplementedException();
	public virtual System.Int32 HudLastRenderedPass() => throw new System.NotImplementedException();
	public virtual System.Boolean HudRendererPaused() => throw new System.NotImplementedException();
	public virtual System.Boolean HudRendererLocked() => throw new System.NotImplementedException();
	public virtual System.Boolean HudAllowEditMaxPasses() => throw new System.NotImplementedException();
	public virtual System.Boolean HudShowMaxPasses() => throw new System.NotImplementedException();
	public virtual System.Boolean HudShowPasses() => throw new System.NotImplementedException();
	public virtual System.Boolean HudShowCustomStatusText() => throw new System.NotImplementedException();
	public virtual System.Boolean HudShowControls() => throw new System.NotImplementedException();
	public virtual System.Boolean HudShow() => throw new System.NotImplementedException();
	public virtual System.DateTime HudStartTime() => throw new System.NotImplementedException();
	public virtual Rhino.Render.LinearWorkflow LinearWorkflow
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Paused
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean Locked
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean PostEffectsOn
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 MaxPasses
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
