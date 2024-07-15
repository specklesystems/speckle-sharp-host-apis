namespace Autodesk.Revit.Exceptions;

public partial class ApplicationException : System.Exception
{
	public ApplicationException() {}
	public virtual Autodesk.Revit.Exceptions.FunctionId FunctionId
	{
		get => throw new System.NotImplementedException();
	}
}
