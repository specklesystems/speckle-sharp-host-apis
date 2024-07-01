namespace Autodesk.Revit.DB;

public partial class PhaseFilter : Autodesk.Revit.DB.Element
{
  public virtual Autodesk.Revit.DB.PhaseStatusPresentation GetPhaseStatusPresentation(
    Autodesk.Revit.DB.ElementOnPhaseStatus status
  ) => throw new System.NotImplementedException();

  public virtual void SetPhaseStatusPresentation(
    Autodesk.Revit.DB.ElementOnPhaseStatus status,
    Autodesk.Revit.DB.PhaseStatusPresentation presentation
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.PhaseFilter Create(Autodesk.Revit.DB.Document document, System.String name) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsDefault
  {
    get => throw new System.NotImplementedException();
  }
}
