namespace Autodesk.Revit.DB;

public partial class NurbSpline : Autodesk.Revit.DB.Curve
{
	public virtual Autodesk.Revit.DB.DoubleArray get_Weights() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DoubleArray get_Knots() => throw new System.NotImplementedException();
	public virtual void set_Knots(Autodesk.Revit.DB.DoubleArray knots) => throw new System.NotImplementedException();
}
