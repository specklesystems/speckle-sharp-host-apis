namespace Rhino.Runtime;

public partial class NamedParametersEventArgs : System.EventArgs,System.IDisposable
{
	public NamedParametersEventArgs() {}
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual void Set(System.String name,System.String value) => throw new System.NotImplementedException();
	public virtual void Set(System.String name,System.Collections.Generic.IEnumerable<System.String> strings) => throw new System.NotImplementedException();
	public virtual void Set(System.String name,System.Boolean value) => throw new System.NotImplementedException();
	public virtual void Set(System.String name,System.Int32 value) => throw new System.NotImplementedException();
	public virtual void Set(System.String name,System.UInt32 value) => throw new System.NotImplementedException();
	public virtual void Set(System.String name,System.Double value) => throw new System.NotImplementedException();
	public virtual void Set(System.String name,Rhino.Geometry.Point3d value) => throw new System.NotImplementedException();
	public virtual void Set(System.String name,Rhino.Geometry.Vector3d value) => throw new System.NotImplementedException();
	public virtual void Set(System.String name,Rhino.Geometry.GeometryBase value) => throw new System.NotImplementedException();
	public virtual void Set(System.String name,System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> values) => throw new System.NotImplementedException();
	public virtual void SetWindowHandle(System.String name,System.IntPtr value) => throw new System.NotImplementedException();
}
