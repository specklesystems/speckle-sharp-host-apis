namespace Autodesk.Revit.DB;

public partial class ViewSheetSetting : Autodesk.Revit.DB.APIObject
{
	public virtual Autodesk.Revit.DB.IViewSheetSet get_CurrentViewSheetSet() => throw new System.NotImplementedException();
	public virtual void set_CurrentViewSheetSet(Autodesk.Revit.DB.IViewSheetSet vss) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ViewSet get_AvailableViews() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.InSessionViewSheetSet get_InSession() => throw new System.NotImplementedException();
	public virtual void Revert() => throw new System.NotImplementedException();
}
