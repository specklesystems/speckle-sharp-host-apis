namespace Autodesk.Revit.DB;

public partial class PrintSetup : Autodesk.Revit.DB.APIObject
{
	public virtual Autodesk.Revit.DB.IPrintSetting get_CurrentPrintSetting() => throw new System.NotImplementedException();
	public virtual void set_CurrentPrintSetting(Autodesk.Revit.DB.IPrintSetting pps) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.InSessionPrintSetting get_InSession() => throw new System.NotImplementedException();
	public virtual void Revert() => throw new System.NotImplementedException();
}
