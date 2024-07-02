namespace Rhino.DocObjects;

public partial class DimensionStyle
{
	public enum ZeroSuppression
	{
		None,
		SuppressLeading,
		SuppressTrailing,
		SuppressLeadingAndTrailing,
		SuppressZeroFeet,
		SuppressZeroInches,
		SuppressZeroFeetAndZeroInches,
	}
}
