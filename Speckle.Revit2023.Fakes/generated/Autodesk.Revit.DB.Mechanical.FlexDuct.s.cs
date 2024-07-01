namespace Autodesk.Revit.DB.Mechanical;

public partial class FlexDuct : Autodesk.Revit.DB.MEPCurve
{
	public static Autodesk.Revit.DB.Mechanical.FlexDuct Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId systemTypeId,Autodesk.Revit.DB.ElementId ductTypeId,Autodesk.Revit.DB.ElementId levelId,Autodesk.Revit.DB.XYZ startTangent,Autodesk.Revit.DB.XYZ endTangent,System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> points) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Mechanical.FlexDuct Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId systemTypeId,Autodesk.Revit.DB.ElementId ductTypeId,Autodesk.Revit.DB.ElementId levelId,System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> points) => throw new System.NotImplementedException();
	public static System.Boolean IsFlexDuctTypeId(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId ductTypeId) => throw new System.NotImplementedException();
	public static System.Boolean IsHVACSystemTypeId(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId systemTypeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ EndTangent
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.XYZ StartTangent
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Mechanical.FlexDuctType FlexDuctType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> Points
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
