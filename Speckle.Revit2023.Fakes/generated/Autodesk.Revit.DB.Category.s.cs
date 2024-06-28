namespace Autodesk.Revit.DB;

public partial class Category : Autodesk.Revit.DB.APIObject
{
	public virtual Autodesk.Revit.DB.ElementId GetLinePatternId(Autodesk.Revit.DB.GraphicsStyleType graphicsStyleType) => throw new System.NotImplementedException();
	public virtual void SetLinePatternId(Autodesk.Revit.DB.ElementId linePatternId,Autodesk.Revit.DB.GraphicsStyleType graphicsStyleType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GraphicsStyle GetGraphicsStyle(Autodesk.Revit.DB.GraphicsStyleType graphicsStyleType) => throw new System.NotImplementedException();
		public virtual Autodesk.Revit.DB.BuiltInCategory BuiltInCategory
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.CategoryType CategoryType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Material Material
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId Id
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Category Parent
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.CategoryNameMap SubCategories
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Color LineColor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
