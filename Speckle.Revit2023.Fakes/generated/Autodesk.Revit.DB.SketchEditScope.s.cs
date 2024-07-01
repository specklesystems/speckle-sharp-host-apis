namespace Autodesk.Revit.DB;

public partial class SketchEditScope : Autodesk.Revit.DB.EditScope
{
  public SketchEditScope(Autodesk.Revit.DB.Document document, System.String transactionName) =>
    throw new System.NotImplementedException();

  public virtual void Start(Autodesk.Revit.DB.ElementId sketchId) => throw new System.NotImplementedException();

  public virtual void StartWithNewSketch(Autodesk.Revit.DB.ElementId elementId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsSketchEditingSupported(Autodesk.Revit.DB.ElementId sketchId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsElementWithoutSketch(Autodesk.Revit.DB.ElementId elementId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsSketchEditingSupportedForSketchBasedElement(Autodesk.Revit.DB.ElementId elemId) =>
    throw new System.NotImplementedException();
}
