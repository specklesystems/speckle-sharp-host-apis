namespace Autodesk.Revit.DB;

public enum OpenConflictResult
{
	KeepLocalChanges,
	DiscardLocalChangesAndOpenLatestVersion,
	Cancel,
	DetachFromCentral,
}
