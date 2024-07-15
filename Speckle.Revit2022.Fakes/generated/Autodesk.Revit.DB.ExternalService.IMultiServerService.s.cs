namespace Autodesk.Revit.DB.ExternalService;

public partial interface IMultiServerService
{
	public  System.Boolean CanExecute(Autodesk.Revit.DB.ExternalService.IExternalServer server,Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ExternalService.IExternalData data);
}
