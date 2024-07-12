namespace Autodesk.Revit.DB;

public partial interface IPerformanceAdviserRule
{
  public void InitCheck(Autodesk.Revit.DB.Document document);
  public void FinalizeCheck(Autodesk.Revit.DB.Document document);
  public void ExecuteElementCheck(Autodesk.Revit.DB.Document document, Autodesk.Revit.DB.Element element);
  public System.Boolean WillCheckElements();
  public Autodesk.Revit.DB.ElementFilter GetElementFilter(Autodesk.Revit.DB.Document document);
  public System.String GetName();
  public System.String GetDescription();
}
