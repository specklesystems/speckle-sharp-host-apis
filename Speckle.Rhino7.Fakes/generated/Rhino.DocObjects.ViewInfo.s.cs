namespace Rhino.DocObjects;

public partial class ViewInfo : System.IDisposable
{
	public ViewInfo() {}
	public ViewInfo(Rhino.Display.RhinoViewport rhinoViewPort) => throw new System.NotImplementedException();
	public ViewInfo(System.UInt32 docRuntimeSerialNumber) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.String Name
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String WallpaperFilename
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean ShowWallpaperInGrayScale
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean WallpaperHidden
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double FocalBlurDistance
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double FocalBlurAperture
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double FocalBlurJitter
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.UInt32 FocalBlurSampleCount
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.ViewInfoFocalBlurModes FocalBlurMode
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.ViewportInfo Viewport
	{
		get => throw new System.NotImplementedException();
	}
}
