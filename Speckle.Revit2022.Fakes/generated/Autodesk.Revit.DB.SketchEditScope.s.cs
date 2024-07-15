namespace Autodesk.Revit.DB;

public partial class SketchEditScope : Autodesk.Revit.DB.EditScope
{
	public SketchEditScope() {}
	public SketchEditScope(Autodesk.Revit.DB.Document document,System.String transactionName) => throw new System.NotImplementedException();
	public virtual void Start(Autodesk.Revit.DB.ElementId sketchId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsSketchEditingSupported(Autodesk.Revit.DB.ElementId sketchId) => throw new System.NotImplementedException();
}
