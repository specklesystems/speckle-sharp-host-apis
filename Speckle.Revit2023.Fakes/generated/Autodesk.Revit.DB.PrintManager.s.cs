namespace Autodesk.Revit.DB;

public partial class PrintManager : Autodesk.Revit.DB.APIObject
{
	public virtual void Apply() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.PaperSourceSet PaperSources
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.PaperSizeSet PaperSizes
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.VirtualPrinterType IsVirtual
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.PrintRange PrintRange
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ViewSheetSetting ViewSheetSetting
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.PrintSetup PrintSetup
	{
		get => throw new System.NotImplementedException();
	}
}
