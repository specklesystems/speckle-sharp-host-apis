namespace Rhino.Display;

public partial class VisualAnalysisMode
{
  public VisualAnalysisMode() { }

  public static System.Boolean AdjustAnalysisMeshes(Rhino.RhinoDoc doc, System.Guid analysisModeId) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.VisualAnalysisMode Register(System.Type customAnalysisModeType) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.VisualAnalysisMode Find(System.Guid id) => throw new System.NotImplementedException();

  public static Rhino.Display.VisualAnalysisMode Find(System.Type t) => throw new System.NotImplementedException();

  public virtual void EnableUserInterface(System.Boolean on) => throw new System.NotImplementedException();

  public virtual System.Boolean ObjectSupportsAnalysisMode(Rhino.DocObjects.RhinoObject obj) =>
    throw new System.NotImplementedException();

  public static System.Guid RhinoEdgeAnalysisModeId
  {
    get => throw new System.NotImplementedException();
  }
  public static System.Guid RhinoCurvatureGraphAnalysisModeId
  {
    get => throw new System.NotImplementedException();
  }
  public static System.Guid RhinoZebraStripeAnalysisModeId
  {
    get => throw new System.NotImplementedException();
  }
  public static System.Guid RhinoEmapAnalysisModeId
  {
    get => throw new System.NotImplementedException();
  }
  public static System.Guid RhinoCurvatureColorAnalyisModeId
  {
    get => throw new System.NotImplementedException();
  }
  public static System.Guid RhinoDraftAngleAnalysisModeId
  {
    get => throw new System.NotImplementedException();
  }
  public static System.Guid RhinoThicknessAnalysisModeId
  {
    get => throw new System.NotImplementedException();
  }
  public static System.Guid RhinoEdgeContinuityAlalysisModeId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Name
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Display.VisualAnalysisMode.AnalysisStyle Style
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Guid Id
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean ShowIsoCurves
  {
    get => throw new System.NotImplementedException();
  }
}
