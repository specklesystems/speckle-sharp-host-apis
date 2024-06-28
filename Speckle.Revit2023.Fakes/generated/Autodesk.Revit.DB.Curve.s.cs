namespace Autodesk.Revit.DB;

public partial class Curve : Autodesk.Revit.DB.GeometryObject
{
	public virtual void MakeUnbound() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve CreateTransformed(Autodesk.Revit.DB.Transform transform) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve CreateReversed() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SetComparisonResult Intersect(Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.IntersectionResult Project(Autodesk.Revit.DB.XYZ point) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve Clone() => throw new System.NotImplementedException();
	public virtual void SetGraphicsStyleId(Autodesk.Revit.DB.ElementId id) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference Reference
	{
		get => throw new System.NotImplementedException();
	}
}
