namespace Autodesk.Revit.DB.Electrical;

public partial class PanelScheduleData : Autodesk.Revit.DB.TableData
{
	public PanelScheduleData() {}
	public virtual System.Boolean IsSymmetric() => throw new System.NotImplementedException();
	public virtual void UpdateIsSectionHidden(Autodesk.Revit.DB.SectionType sectionType,System.Boolean bHide) => throw new System.NotImplementedException();
	public virtual void UpdateCircuitTableForInstance(Autodesk.Revit.DB.FamilyInstance pPanel) => throw new System.NotImplementedException();
	public virtual void UpdateCircuitTableForTemplate(Autodesk.Revit.DB.Electrical.PanelSchedulePhaseLoadType newType,System.Int32 nNumSlots,System.Boolean bPhasesAsCurrents) => throw new System.NotImplementedException();
	public virtual void UpdateLoadSummary() => throw new System.NotImplementedException();
	public virtual void UpdateVerticalHeadersInSection(Autodesk.Revit.DB.SectionType sectionType,System.Boolean bVertical) => throw new System.NotImplementedException();
	public virtual System.Int32 GetNumberOfCircuitRows() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetLoadClassifications() => throw new System.NotImplementedException();
	public virtual void SetLoadClassifications(System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> loadClassificaions) => throw new System.NotImplementedException();
	public virtual void RemoveLoadClassification(System.Int32 nIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean AddLoadClassification(Autodesk.Revit.DB.ElementId loadClassficationId) => throw new System.NotImplementedException();
	public virtual void SetBorderAroundSections(Autodesk.Revit.DB.ElementId borderId) => throw new System.NotImplementedException();
	public virtual void SetBorderAroundSchedule(Autodesk.Revit.DB.ElementId borderId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsUnusedPhaseHidden
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsAutoShadingForLoadDisplay
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean PhasesAsCurrents
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean ShowSlotFromDeviceInsteadOfTemplate
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowMultipleRowsForMultiphaseCircuits
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowCircuitNumberOnOneRowForMultiphaseCircuits
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsPanelSinglePhase
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean BodyShowsVerticalHeaders
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean SummaryShowsVerticalHeaders
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean SummaryShowsGroups
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean SummaryShowsOnlyConnectedLoads
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsFooterSectionHidden
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsSummarySectionHidden
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsHeaderSectionHidden
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 NumberOfSlots
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Electrical.PanelSchedulePhaseLoadType PhaseLoadType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Electrical.PanelConfiguration PanelConfiguration
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Electrical.PanelScheduleType ScheduleType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId BorderAroundSchedule
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId BorderAroundSections
	{
		get => throw new System.NotImplementedException();
	}
}
