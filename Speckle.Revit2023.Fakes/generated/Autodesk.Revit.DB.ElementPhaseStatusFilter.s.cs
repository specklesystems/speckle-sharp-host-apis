namespace Autodesk.Revit.DB;

public partial class ElementPhaseStatusFilter : Autodesk.Revit.DB.ElementSlowFilter
{
	public ElementPhaseStatusFilter(Autodesk.Revit.DB.ElementId phaseId,System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementOnPhaseStatus> phaseStatuses,System.Boolean inverted) => throw new System.NotImplementedException();
	public ElementPhaseStatusFilter(Autodesk.Revit.DB.ElementId phaseId,System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementOnPhaseStatus> phaseStatuses) => throw new System.NotImplementedException();
	public ElementPhaseStatusFilter(Autodesk.Revit.DB.ElementId phaseId,Autodesk.Revit.DB.ElementOnPhaseStatus phaseStatus,System.Boolean inverted) => throw new System.NotImplementedException();
	public ElementPhaseStatusFilter(Autodesk.Revit.DB.ElementId phaseId,Autodesk.Revit.DB.ElementOnPhaseStatus phaseStatus) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementOnPhaseStatus> GetPhaseStatuses() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId PhaseId
	{
		get => throw new System.NotImplementedException();
	}
}
