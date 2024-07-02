namespace Rhino.Render;

public partial class MetaDataProxy : System.IDisposable
{
	public MetaDataProxy() {}
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual void SetContentInstanceId(System.Guid uuid) => throw new System.NotImplementedException();
	public virtual System.IntPtr CppPointer
	{
		get => throw new System.NotImplementedException();
	}
}
