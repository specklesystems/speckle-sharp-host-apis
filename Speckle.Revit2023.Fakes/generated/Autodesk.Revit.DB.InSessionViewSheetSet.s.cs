namespace Autodesk.Revit.DB;

public partial class InSessionViewSheetSet : Autodesk.Revit.DB.IViewSheetSet,System.IDisposable
{
	public virtual void Dispose() => throw new System.NotImplementedException();
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
	public virtual IReadOnlyList<Autodesk.Revit.DB.View> OrderedViewList
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ViewSet Views
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
