namespace Autodesk.Revit.DB;

public partial class ConfigurationReloadInfo : System.IDisposable
{
	public ConfigurationReloadInfo() => throw new System.NotImplementedException();
	public virtual ISet<Autodesk.Revit.DB.ElementId> GetCustomDataChangedElements() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ConnectionValidationInfo GetConnectivityValidation() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ReloadSwapOutInfo GetOutOfDatePartStatus(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 OutOfDatePartCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean ProfileNotAvailable
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 Disconnects
	{
		get => throw new System.NotImplementedException();
	}
}
