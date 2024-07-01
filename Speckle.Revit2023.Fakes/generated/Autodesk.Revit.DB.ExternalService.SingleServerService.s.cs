namespace Autodesk.Revit.DB.ExternalService;

public partial class SingleServerService : Autodesk.Revit.DB.ExternalService.ExternalService
{
	public virtual System.Guid GetActiveServerId(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public virtual System.Guid GetActiveServerId() => throw new System.NotImplementedException();
	public virtual void SetActiveServer(System.Guid serverId,Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public virtual void SetActiveServer(System.Guid serverId) => throw new System.NotImplementedException();
	public virtual void UnsetActiveServer(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
}
