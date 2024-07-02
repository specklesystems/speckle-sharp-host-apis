namespace Rhino.Geometry;

public partial class Dimension : Rhino.Geometry.AnnotationBase
{
	public Dimension() {}
	public virtual Rhino.Geometry.Transform GetTextTransform(Rhino.DocObjects.ViewportInfo viewport,Rhino.DocObjects.DimensionStyle style,System.Double textScale,System.Boolean drawForward) => throw new System.NotImplementedException();
	public virtual void SetDimensionLengthDisplayWithZeroSuppressionReset(Rhino.DocObjects.DimensionStyle.LengthDisplay ld) => throw new System.NotImplementedException();
	public virtual void SetAltDimensionLengthDisplayWithZeroSuppressionReset(Rhino.DocObjects.DimensionStyle.LengthDisplay ld) => throw new System.NotImplementedException();
	public virtual System.Boolean UseDefaultTextPoint
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Point2d TextPosition
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String PlainUserText
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double TextRotation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double NumericValue
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid DetailMeasured
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double DistanceScale
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Dimension.ForceArrow ForceArrowPosition
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Dimension.ForceText ForceTextPosition
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ForceDimLine
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.DimensionStyle.ArrowFit ArrowFit
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ForceDimensionLineBetweenExtensionLines
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.DimensionStyle.TextFit TextFit
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.TextOrientation TextOrientation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.DimensionStyle.TextLocation TextLocation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.DimensionStyle.LeaderContentAngleStyle TextAngleType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double DimensionLineExtension
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ExtensionLineExtension
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ExtensionLineOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean FixedLengthExtensionOn
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double FixedExtensionLength
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double BaselineSpacing
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double CentermarkSize
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.DimensionStyle.CenterMarkStyle CentermarkStyle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean SuppressExtension1
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean SuppressExtension2
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.DimensionStyle.ArrowType ArrowheadType1
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.DimensionStyle.ArrowType ArrowheadType2
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ArrowSize
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Guid ArrowBlockId1
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Guid ArrowBlockId2
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double LengthFactor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 LengthResolution
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double LengthRoundoff
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String Prefix
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String Suffix
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.DimensionStyle.ZeroSuppression ZeroSuppression
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean AltUnitsDisplay
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double AltLengthFactor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 AltLengthResolution
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double AltLengthRoundoff
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String AltPrefix
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String AltSuffix
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.DimensionStyle.ZeroSuppression AltZeroSuppression
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean AlternateBelowLine
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.DimensionStyle.ToleranceDisplayFormat ToleranceFormat
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 ToleranceResolution
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 AltToleranceResolution
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ToleranceUpperValue
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ToleranceLowerValue
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ToleranceHeightScale
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
