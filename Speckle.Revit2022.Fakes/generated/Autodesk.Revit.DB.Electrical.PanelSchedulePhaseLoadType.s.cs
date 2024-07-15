namespace Autodesk.Revit.DB.Electrical;

public enum PanelSchedulePhaseLoadType
{
	NoLoadInformation,
	LoadsByPhaseInSplitColumns,
	MirroredPhaseColumns,
	LoadsByPhaseInSharedColumns,
	LoadsByPhase,
	TotalLoadOnlyPerCircuit,
	SeperatePhaseLoadsPerCircuit,
}
