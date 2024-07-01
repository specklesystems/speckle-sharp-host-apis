namespace Autodesk.Revit.DB;

public partial interface IDuplicateTypeNamesHandler
{
	public  Autodesk.Revit.DB.DuplicateTypeAction OnDuplicateTypeNamesFound(Autodesk.Revit.DB.DuplicateTypeNamesHandlerArgs args);
}
