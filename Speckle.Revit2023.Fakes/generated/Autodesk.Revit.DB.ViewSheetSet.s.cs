namespace Autodesk.Revit.DB;

public partial class ViewSheetSet : Autodesk.Revit.DB.Element,Autodesk.Revit.DB.IViewSheetSet
{
	public virtual System.Boolean IsAutomatic
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId ViewOrganizationId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId SheetOrganizationId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Collections.Generic.IReadOnlyList<Autodesk.Revit.DB.View> OrderedViewList
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ViewSet Views
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public new System.String Name
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
