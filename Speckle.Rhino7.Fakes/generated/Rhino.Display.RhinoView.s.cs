namespace Rhino.Display;

public partial class RhinoView
{
	public RhinoView() {}
	public static Rhino.Display.RhinoView FromRuntimeSerialNumber(System.UInt32 serialNumber) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point2d ScreenToClient(Rhino.Geometry.Point2d screenPoint) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point2d ClientToScreen(Rhino.Geometry.Point2d clientPoint) => throw new System.NotImplementedException();
	public virtual void Redraw() => throw new System.NotImplementedException();
	public virtual System.Double SpeedTest(System.Int32 frameCount,System.Boolean freezeDrawList,System.Int32 direction,System.Double angleDeltaRadians) => throw new System.NotImplementedException();
	public virtual System.Boolean Close() => throw new System.NotImplementedException();
	public virtual System.Boolean MouseCaptured(System.Boolean bIncludeMovement) => throw new System.NotImplementedException();
	public virtual System.UInt32 RuntimeSerialNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.IntPtr Handle
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Display.DisplayPipeline DisplayPipeline
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RealtimeDisplayMode RealtimeDisplayMode
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean EnableDrawing
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.RhinoDoc Document
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Display.RhinoViewport MainViewport
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Display.RhinoViewport ActiveViewport
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid ActiveViewportID
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean TitleVisible
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean Maximized
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean Floating
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
