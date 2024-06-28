namespace Autodesk.Revit.DB;

public partial class PointOnEdgeFaceIntersection : Autodesk.Revit.DB.PointElementReference
{
	public virtual Autodesk.Revit.DB.Reference GetEdgeReference() => throw new System.NotImplementedException();
	public virtual void SetEdgeReference(Autodesk.Revit.DB.Reference edgeReference) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference GetFaceReference() => throw new System.NotImplementedException();
	public virtual void SetFaceReference(Autodesk.Revit.DB.Reference reference) => throw new System.NotImplementedException();
}
