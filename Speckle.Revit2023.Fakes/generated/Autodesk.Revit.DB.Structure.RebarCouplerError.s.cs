namespace Autodesk.Revit.DB.Structure;

public enum RebarCouplerError
{
	ValidationSuccessfuly,
	IncorrectInputData,
	DifferentLayout,
	BarsNotTouching,
	IncorrectEndTreatmentHook,
	IncorrectEndTreatmentCoupler,
	BarSegementsAreNotParallel,
	BarSegmentsAreNotOnSameLine,
	InconsistentShape,
	InvalidDiameter,
	CurvesOtherThanLine,
	BarSegmentSmallerThanEngagement,
	VaryingDistanceBetweenDistributionsBars,
	ArcsHaveDifferentRadii,
	ArcsHaveDifferentCenters,
	ArcToStraightSegment,
}
