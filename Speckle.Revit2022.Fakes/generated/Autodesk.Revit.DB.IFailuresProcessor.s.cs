namespace Autodesk.Revit.DB;

public partial interface IFailuresProcessor
{
  public Autodesk.Revit.DB.FailureProcessingResult ProcessFailures(Autodesk.Revit.DB.FailuresAccessor data);
  public void Dismiss(Autodesk.Revit.DB.Document document);
}
