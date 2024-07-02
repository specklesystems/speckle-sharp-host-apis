namespace Autodesk.Revit.DB;

public partial class Arc : Autodesk.Revit.DB.Curve
{
	public Arc() {}
	public static Autodesk.Revit.DB.Arc Create(Autodesk.Revit.DB.XYZ end0,Autodesk.Revit.DB.XYZ end1,Autodesk.Revit.DB.XYZ pointOnArc) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Arc Create(Autodesk.Revit.DB.Plane plane,System.Double radius,System.Double startAngle,System.Double endAngle) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Arc Create(Autodesk.Revit.DB.XYZ center,System.Double radius,System.Double startAngle,System.Double endAngle,Autodesk.Revit.DB.XYZ xAxis,Autodesk.Revit.DB.XYZ yAxis) => throw new System.NotImplementedException();
	public virtual System.Double Radius
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ YDirection
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ XDirection
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ Normal
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ Center
	{
		get => throw new System.NotImplementedException();
	}
}
