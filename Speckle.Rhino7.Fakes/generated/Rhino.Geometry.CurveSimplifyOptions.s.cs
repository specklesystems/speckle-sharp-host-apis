namespace Rhino.Geometry;

public enum CurveSimplifyOptions
{
	None,
	SplitAtFullyMultipleKnots,
	RebuildLines,
	RebuildArcs,
	RebuildRationals,
	AdjustG1,
	Merge,
	All,
}
