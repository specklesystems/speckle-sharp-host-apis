namespace Autodesk.Revit.DB;

public partial interface IExportContextBase
{
  public Autodesk.Revit.DB.RenderNodeAction OnCurve(Autodesk.Revit.DB.CurveNode node);
  public Autodesk.Revit.DB.RenderNodeAction OnPolyline(Autodesk.Revit.DB.PolylineNode node);
  public void OnLineSegment(Autodesk.Revit.DB.LineSegment segment);
  public void OnPolylineSegments(Autodesk.Revit.DB.PolylineSegments segments);
  public void OnText(Autodesk.Revit.DB.TextNode node);
}
