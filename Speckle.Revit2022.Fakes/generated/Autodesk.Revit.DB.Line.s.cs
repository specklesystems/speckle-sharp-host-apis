namespace Autodesk.Revit.DB;

public partial class Line : Autodesk.Revit.DB.Curve
{
	public Line() {}
	public static Autodesk.Revit.DB.Line CreateBound(Autodesk.Revit.DB.XYZ endpoint1,Autodesk.Revit.DB.XYZ endpoint2) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Line CreateUnbound(Autodesk.Revit.DB.XYZ origin,Autodesk.Revit.DB.XYZ direction) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ Direction
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ Origin
	{
		get => throw new System.NotImplementedException();
	}
}
