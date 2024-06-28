namespace Autodesk.Revit.DB;

public partial class IUpdater
{
	public virtual void Execute(Autodesk.Revit.DB.UpdaterData data) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.UpdaterId GetUpdaterId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ChangePriority GetChangePriority() => throw new System.NotImplementedException();
	public virtual System.String GetUpdaterName() => throw new System.NotImplementedException();
	public virtual System.String GetAdditionalInformation() => throw new System.NotImplementedException();
}
