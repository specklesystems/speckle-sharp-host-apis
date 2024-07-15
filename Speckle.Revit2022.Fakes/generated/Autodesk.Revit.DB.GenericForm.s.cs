namespace Autodesk.Revit.DB;

public partial class GenericForm : Autodesk.Revit.DB.CombinableElement
{
	public GenericForm() {}
	public virtual Autodesk.Revit.DB.FamilyElementVisibility GetVisibility() => throw new System.NotImplementedException();
	public virtual void SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility visibility) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Category Subcategory
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public override System.String Name
	{
		set {}
	}
	public virtual System.Boolean IsSolid
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Visible
	{
		get => throw new System.NotImplementedException();
	}
}
