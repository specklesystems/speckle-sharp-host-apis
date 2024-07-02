namespace Rhino.Display;

public partial class DisplayBitmap : System.IDisposable
{
	public DisplayBitmap() {}
	public DisplayBitmap(System.Drawing.Bitmap bitmap) => throw new System.NotImplementedException();
	public static Rhino.Display.DisplayBitmap Load(System.String path) => throw new System.NotImplementedException();
	public virtual void SetBlendFunction(Rhino.Display.BlendMode source,Rhino.Display.BlendMode destination) => throw new System.NotImplementedException();
	public virtual void GetBlendModes(out Rhino.Display.BlendMode source,out Rhino.Display.BlendMode destination) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Drawing.Size Size
	{
		get => throw new System.NotImplementedException();
	}
}
