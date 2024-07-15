namespace Autodesk.Revit.DB.Electrical;

public partial class CableTray : Autodesk.Revit.DB.Electrical.CableTrayConduitBase
{
	public CableTray() {}
	public static Autodesk.Revit.DB.Electrical.CableTray Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId cabletrayType,Autodesk.Revit.DB.XYZ startPoint,Autodesk.Revit.DB.XYZ endPoint,Autodesk.Revit.DB.ElementId levelId) => throw new System.NotImplementedException();
	public static System.Boolean IsValidCableTrayType(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId cabletrayType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Electrical.CableTrayShape GetShapeType() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidRungSpace(System.Double rungSpace) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ CurveNormal
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double RungSpace
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
