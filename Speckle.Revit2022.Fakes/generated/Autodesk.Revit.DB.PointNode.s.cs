namespace Autodesk.Revit.DB;

public partial class PointNode : Autodesk.Revit.DB.ModelCurveNode
{
	public PointNode() {}
	public virtual Autodesk.Revit.DB.Point GetPoint() => throw new System.NotImplementedException();
}
