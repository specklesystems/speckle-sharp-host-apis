namespace Autodesk.Revit.DB;

public partial class PrintSetup : Autodesk.Revit.DB.APIObject
{
	public virtual System.Boolean Save() => throw new System.NotImplementedException();
	public virtual System.Boolean SaveAs(System.String newName) => throw new System.NotImplementedException();
	public virtual System.Boolean Rename(System.String newName) => throw new System.NotImplementedException();
	public virtual System.Boolean Delete() => throw new System.NotImplementedException();
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
