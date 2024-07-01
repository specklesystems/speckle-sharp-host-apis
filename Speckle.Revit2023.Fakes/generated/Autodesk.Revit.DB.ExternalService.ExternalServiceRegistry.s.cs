namespace Autodesk.Revit.DB.ExternalService;

public partial class ExternalServiceRegistry
{
  public static System.Guid RegisterService(
    Autodesk.Revit.DB.ExternalService.ISingleServerService service,
    System.Guid defaultServerId,
    Autodesk.Revit.DB.ExternalService.ExternalServiceOptions options
  ) => throw new System.NotImplementedException();

  public static System.Guid RegisterService(
    Autodesk.Revit.DB.ExternalService.IMultiServerService service,
    Autodesk.Revit.DB.ExternalService.ExternalServiceOptions options,
    Autodesk.Revit.DB.ExternalService.ExecutionPolicy policy
  ) => throw new System.NotImplementedException();

  public static System.Guid RegisterService(
    Autodesk.Revit.DB.ExternalService.ISingleServerService service,
    Autodesk.Revit.DB.ExternalService.ExternalServiceOptions options
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ExternalService.ExternalService GetService(
    Autodesk.Revit.DB.ExternalService.ExternalServiceId serviceId
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<Autodesk.Revit.DB.ExternalService.ExternalService> GetServices() =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ExternalService.ExternalServiceResult ExecuteService(
    System.Guid executionKey,
    System.Guid serverId,
    Autodesk.Revit.DB.ExternalService.IExternalData data
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ExternalService.ExternalServiceResult ExecuteService(
    System.Guid executionKey,
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ExternalService.IExternalData data
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ExternalService.ExternalServiceResult ExecuteService(
    System.Guid executionKey,
    Autodesk.Revit.DB.ExternalService.IExternalData data
  ) => throw new System.NotImplementedException();
}
