namespace Autodesk.Revit.DB;

public partial class NurbSpline : Autodesk.Revit.DB.Curve
{
	public virtual Autodesk.Revit.DB.DoubleArray Knots
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.DoubleArray Weights
	{
		get => throw new System.NotImplementedException();
	}
}
