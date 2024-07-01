namespace Autodesk.Revit.DB;

public partial interface IViewSheetSet
{
	public  System.Boolean IsAutomatic
	{
		get;
		set;
	}
	public  Autodesk.Revit.DB.ElementId ViewOrganizationId
	{
		get;
		set;
	}
	public  Autodesk.Revit.DB.ElementId SheetOrganizationId
	{
		get;
		set;
	}
	public  IReadOnlyList<Autodesk.Revit.DB.View> OrderedViewList
	{
		get;
		set;
	}
	public  Autodesk.Revit.DB.ViewSet Views
	{
		get;
		set;
	}
}
