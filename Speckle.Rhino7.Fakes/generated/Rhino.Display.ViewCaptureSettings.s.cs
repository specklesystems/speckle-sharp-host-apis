namespace Rhino.Display;

public partial class ViewCaptureSettings : System.IDisposable
{
  public ViewCaptureSettings() { }

  public ViewCaptureSettings(Rhino.Display.RhinoView sourceView, System.Drawing.Size mediaSize, System.Double dpi) =>
    throw new System.NotImplementedException();

  public ViewCaptureSettings(Rhino.Display.RhinoPageView sourcePageView, System.Double dpi) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Display.ViewCaptureSettings CreatePreviewSettings(System.Drawing.Size size) =>
    throw new System.NotImplementedException();

  public virtual void SetViewport(Rhino.Display.RhinoViewport viewport) => throw new System.NotImplementedException();

  public virtual void SetLayout(System.Drawing.Size mediaSize, System.Drawing.Rectangle cropRectangle) =>
    throw new System.NotImplementedException();

  public virtual void MaximizePrintableArea() => throw new System.NotImplementedException();

  public virtual System.Boolean MatchViewportAspectRatio() => throw new System.NotImplementedException();

  public virtual System.Boolean GetMargins(
    Rhino.UnitSystem lengthUnits,
    out System.Double left,
    out System.Double top,
    out System.Double right,
    out System.Double bottom
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean SetMargins(
    Rhino.UnitSystem lengthUnits,
    System.Double left,
    System.Double top,
    System.Double right,
    System.Double bottom
  ) => throw new System.NotImplementedException();

  public virtual void SetOffset(
    Rhino.UnitSystem lengthUnits,
    System.Boolean fromMargin,
    System.Double x,
    System.Double y
  ) => throw new System.NotImplementedException();

  public virtual void GetOffset(
    Rhino.UnitSystem lengthUnits,
    out System.Boolean fromMargin,
    out System.Double x,
    out System.Double y
  ) => throw new System.NotImplementedException();

  public virtual System.Double GetModelScale(Rhino.UnitSystem pageUnits, Rhino.UnitSystem modelUnits) =>
    throw new System.NotImplementedException();

  public virtual void SetModelScaleToValue(System.Double scale) => throw new System.NotImplementedException();

  public virtual void SetModelScaleToFit(System.Boolean promptOnChange) => throw new System.NotImplementedException();

  public virtual void SetWindowRect(Rhino.Geometry.Point2d screenPoint1, Rhino.Geometry.Point2d screenPoint2) =>
    throw new System.NotImplementedException();

  public virtual void SetWindowRect(Rhino.Geometry.Point3d worldPoint1, Rhino.Geometry.Point3d worldPoint2) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual Rhino.RhinoDoc Document
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.ViewCaptureSettings.ViewAreaMapping ViewArea
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean RasterMode
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean MatchLinetypePatternDefinition
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Size MediaSize
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Resolution
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Rectangle CropRectangle
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Display.ViewCaptureSettings.AnchorLocation OffsetAnchor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean DrawBackground
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DrawGrid
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DrawAxis
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DrawLockedObjects
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DrawMargins
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DrawSelectedObjectsOnly
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DrawClippingPlanes
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DrawLights
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DrawBackgroundBitmap
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DrawWallpaper
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UsePrintWidths
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double WireThicknessScale
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double PointSizeMillimeters
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ArrowheadSizeMillimeters
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double DefaultPrintWidthMillimeters
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.ViewCaptureSettings.ColorMode OutputColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String HeaderText
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String FooterText
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsScaleToFit
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 ModelScaleType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
