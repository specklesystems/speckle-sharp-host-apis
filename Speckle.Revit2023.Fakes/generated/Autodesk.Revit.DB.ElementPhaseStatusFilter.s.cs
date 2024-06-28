namespace Autodesk.Revit.DB;

public partial class ElementPhaseStatusFilter : Autodesk.Revit.DB.ElementSlowFilter
{
	public virtual ICollection<Autodesk.Revit.DB.ElementOnPhaseStatus> GetPhaseStatuses() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId PhaseId
	{
		get => throw new System.NotImplementedException();
	}
}
