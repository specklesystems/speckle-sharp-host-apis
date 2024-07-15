namespace Autodesk.Revit.DB;

public partial interface ISaveSharedCoordinatesCallback
{
	public  Autodesk.Revit.DB.SaveModifiedLinksOptions GetSaveModifiedLinksOption(Autodesk.Revit.DB.RevitLinkType link);
}
