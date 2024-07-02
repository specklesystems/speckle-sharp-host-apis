namespace Autodesk.Revit.DB;

public partial class CurveNode : Autodesk.Revit.DB.ModelCurveNode
{
	public CurveNode() {}
	public virtual Autodesk.Revit.DB.Curve GetCurve() => throw new System.NotImplementedException();
}
