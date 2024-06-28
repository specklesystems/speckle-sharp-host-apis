namespace Autodesk.Revit.DB;

public partial class Plane : Autodesk.Revit.DB.Surface
{
	public static Autodesk.Revit.DB.Plane Create(Autodesk.Revit.DB.Frame frameOfReference) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Plane CreateByThreePoints(Autodesk.Revit.DB.XYZ point1,Autodesk.Revit.DB.XYZ point2,Autodesk.Revit.DB.XYZ point3) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Plane CreateByNormalAndOrigin(Autodesk.Revit.DB.XYZ normal,Autodesk.Revit.DB.XYZ origin) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Plane CreateByOriginAndBasis(Autodesk.Revit.DB.XYZ origin,Autodesk.Revit.DB.XYZ basisX,Autodesk.Revit.DB.XYZ basisY) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ YVec
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ XVec
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ Origin
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ Normal
	{
		get => throw new System.NotImplementedException();
	}
}
