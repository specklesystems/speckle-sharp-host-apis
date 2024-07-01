namespace Autodesk.Revit.DB;

public partial class Categories : Autodesk.Revit.DB.CategoryNameMap
{
	public virtual Autodesk.Revit.DB.Category get_Item(Autodesk.Revit.DB.BuiltInCategory categoryId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Category NewSubcategory(Autodesk.Revit.DB.Category parentCategory,System.String name) => throw new System.NotImplementedException();
	public new System.Boolean IsEmpty
	{
		get => throw new System.NotImplementedException();
	}
	public new System.Int32 Size
	{
		get => throw new System.NotImplementedException();
	}
}
