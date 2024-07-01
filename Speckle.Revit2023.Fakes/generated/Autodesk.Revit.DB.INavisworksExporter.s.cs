namespace Autodesk.Revit.DB;

public partial interface INavisworksExporter
{
  public void Export(
    Autodesk.Revit.DB.Document document,
    System.String folder,
    System.String name,
    Autodesk.Revit.DB.NavisworksExportOptions options
  );
}
