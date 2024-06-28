namespace Autodesk.Revit.UI;

public partial class FilterDialog : System.Object
{
	public virtual void Show() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String NewFilterName
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId FilterToSelect
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId NewFilterId
	{
		get => throw new System.NotImplementedException();
	}
}
