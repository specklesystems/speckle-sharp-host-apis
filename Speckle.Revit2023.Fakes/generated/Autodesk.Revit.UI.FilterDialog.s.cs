namespace Autodesk.Revit.UI;

public partial class FilterDialog : System.IDisposable
{
	public FilterDialog(Autodesk.Revit.DB.Document doc,System.String name) => throw new System.NotImplementedException();
	public FilterDialog(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.ElementId filterToSelect) => throw new System.NotImplementedException();
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
