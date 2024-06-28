namespace Autodesk.Revit.DB;

public partial class SketchEditScope : Autodesk.Revit.DB.EditScope
{
	public virtual void Start(Autodesk.Revit.DB.ElementId sketchId) => throw new System.NotImplementedException();
	public virtual void StartWithNewSketch(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
}
