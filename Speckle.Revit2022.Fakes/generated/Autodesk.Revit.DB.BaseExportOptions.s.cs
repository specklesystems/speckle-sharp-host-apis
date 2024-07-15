namespace Autodesk.Revit.DB;

public partial class BaseExportOptions : System.IDisposable
{
	public BaseExportOptions() {}
	public static System.Collections.Generic.IList<System.String> GetPredefinedSetupNames(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExportLayerTable GetExportLayerTable() => throw new System.NotImplementedException();
	public virtual void SetExportLayerTable(Autodesk.Revit.DB.ExportLayerTable layerTable) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExportLinetypeTable GetExportLinetypeTable() => throw new System.NotImplementedException();
	public virtual void SetExportLinetypeTable(Autodesk.Revit.DB.ExportLinetypeTable linetypeTable) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExportPatternTable GetExportPatternTable() => throw new System.NotImplementedException();
	public virtual void SetExportPatternTable(Autodesk.Revit.DB.ExportPatternTable patternTable) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExportFontTable GetExportFontTable() => throw new System.NotImplementedException();
	public virtual void SetExportFontTable(Autodesk.Revit.DB.ExportFontTable fontTable) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean PreserveCoincidentLines
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean HideUnreferenceViewTags
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean HideReferencePlane
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean HideScopeBox
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ExportColorMode Colors
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String HatchPatternsFileName
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String LayerMapping
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.PropOverrideMode PropOverrides
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
