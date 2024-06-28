namespace Autodesk.Revit.DB;

public partial class Form : Autodesk.Revit.DB.GenericForm
{
	public virtual Autodesk.Revit.DB.ReferenceArray GetControlPoints(Autodesk.Revit.DB.Reference curveOrEdgeOrFaceReference) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ReferenceArray GetCurvesAndEdgesReference(Autodesk.Revit.DB.Reference pointReference) => throw new System.NotImplementedException();
	public virtual void DeleteSubElement(Autodesk.Revit.DB.Reference subElementReference) => throw new System.NotImplementedException();
	public virtual void MoveSubElement(Autodesk.Revit.DB.Reference subElementReference,Autodesk.Revit.DB.XYZ offset) => throw new System.NotImplementedException();
	public virtual void AddEdge(Autodesk.Revit.DB.Reference startPointReference,Autodesk.Revit.DB.Reference endPointReference) => throw new System.NotImplementedException();
	public virtual void AddEdge(Autodesk.Revit.DB.Reference faceReference,Autodesk.Revit.DB.XYZ point) => throw new System.NotImplementedException();
	public virtual void Rehost(Autodesk.Revit.DB.SketchPlane sketchPlane,Autodesk.Revit.DB.XYZ location) => throw new System.NotImplementedException();
	public virtual void Rehost(Autodesk.Revit.DB.Reference hostRef,Autodesk.Revit.DB.XYZ location) => throw new System.NotImplementedException();
}
