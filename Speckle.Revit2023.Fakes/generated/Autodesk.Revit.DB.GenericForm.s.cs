namespace Autodesk.Revit.DB;

public partial class GenericForm : Autodesk.Revit.DB.CombinableElement
{
	public virtual Autodesk.Revit.DB.FamilyElementVisibility GetVisibility() => throw new System.NotImplementedException();
	public virtual void SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility visibility) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Category Subcategory
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
