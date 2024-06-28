namespace Autodesk.Revit.DB;

public partial class PrintManager : Autodesk.Revit.DB.APIObject
{
	public virtual Autodesk.Revit.DB.PrintSetup get_PrintSetup() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ViewSheetSetting get_ViewSheetSetting() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.PrintRange get_PrintRange() => throw new System.NotImplementedException();
	public virtual void set_PrintRange(Autodesk.Revit.DB.PrintRange pr) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.VirtualPrinterType get_IsVirtual() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.PaperSizeSet get_PaperSizes() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.PaperSourceSet get_PaperSources() => throw new System.NotImplementedException();
	public virtual void Apply() => throw new System.NotImplementedException();
}
