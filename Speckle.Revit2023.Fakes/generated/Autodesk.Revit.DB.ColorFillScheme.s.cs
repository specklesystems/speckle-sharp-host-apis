namespace Autodesk.Revit.DB;

public partial class ColorFillScheme : Autodesk.Revit.DB.Element
{
	public virtual void UpdateEntry(Autodesk.Revit.DB.ColorFillSchemeEntry entry) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FormatOptions GetFormatOptions() => throw new System.NotImplementedException();
	public virtual void SetFormatOptions(Autodesk.Revit.DB.FormatOptions formatOptions) => throw new System.NotImplementedException();
	public virtual void AddEntry(Autodesk.Revit.DB.ColorFillSchemeEntry entry) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.EntryAndSchemeConsistency IsEntryConsistentWithScheme(Autodesk.Revit.DB.ColorFillSchemeEntry entry) => throw new System.NotImplementedException();
	public virtual void SortEntries() => throw new System.NotImplementedException();
	public virtual void RemoveEntry(Autodesk.Revit.DB.ColorFillSchemeEntry entry) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId ParameterDefinition
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId AreaSchemeId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.StorageType StorageType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId CategoryId
	{
		get => throw new System.NotImplementedException();
	}
}
