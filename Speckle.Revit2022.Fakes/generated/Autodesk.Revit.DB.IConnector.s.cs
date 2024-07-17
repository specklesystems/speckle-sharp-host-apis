namespace Autodesk.Revit.DB;

public partial interface IConnector
{
  public System.Double Radius { get; }
  public System.Double Height { get; }
  public System.Double Width { get; }
  public Autodesk.Revit.DB.ConnectorProfileType Shape { get; }
  public Autodesk.Revit.DB.Domain Domain { get; }
  public Autodesk.Revit.DB.XYZ Origin { get; }
  public Autodesk.Revit.DB.Transform CoordinateSystem { get; }
}
