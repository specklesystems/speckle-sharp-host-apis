namespace Autodesk.Revit.DB;

public partial class CurveElement : Autodesk.Revit.DB.Element
{
	public virtual void SetSketchPlaneAndCurve(Autodesk.Revit.DB.SketchPlane sketchPlane,Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CurveElementType CurveElementType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Element LineStyle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.SketchPlane SketchPlane
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Reference CenterPointReference
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Curve GeometryCurve
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
