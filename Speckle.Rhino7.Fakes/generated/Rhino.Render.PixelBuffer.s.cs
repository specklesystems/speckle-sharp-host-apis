namespace Rhino.Render;

public partial class PixelBuffer
{
	public PixelBuffer() {}
	public PixelBuffer(System.IntPtr bufferPointer) => throw new System.NotImplementedException();
	public virtual System.IntPtr Buffer
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
