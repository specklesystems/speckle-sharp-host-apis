namespace Autodesk.Revit.DB;

public partial class FabricationHostedInfo : System.IDisposable
{
  public virtual void PlaceOnHost(
    Autodesk.Revit.DB.ElementId hostId,
    Autodesk.Revit.DB.Connector hostConnector,
    System.Double distance,
    System.Double axisRotation
  ) => throw new System.NotImplementedException();

  public virtual void PlaceOnHost(
    Autodesk.Revit.DB.ElementId hostId,
    Autodesk.Revit.DB.Connector hostConnector,
    System.Double distance
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Line GetBearerCenterline() => throw new System.NotImplementedException();

  public virtual void DisconnectFromHost() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId HostId
  {
    get => throw new System.NotImplementedException();
  }
}
