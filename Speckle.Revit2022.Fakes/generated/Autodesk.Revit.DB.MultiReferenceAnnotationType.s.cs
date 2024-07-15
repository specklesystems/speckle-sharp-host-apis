namespace Autodesk.Revit.DB;

public partial class MultiReferenceAnnotationType : Autodesk.Revit.DB.ElementType
{
	public MultiReferenceAnnotationType() {}
	public static Autodesk.Revit.DB.MultiReferenceAnnotationType CreateDefault(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetAllowedTagCategory() => throw new System.NotImplementedException();
	public virtual System.Boolean IsAllowedTagType(Autodesk.Revit.DB.ElementId tagTypeId) => throw new System.NotImplementedException();
	public static System.Boolean IsAllowedTagCategory(Autodesk.Revit.DB.ElementId tagCategoryId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsAllowedReferenceCategory(Autodesk.Revit.DB.ElementId referenceCategoryId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsAllowedDimensionStyle(Autodesk.Revit.DB.ElementId dimensionStyleId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId DimensionStyleId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowDimensionText
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean GroupTagHeads
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId TagTypeId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId ReferenceCategoryId
	{
		get => throw new System.NotImplementedException();
	}
}
