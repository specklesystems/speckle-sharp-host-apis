namespace Autodesk.Revit.DB.ExternalService;

public partial class MultiServerService : Autodesk.Revit.DB.ExternalService.ExternalService
{
  public MultiServerService() { }

  public virtual System.Collections.Generic.IList<System.Guid> GetActiveServerIds(
    Autodesk.Revit.DB.Document document
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Guid> GetActiveServerIds() =>
    throw new System.NotImplementedException();

  public virtual void SetActiveServers(
    System.Collections.Generic.IList<System.Guid> serverIds,
    Autodesk.Revit.DB.Document document
  ) => throw new System.NotImplementedException();

  public virtual void SetActiveServers(System.Collections.Generic.IList<System.Guid> serverIds) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetServerState(
    System.Guid serverId,
    Autodesk.Revit.DB.Document document,
    System.Boolean bActive
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ExternalService.ExecutionPolicy ExecutionPolicy
  {
    get => throw new System.NotImplementedException();
  }
}
