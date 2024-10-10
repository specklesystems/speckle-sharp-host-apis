namespace Rhino.DocObjects;

public partial class DimensionStyle : Rhino.DocObjects.ModelComponent
{
  public DimensionStyle() { }

  public virtual System.Boolean IsFieldOverriden(Rhino.DocObjects.DimensionStyle.Field field) =>
    throw new System.NotImplementedException();

  public virtual void SetFieldOverride(Rhino.DocObjects.DimensionStyle.Field field) =>
    throw new System.NotImplementedException();

  public virtual void ClearFieldOverride(Rhino.DocObjects.DimensionStyle.Field field) =>
    throw new System.NotImplementedException();

  public virtual void ClearAllFieldOverrides() => throw new System.NotImplementedException();

  public virtual System.Boolean IsChildOf(System.Guid parentId) => throw new System.NotImplementedException();

  public virtual System.Boolean SetUserString(System.String key, System.String value) =>
    throw new System.NotImplementedException();

  public virtual System.String GetUserString(System.String key) => throw new System.NotImplementedException();

  public virtual System.Collections.Specialized.NameValueCollection GetUserStrings() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean DeleteUserString(System.String key) => throw new System.NotImplementedException();

  public virtual void DeleteAllUserStrings() => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.DimensionStyle Duplicate() => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.DimensionStyle Duplicate(
    System.String newName,
    System.Guid newId,
    System.Guid newParentId
  ) => throw new System.NotImplementedException();

  public virtual void CopyFrom(Rhino.DocObjects.DimensionStyle source) => throw new System.NotImplementedException();

  public virtual System.Drawing.Bitmap CreatePreviewBitmap(System.Int32 width, System.Int32 height) =>
    throw new System.NotImplementedException();

  public virtual void ScaleLengthValues(System.Double scale) => throw new System.NotImplementedException();

  public virtual Rhino.UnitSystem DimensionLengthDisplayUnit(System.UInt32 model_serial_number) =>
    throw new System.NotImplementedException();

  public virtual Rhino.UnitSystem AlternateDimensionLengthDisplayUnit(System.UInt32 model_serial_number) =>
    throw new System.NotImplementedException();

  public new Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
  public new System.Boolean IsReference
  {
    get => throw new System.NotImplementedException();
  }
  public new System.Boolean IsDeleted
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.Font Font
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Guid ArrowBlockId1
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Guid ArrowBlockId2
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Guid LeaderArrowBlockId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SuppressExtension1
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SuppressExtension2
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SuppressArrow1
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SuppressArrow2
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean AlternateUnitsDisplay
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean AlternateBelowLine
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DrawTextMask
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean FixedExtensionOn
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean LeaderHasLanding
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DrawForward
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean TextUnderlined
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double MaskOffset
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ExtensionLineExtension
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ExtensionLineOffset
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double DimensionLineExtension
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ArrowLength
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double LeaderArrowLength
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double CentermarkSize
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double TextGap
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double TextHeight
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double LengthFactor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double AlternateLengthFactor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ToleranceUpperValue
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ToleranceLowerValue
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ToleranceHeightScale
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double BaselineSpacing
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double DimensionScale
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double FixedExtensionLength
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double TextRotation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double StackHeightScale
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Roundoff
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double AlternateRoundoff
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double AngularRoundoff
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double LeaderLandingLength
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double LeaderTextRotationRadians
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double LeaderTextRotationDegrees
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.ScaleValue DimensionScaleValue
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ScaleLeftLengthMillimeters
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ScaleRightLengthMillimeters
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.TextFit FitText
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.ArrowFit FitArrow
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ForceDimensionLineBetweenExtensionLines
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.LengthDisplay DimensionLengthDisplay
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.LengthDisplay AlternateDimensionLengthDisplay
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.AngleDisplayFormat AngleFormat
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.ToleranceDisplayFormat ToleranceFormat
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.MaskType MaskColorSource
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.MaskFrame MaskFrameType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.StackDisplayFormat StackFractionFormat
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.ZeroSuppression ZeroSuppress
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.ZeroSuppression AlternateZeroSuppress
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.ZeroSuppression ToleranceZeroSuppress
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.ZeroSuppression AngleZeroSuppress
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.ArrowType ArrowType1
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.ArrowType ArrowType2
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.ArrowType LeaderArrowType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 TextMoveLeader
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 ArcLengthSymbol
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.CenterMarkStyle CenterMarkType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.LeaderContentAngleStyle LeaderContentAngleType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.TextVerticalAlignment TextVerticalAlignment
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.TextHorizontalAlignment TextHorizontalAlignment
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.TextVerticalAlignment LeaderTextVerticalAlignment
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.TextHorizontalAlignment LeaderTextHorizontalAlignment
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.TextLocation DimTextLocation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.TextLocation DimRadialTextLocation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.LeaderCurveStyle LeaderCurveType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.LeaderContentAngleStyle DimTextAngleType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.DimensionStyle.LeaderContentAngleStyle DimRadialTextAngleType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.TextOrientation TextOrientation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.TextOrientation LeaderTextOrientation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.TextOrientation DimTextOrientation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.TextOrientation DimRadialTextOrientation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 LengthResolution
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 AlternateLengthResolution
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 AngleResolution
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 ToleranceResolution
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 AlternateToleranceResolution
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color MaskColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Char DecimalSeparator
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Prefix
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Suffix
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String AlternatePrefix
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String AlternateSuffix
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean HasFieldOverrides
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsChild
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Guid ParentId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 UserStringCount
  {
    get => throw new System.NotImplementedException();
  }
}
