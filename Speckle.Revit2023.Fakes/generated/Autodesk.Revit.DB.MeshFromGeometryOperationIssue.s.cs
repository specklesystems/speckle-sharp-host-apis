namespace Autodesk.Revit.DB;

public enum MeshFromGeometryOperationIssue
{
	AllFine,
	NoUsableCurveLoopsInInput,
	MissingCurveLoopsInInput,
	EmptyCurveLoopsInInput,
	CurveLoopsWithoutCurvesInInput,
	NonPlanarProfileLoop,
	InputCurveLoopProblemWithFallback,
	InputCurveLoopWrongOpenFlag,
	NonContinuousInputCurveLoop,
	MissingCurvesInInputLoop,
	InternalUtilityError,
	InternalMissingError,
	InternalError,
	NotSetYet,
	NumberOfIssueTypes,
}
