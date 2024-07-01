namespace Autodesk.Revit.DB.Mechanical;

public partial class Duct : Autodesk.Revit.DB.MEPCurve
{
	public static Autodesk.Revit.DB.Mechanical.Duct Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId ductTypeId,Autodesk.Revit.DB.ElementId levelId,Autodesk.Revit.DB.Connector startConnector,Autodesk.Revit.DB.Connector endConnector) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Mechanical.Duct Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId ductTypeId,Autodesk.Revit.DB.ElementId levelId,Autodesk.Revit.DB.Connector startConnector,Autodesk.Revit.DB.XYZ endPoint) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Mechanical.Duct Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId systemTypeId,Autodesk.Revit.DB.ElementId ductTypeId,Autodesk.Revit.DB.ElementId levelId,Autodesk.Revit.DB.XYZ startPoint,Autodesk.Revit.DB.XYZ endPoint) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Mechanical.Duct CreatePlaceholder(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId systemTypeId,Autodesk.Revit.DB.ElementId ductTypeId,Autodesk.Revit.DB.ElementId levelId,Autodesk.Revit.DB.XYZ startPoint,Autodesk.Revit.DB.XYZ endPoint) => throw new System.NotImplementedException();
	public virtual void SetSystemType(Autodesk.Revit.DB.ElementId systemTypeId) => throw new System.NotImplementedException();
	public static System.Boolean IsHvacSystemTypeId(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId systemTypeId) => throw new System.NotImplementedException();
	public static System.Boolean IsDuctTypeId(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId ductTypeId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsPlaceholder
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Mechanical.DuctType DuctType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
