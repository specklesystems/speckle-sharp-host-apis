namespace Autodesk.Revit.DB;

public partial interface IExportContext2D
{
	public  Autodesk.Revit.DB.RenderNodeAction OnElementBegin2D(Autodesk.Revit.DB.ElementNode node);
	public  void OnElementEnd2D(Autodesk.Revit.DB.ElementNode node);
	public  Autodesk.Revit.DB.RenderNodeAction OnFaceEdge2D(Autodesk.Revit.DB.FaceEdgeNode node);
	public  Autodesk.Revit.DB.RenderNodeAction OnFaceSilhouette2D(Autodesk.Revit.DB.FaceSilhouetteNode node);
}
