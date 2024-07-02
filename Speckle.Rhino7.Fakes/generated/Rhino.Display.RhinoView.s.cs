namespace Rhino.Display;

public partial class RhinoView
{
	public RhinoView() {}
	public static Rhino.Display.RhinoView FromRuntimeSerialNumber(System.UInt32 serialNumber) => throw new System.NotImplementedException();
	public virtual System.Drawing.Point ScreenToClient(System.Drawing.Point screenPoint) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point2d ScreenToClient(Rhino.Geometry.Point2d screenPoint) => throw new System.NotImplementedException();
	public virtual System.Drawing.Point ClientToScreen(System.Drawing.Point clientPoint) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point2d ClientToScreen(Rhino.Geometry.Point2d clientPoint) => throw new System.NotImplementedException();
	public virtual void Redraw() => throw new System.NotImplementedException();
	public virtual System.Double SpeedTest(System.Int32 frameCount,System.Boolean freezeDrawList,System.Int32 direction,System.Double angleDeltaRadians) => throw new System.NotImplementedException();
	public virtual System.Boolean CreateWireframePreviewImage(System.String imagePath,System.Drawing.Size size,System.Boolean ignoreHighlights,System.Boolean drawConstructionPlane) => throw new System.NotImplementedException();
	public virtual System.Boolean CreateShadedPreviewImage(System.String imagePath,System.Drawing.Size size,System.Boolean ignoreHighlights,System.Boolean drawConstructionPlane,System.Boolean useGhostedShading) => throw new System.NotImplementedException();
	public virtual System.Drawing.Bitmap CaptureToBitmap() => throw new System.NotImplementedException();
	public virtual System.Drawing.Bitmap CaptureToBitmap(System.Drawing.Size size) => throw new System.NotImplementedException();
	public virtual System.Drawing.Bitmap CaptureToBitmap(System.Drawing.Size size,System.Boolean grid,System.Boolean worldAxes,System.Boolean cplaneAxes) => throw new System.NotImplementedException();
	public virtual System.Drawing.Bitmap CaptureToBitmap(System.Boolean grid,System.Boolean worldAxes,System.Boolean cplaneAxes) => throw new System.NotImplementedException();
	public virtual System.Drawing.Bitmap CaptureToBitmap(System.Drawing.Size size,Rhino.Display.DisplayModeDescription mode) => throw new System.NotImplementedException();
	public virtual System.Drawing.Bitmap CaptureToBitmap(Rhino.Display.DisplayModeDescription mode) => throw new System.NotImplementedException();
	public virtual System.Drawing.Bitmap CaptureToBitmap(System.Drawing.Size size,Rhino.Display.DisplayPipelineAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Drawing.Bitmap CaptureToBitmap(Rhino.Display.DisplayPipelineAttributes attributes) => throw new System.NotImplementedException();
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
	public virtual System.Drawing.Rectangle Bounds
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Drawing.Rectangle ClientRectangle
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Drawing.Rectangle ScreenRectangle
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Drawing.Size Size
	{
		get => throw new System.NotImplementedException();
		set {}
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
