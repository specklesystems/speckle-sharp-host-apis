namespace Autodesk.Revit.DB;

public partial class DGNExportOptions : Autodesk.Revit.DB.BaseExportOptions
{
	public DGNExportOptions(Autodesk.Revit.DB.DGNExportOptions option) => throw new System.NotImplementedException();
	public DGNExportOptions() => throw new System.NotImplementedException();
	public new static System.Collections.Generic.IList<System.String> GetPredefinedSetupNames(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExportLineweightTable GetExportLineweightTable() => throw new System.NotImplementedException();
	public virtual void SetExportLineweightTable(Autodesk.Revit.DB.ExportLineweightTable lineweightTable) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.DGNExportOptions GetPredefinedOptions(Autodesk.Revit.DB.Document document,System.String setup) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DGNFileFormat FileVersion
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean WorkingUnits
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String SeedName
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean MergedViews
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
