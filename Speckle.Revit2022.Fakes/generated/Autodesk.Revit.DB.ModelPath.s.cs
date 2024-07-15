namespace Autodesk.Revit.DB;

public partial class ModelPath : System.IDisposable
{
	public ModelPath() {}
	public virtual System.Int32 Compare(Autodesk.Revit.DB.ModelPath otherPath) => throw new System.NotImplementedException();
	public virtual System.Guid GetProjectGUID() => throw new System.NotImplementedException();
	public virtual System.Guid GetModelGUID() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String Region
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean CloudPath
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean ServerPath
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Empty
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String CentralServerPath
	{
		get => throw new System.NotImplementedException();
	}
}
