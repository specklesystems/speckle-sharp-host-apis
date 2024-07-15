namespace Autodesk.Revit.DB;

public partial interface IUpdater
{
	public  void Execute(Autodesk.Revit.DB.UpdaterData data);
	public  Autodesk.Revit.DB.UpdaterId GetUpdaterId();
	public  Autodesk.Revit.DB.ChangePriority GetChangePriority();
	public  System.String GetUpdaterName();
	public  System.String GetAdditionalInformation();
}
