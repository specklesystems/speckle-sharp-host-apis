namespace Autodesk.Revit.DB;

public partial class PrintSetup : Autodesk.Revit.DB.APIObject
{
	public virtual void Revert() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.InSessionPrintSetting InSession
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.IPrintSetting CurrentPrintSetting
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
