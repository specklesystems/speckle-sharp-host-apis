namespace Autodesk.Revit.DB;

public partial class Solid : Autodesk.Revit.DB.GeometryObject
{
	public Solid() {}
	public virtual Autodesk.Revit.DB.XYZ ComputeCentroid() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SolidCurveIntersection IntersectWithCurve(Autodesk.Revit.DB.Curve curve,Autodesk.Revit.DB.SolidCurveIntersectionOptions options) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.BoundingBoxXYZ GetBoundingBox() => throw new System.NotImplementedException();
	public virtual System.Double Volume
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double SurfaceArea
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.FaceArray Faces
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.EdgeArray Edges
	{
		get => throw new System.NotImplementedException();
	}
}
