namespace Autodesk.Revit.DB;

public partial class FilledRegion : Autodesk.Revit.DB.Element
{
	public static Autodesk.Revit.DB.FilledRegion Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId typeId,Autodesk.Revit.DB.SketchPlane sketchPlane,IList<Autodesk.Revit.DB.CurveLoop> boundaries) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.FilledRegion Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId typeId,Autodesk.Revit.DB.ElementId viewId,IList<Autodesk.Revit.DB.CurveLoop> boundaries) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.CurveLoop> GetBoundaries() => throw new System.NotImplementedException();
	public virtual void SetLineStyleId(Autodesk.Revit.DB.ElementId lineStyleId) => throw new System.NotImplementedException();
	public static IList<Autodesk.Revit.DB.ElementId> GetValidLineStyleIdsForFilledRegion(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public static System.Boolean IsValidLineStyleIdForFilledRegion(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId lineStyleId) => throw new System.NotImplementedException();
	public static System.Boolean IsValidFilledRegionTypeId(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId typeId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsMasking
	{
		get => throw new System.NotImplementedException();
	}
}
