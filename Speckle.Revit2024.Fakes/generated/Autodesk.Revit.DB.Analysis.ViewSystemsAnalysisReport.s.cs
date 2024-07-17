namespace Autodesk.Revit.DB.Analysis;

public partial class ViewSystemsAnalysisReport : Autodesk.Revit.DB.View
{
  public ViewSystemsAnalysisReport() { }

  public static Autodesk.Revit.DB.Analysis.ViewSystemsAnalysisReport Create(
    Autodesk.Revit.DB.Document document,
    System.String viewName
  ) => throw new System.NotImplementedException();

  public virtual void RequestSystemsAnalysis(Autodesk.Revit.DB.Analysis.SystemsAnalysisOptions options) =>
    throw new System.NotImplementedException();

  public static void CancelSystemsAnalysis(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId reportElement
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ElementId GetLatestSystemsAnalysisReport(Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsAnalysisCompleted() => throw new System.NotImplementedException();

  public virtual System.String GetReportContent() => throw new System.NotImplementedException();

  public virtual System.DateTime AnalysisDateAndTime
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Analysis.SystemsAnalysisReportStyle ReportStyle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String SystemsAnalysisOutputFolder
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String WeatherFile
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String SystemsAnalysisWorkflowFile
  {
    get => throw new System.NotImplementedException();
  }
}
