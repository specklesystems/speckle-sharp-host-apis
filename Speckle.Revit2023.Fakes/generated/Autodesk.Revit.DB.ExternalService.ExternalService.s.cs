namespace Autodesk.Revit.DB.ExternalService;

public partial class ExternalService : System.IDisposable
{
  public virtual Autodesk.Revit.DB.ExternalService.ExternalServiceOptions GetOptions() =>
    throw new System.NotImplementedException();

  public virtual System.Guid GetPublicAccessKey() => throw new System.NotImplementedException();

  public virtual void AddServer(Autodesk.Revit.DB.ExternalService.IExternalServer server) =>
    throw new System.NotImplementedException();

  public virtual void RemoveServer(System.Guid serverId) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ExternalService.IExternalServer GetServer(System.Guid serverId) =>
    throw new System.NotImplementedException();

  public virtual System.Guid GetDefaultServerId() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Guid> GetRegisteredServerIds() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsRegisteredServerId(System.Guid serverId) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 NumberOfServers
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsSerializable
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String VendorId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Description
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Name
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ExternalService.ExternalServiceId ServiceId
  {
    get => throw new System.NotImplementedException();
  }
}
