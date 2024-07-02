namespace Autodesk.Revit.DB;

public partial class APIObject : System.IDisposable
{
	public APIObject() {}
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsReadOnly
	{
		get => throw new System.NotImplementedException();
	}
}
