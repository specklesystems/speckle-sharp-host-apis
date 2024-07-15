namespace Autodesk.Revit.DB;

public partial class ElementBinding : Autodesk.Revit.DB.Binding
{
	public ElementBinding() {}
	public virtual Autodesk.Revit.DB.CategorySet Categories
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
