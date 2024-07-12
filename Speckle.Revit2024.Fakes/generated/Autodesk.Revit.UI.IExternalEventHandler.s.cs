namespace Autodesk.Revit.UI;

public partial interface IExternalEventHandler
{
  public void Execute(Autodesk.Revit.UI.UIApplication app);
  public System.String GetName();
}
