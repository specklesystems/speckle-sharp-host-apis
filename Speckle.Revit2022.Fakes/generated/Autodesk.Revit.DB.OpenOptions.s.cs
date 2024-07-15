namespace Autodesk.Revit.DB;

public partial class OpenOptions : System.IDisposable
{
	public OpenOptions() {}
	public virtual Autodesk.Revit.DB.WorksetConfiguration GetOpenWorksetsConfiguration() => throw new System.NotImplementedException();
	public virtual void SetOpenWorksetsConfiguration(Autodesk.Revit.DB.WorksetConfiguration openConfiguration) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.OpenForeignOption OpenForeignOption
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean AllowOpeningLocalByWrongUser
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean Audit
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IgnoreExtensibleStorageSchemaConflict
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.DetachFromCentralOption DetachFromCentralOption
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
