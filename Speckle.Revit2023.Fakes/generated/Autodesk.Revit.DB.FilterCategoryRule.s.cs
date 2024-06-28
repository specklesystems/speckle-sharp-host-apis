namespace Autodesk.Revit.DB;

public partial class FilterCategoryRule : Autodesk.Revit.DB.FilterRule
{
	public virtual ICollection<Autodesk.Revit.DB.ElementId> GetCategories() => throw new System.NotImplementedException();
	public virtual System.Boolean SetCategories(ICollection<Autodesk.Revit.DB.ElementId> categories) => throw new System.NotImplementedException();
	public static System.Boolean AllCategoriesFilterable(ICollection<Autodesk.Revit.DB.ElementId> categories) => throw new System.NotImplementedException();
}
