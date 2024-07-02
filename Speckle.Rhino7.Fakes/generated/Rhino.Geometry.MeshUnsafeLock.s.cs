namespace Rhino.Geometry;

public partial class MeshUnsafeLock : System.IDisposable
{
	public MeshUnsafeLock() {}
	public virtual void Release() => throw new System.NotImplementedException();
}
