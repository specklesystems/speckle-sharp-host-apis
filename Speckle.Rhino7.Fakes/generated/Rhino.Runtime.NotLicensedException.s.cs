namespace Rhino.Runtime;

public partial class NotLicensedException : System.Exception
{
	public NotLicensedException() {}
	public NotLicensedException(System.String message) => throw new System.NotImplementedException();
	public NotLicensedException(System.String message,System.Exception inner) => throw new System.NotImplementedException();
}
