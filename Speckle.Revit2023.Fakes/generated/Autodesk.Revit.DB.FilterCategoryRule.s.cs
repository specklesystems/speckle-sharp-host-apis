namespace Autodesk.Revit.DB;

public partial class FilterCategoryRule : Autodesk.Revit.DB.FilterRule
{
  public FilterCategoryRule(System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> categories) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetCategories() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetCategories(
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> categories
  ) => throw new System.NotImplementedException();

  public static System.Boolean AllCategoriesFilterable(
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> categories
  ) => throw new System.NotImplementedException();
}
