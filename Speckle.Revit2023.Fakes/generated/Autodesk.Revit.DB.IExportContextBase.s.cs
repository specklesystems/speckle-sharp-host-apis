namespace Autodesk.Revit.DB;

public partial class IExportContextBase
{
	public virtual Autodesk.Revit.DB.RenderNodeAction OnCurve(Autodesk.Revit.DB.CurveNode node) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.RenderNodeAction OnPolyline(Autodesk.Revit.DB.PolylineNode node) => throw new System.NotImplementedException();
	public virtual void OnLineSegment(Autodesk.Revit.DB.LineSegment segment) => throw new System.NotImplementedException();
	public virtual void OnPolylineSegments(Autodesk.Revit.DB.PolylineSegments segments) => throw new System.NotImplementedException();
	public virtual void OnText(Autodesk.Revit.DB.TextNode node) => throw new System.NotImplementedException();
}
