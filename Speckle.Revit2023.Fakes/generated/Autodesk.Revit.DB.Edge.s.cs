namespace Autodesk.Revit.DB;

public partial class Edge : Autodesk.Revit.DB.GeometryObject
{
	public virtual Autodesk.Revit.DB.Curve AsCurve() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve AsCurveFollowingFace(Autodesk.Revit.DB.Face faceForDir) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference get_Reference() => throw new System.NotImplementedException();
}
