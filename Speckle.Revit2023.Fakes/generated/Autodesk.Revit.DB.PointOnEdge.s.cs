namespace Autodesk.Revit.DB;

public partial class PointOnEdge : Autodesk.Revit.DB.PointElementReference
{
	public PointOnEdge() {}
	public virtual Autodesk.Revit.DB.Reference GetEdgeReference() => throw new System.NotImplementedException();
	public virtual void SetEdgeReference(Autodesk.Revit.DB.Reference reference) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.PointLocationOnCurve LocationOnCurve
	{
		get => throw new System.NotImplementedException();
	}
}
