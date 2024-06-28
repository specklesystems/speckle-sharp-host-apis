namespace Autodesk.Revit.DB;

public partial class ViewSection : Autodesk.Revit.DB.View
{
	public static Autodesk.Revit.DB.ViewSection CreateSection(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId viewFamilyTypeId,Autodesk.Revit.DB.BoundingBoxXYZ sectionBox) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ViewSection CreateDetail(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId viewFamilyTypeId,Autodesk.Revit.DB.BoundingBoxXYZ sectionBox) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.View CreateCallout(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId parentViewId,Autodesk.Revit.DB.ElementId viewFamilyTypeId,Autodesk.Revit.DB.XYZ point1,Autodesk.Revit.DB.XYZ point2) => throw new System.NotImplementedException();
	public static System.Boolean IsParentViewValidForCallout(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId parentViewId) => throw new System.NotImplementedException();
	public static System.Boolean IsViewFamilyTypeValidForCallout(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId viewFamilyTypeId,Autodesk.Revit.DB.ElementId parentViewId) => throw new System.NotImplementedException();
	public static void CreateReferenceCallout(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId parentViewId,Autodesk.Revit.DB.ElementId viewIdToReference,Autodesk.Revit.DB.XYZ point1,Autodesk.Revit.DB.XYZ point2) => throw new System.NotImplementedException();
	public static void CreateReferenceSection(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId parentViewId,Autodesk.Revit.DB.ElementId viewIdToReference,Autodesk.Revit.DB.XYZ headPoint,Autodesk.Revit.DB.XYZ tailPoint) => throw new System.NotImplementedException();
	public virtual System.Boolean IsSplitSection() => throw new System.NotImplementedException();
}
