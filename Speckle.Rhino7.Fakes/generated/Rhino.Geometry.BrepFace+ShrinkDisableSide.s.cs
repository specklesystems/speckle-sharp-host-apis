namespace Rhino.Geometry;

public partial class BrepFace
{
	public enum ShrinkDisableSide
	{
		ShrinkAllSides,
		DoNotShrinkWestSide,
		DoNotShrinkSouthSide,
		DoNotShrinkEastSide,
		DoNotShrinkNorthSide,
	}
}
