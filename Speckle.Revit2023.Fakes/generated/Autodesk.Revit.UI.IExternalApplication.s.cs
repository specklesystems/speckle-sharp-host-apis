namespace Autodesk.Revit.UI;

public partial interface IExternalApplication
{
  public Autodesk.Revit.UI.Result OnStartup(Autodesk.Revit.UI.UIControlledApplication application);
  public Autodesk.Revit.UI.Result OnShutdown(Autodesk.Revit.UI.UIControlledApplication application);
}
