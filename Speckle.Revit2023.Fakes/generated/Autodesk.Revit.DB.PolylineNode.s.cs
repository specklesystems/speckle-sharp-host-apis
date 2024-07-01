namespace Autodesk.Revit.DB;

public partial class PolylineNode : Autodesk.Revit.DB.ModelCurveNode
{
  public PolylineNode() { }

  public virtual Autodesk.Revit.DB.PolyLine GetPolyline() => throw new System.NotImplementedException();
}
