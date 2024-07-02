namespace Autodesk.Revit.DB.ExternalService;

public partial interface IExternalServer
{
	public  System.Guid GetServerId();
	public  Autodesk.Revit.DB.ExternalService.ExternalServiceId GetServiceId();
	public  System.String GetName();
	public  System.String GetVendorId();
	public  System.String GetDescription();
}
