namespace Autodesk.Revit.DB.Structure;

public partial class AnalyticalSurfaceBase : Autodesk.Revit.DB.Structure.AnalyticalElement
{
	public virtual Autodesk.Revit.DB.CurveLoop GetOuterContour() => throw new System.NotImplementedException();
	public virtual void SetOuterContour(Autodesk.Revit.DB.CurveLoop outerContour) => throw new System.NotImplementedException();
	public static System.Boolean IsCurveLoopValid(Autodesk.Revit.DB.CurveLoop profile) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId SketchId
	{
		get => throw new System.NotImplementedException();
	}
}
