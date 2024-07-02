namespace Rhino.Geometry;

public partial class PointCloudUnsafeLock : System.IDisposable
{
	public PointCloudUnsafeLock() {}
	public virtual void Release() => throw new System.NotImplementedException();
	void System.IDisposable.Dispose() => throw new System.NotImplementedException();
}
