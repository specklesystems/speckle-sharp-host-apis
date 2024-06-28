namespace Autodesk.Revit.DB;

public partial class IExportContext2D
{
	public virtual Autodesk.Revit.DB.RenderNodeAction OnElementBegin2D(Autodesk.Revit.DB.ElementNode node) => throw new System.NotImplementedException();
	public virtual void OnElementEnd2D(Autodesk.Revit.DB.ElementNode node) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.RenderNodeAction OnFaceEdge2D(Autodesk.Revit.DB.FaceEdgeNode node) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.RenderNodeAction OnFaceSilhouette2D(Autodesk.Revit.DB.FaceSilhouetteNode node) => throw new System.NotImplementedException();
}
