namespace Autodesk.Revit.DB;

public partial class NurbSpline : Autodesk.Revit.DB.Curve
{
	public NurbSpline() {}
	public virtual void SetControlPointsAndWeights(System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> ctrlPoints,Autodesk.Revit.DB.DoubleArray weights) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Curve CreateCurve(Autodesk.Revit.DB.HermiteSpline hermiteSpline) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Curve CreateCurve(System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> controlPoints,System.Collections.Generic.IList<System.Double> weights) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Curve CreateCurve(System.Int32 degree,System.Collections.Generic.IList<System.Double> knots,System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> controlPoints,System.Collections.Generic.IList<System.Double> weights) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Curve CreateCurve(System.Int32 degree,System.Collections.Generic.IList<System.Double> knots,System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> controlPoints) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.NurbSpline Create(Autodesk.Revit.DB.HermiteSpline hermiteSpline) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DoubleArray Knots
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.DoubleArray Weights
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> CtrlPoints
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 Degree
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean isRational
	{
		get => throw new System.NotImplementedException();
	}
}
