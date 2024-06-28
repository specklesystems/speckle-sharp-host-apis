namespace Autodesk.Revit.DB;

public partial class STLExportOptions : Autodesk.Revit.DB.ATFBaseExportOptions
{
	public virtual void SetTessellationSettings(Autodesk.Revit.DB.ExportResolution resolutionType) => throw new System.NotImplementedException();
	public virtual void SetTessellationSettings(Autodesk.Revit.DB.STLExportResolution resolutionType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExportUnit TargetUnit
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
