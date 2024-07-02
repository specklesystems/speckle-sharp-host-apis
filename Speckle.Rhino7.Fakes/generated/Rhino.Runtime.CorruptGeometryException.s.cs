namespace Rhino.Runtime;

public partial class CorruptGeometryException : System.Exception
{
	public CorruptGeometryException() {}
	public virtual System.IntPtr Pointer
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Runtime.CommonObject CommonObject
	{
		get => throw new System.NotImplementedException();
	}
}
