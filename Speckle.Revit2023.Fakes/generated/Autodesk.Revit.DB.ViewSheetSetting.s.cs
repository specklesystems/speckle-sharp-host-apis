namespace Autodesk.Revit.DB;

public partial class ViewSheetSetting : Autodesk.Revit.DB.APIObject
{
	public virtual void Revert() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.InSessionViewSheetSet InSession
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ViewSet AvailableViews
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.IViewSheetSet CurrentViewSheetSet
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
