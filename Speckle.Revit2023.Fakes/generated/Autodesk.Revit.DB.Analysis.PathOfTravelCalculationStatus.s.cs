namespace Autodesk.Revit.DB.Analysis;

public enum PathOfTravelCalculationStatus
{
	Success,
	NoPathOfTravel,
	AreaTooLarge,
	SplitView,
	ResultAffectedByCrop,
	StartAndEndPointsTooClose,
	PointOutsideActiveCrop,
	TooMuchGeometry,
	RevealObstaclesModeFailureDataExist,
	RevealObstaclesModeFailureWireframe,
	TemporaryModeFailureDataExist,
	TemporaryModeFailureWireframe,
}
