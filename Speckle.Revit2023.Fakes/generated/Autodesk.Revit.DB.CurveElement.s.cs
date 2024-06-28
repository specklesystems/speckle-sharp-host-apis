namespace Autodesk.Revit.DB;

public partial class CurveElement : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.Curve get_GeometryCurve() => throw new System.NotImplementedException();
	public virtual void set_GeometryCurve(Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference get_CenterPointReference() => throw new System.NotImplementedException();
			public virtual void SetSketchPlaneAndCurve(Autodesk.Revit.DB.SketchPlane sketchPlane,Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Element get_LineStyle() => throw new System.NotImplementedException();
	public virtual void set_LineStyle(Autodesk.Revit.DB.Element lineStyle) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CurveElementType get_CurveElementType() => throw new System.NotImplementedException();
}
