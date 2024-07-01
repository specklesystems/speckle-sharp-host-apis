namespace Autodesk.Revit.DB.ExternalService;

public partial interface IExternalService
{
	public  Autodesk.Revit.DB.ExternalService.ExternalServiceId GetServiceId();
	public  System.String GetName();
	public  System.String GetVendorId();
	public  System.String GetDescription();
	public  System.Boolean IsValidServer(Autodesk.Revit.DB.ExternalService.IExternalServer server);
	public  System.Boolean Execute(Autodesk.Revit.DB.ExternalService.IExternalServer server,Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ExternalService.IExternalData data);
	public  Autodesk.Revit.DB.ExternalService.DisparityResponse OnServersDisparity(Autodesk.Revit.DB.Document document,IList<System.Guid> oldServers);
	public  void OnServersChanged(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ExternalService.ServerChangeCause cause,IList<System.Guid> oldServers);
}
