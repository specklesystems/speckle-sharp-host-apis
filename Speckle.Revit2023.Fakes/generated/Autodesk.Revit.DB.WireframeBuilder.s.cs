namespace Autodesk.Revit.DB;

public partial class WireframeBuilder : Autodesk.Revit.DB.ShapeBuilder
{
	public virtual void Reset() => throw new System.NotImplementedException();
	public virtual void AddPoint(Autodesk.Revit.DB.Point GPoint) => throw new System.NotImplementedException();
	public virtual void AddCurve(Autodesk.Revit.DB.Curve GCurve) => throw new System.NotImplementedException();
	public static System.Boolean ValidatePoint(Autodesk.Revit.DB.Point GPoint) => throw new System.NotImplementedException();
	public static System.Boolean ValidateCurve(Autodesk.Revit.DB.Curve GCurve) => throw new System.NotImplementedException();
}
