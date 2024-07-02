namespace Autodesk.Revit.DB.Fabrication;

public enum FabricationPartFitResult
{
	Success,
	IncompatibleGeometry,
	MisalignedEnds,
	DimensionLocked,
	BadDimensions,
	ShapeMismatch,
	SizeMismatch,
	IncompatibleConnection,
	OffsetRequired,
	Unsupported,
}
