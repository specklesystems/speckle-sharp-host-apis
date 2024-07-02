namespace Autodesk.Revit.DB;

public partial class MultiReferenceAnnotation : Autodesk.Revit.DB.Element
{
	public MultiReferenceAnnotation() {}
	public static Autodesk.Revit.DB.MultiReferenceAnnotation Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId ownerViewId,Autodesk.Revit.DB.MultiReferenceAnnotationOptions options) => throw new System.NotImplementedException();
	public static System.Boolean IsLinearFixedDimensionDirectionValid(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId viewId,Autodesk.Revit.DB.MultiReferenceAnnotationOptions options) => throw new System.NotImplementedException();
	public static System.Boolean AreElementsValidForMultiReferenceAnnotation(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.MultiReferenceAnnotationOptions options) => throw new System.NotImplementedException();
	public static System.Boolean AreReferencesValidForLinearDimension(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId ownerViewId,Autodesk.Revit.DB.MultiReferenceAnnotationOptions options) => throw new System.NotImplementedException();
	public static System.Boolean AreReferencesValidForLinearFixedDimension(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId ownerViewId,Autodesk.Revit.DB.MultiReferenceAnnotationOptions options) => throw new System.NotImplementedException();
	public static System.Boolean Is3DViewValidForDimension(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId ownerViewId,Autodesk.Revit.DB.MultiReferenceAnnotationOptions options) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId TagId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId DimensionId
	{
		get => throw new System.NotImplementedException();
	}
}
