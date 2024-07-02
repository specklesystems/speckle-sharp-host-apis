namespace Autodesk.Revit.DB;

public partial interface IOpenFromCloudCallback
{
	public  Autodesk.Revit.DB.OpenConflictResult OnOpenConflict(Autodesk.Revit.DB.OpenConflictScenario scenario);
}
