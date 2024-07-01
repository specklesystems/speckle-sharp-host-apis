namespace Autodesk.Revit.DB.Structure;

public partial class RebarContainerItem : System.IDisposable
{
  public virtual void SetFromRebar(Autodesk.Revit.DB.Structure.Rebar rebar) =>
    throw new System.NotImplementedException();

  public virtual void SetFromCurves(
    Autodesk.Revit.DB.Structure.RebarStyle style,
    Autodesk.Revit.DB.Structure.RebarBarType barType,
    Autodesk.Revit.DB.Structure.RebarHookType startHook,
    Autodesk.Revit.DB.Structure.RebarHookType endHook,
    Autodesk.Revit.DB.XYZ norm,
    System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> curves,
    Autodesk.Revit.DB.Structure.RebarHookOrientation startHookOrient,
    Autodesk.Revit.DB.Structure.RebarHookOrientation endHookOrient,
    System.Boolean useExistingShapeIfPossible,
    System.Boolean createNewShape
  ) => throw new System.NotImplementedException();

  public virtual void SetFromRebarShape(
    Autodesk.Revit.DB.Structure.RebarShape rebarShape,
    Autodesk.Revit.DB.Structure.RebarBarType barType,
    Autodesk.Revit.DB.XYZ origin,
    Autodesk.Revit.DB.XYZ xVec,
    Autodesk.Revit.DB.XYZ yVec
  ) => throw new System.NotImplementedException();

  public virtual void SetFromCurvesAndShape(
    Autodesk.Revit.DB.Structure.RebarShape rebarShape,
    Autodesk.Revit.DB.Structure.RebarBarType barType,
    Autodesk.Revit.DB.Structure.RebarHookType startHook,
    Autodesk.Revit.DB.Structure.RebarHookType endHook,
    Autodesk.Revit.DB.XYZ norm,
    System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> curves,
    Autodesk.Revit.DB.Structure.RebarHookOrientation startHookOrient,
    Autodesk.Revit.DB.Structure.RebarHookOrientation endHookOrient
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetCenterlineCurves(
    System.Boolean adjustForSelfIntersection,
    System.Boolean suppressHooks,
    System.Boolean suppressBendRadius,
    Autodesk.Revit.DB.Structure.MultiplanarOption multiplanarOption
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetCenterlineCurves(
    System.Boolean adjustForSelfIntersection,
    System.Boolean suppressHooks,
    System.Boolean suppressBendRadius
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Line GetDistributionPath() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Transform GetBarPositionTransform(System.Int32 barPositionIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> ComputeDrivingCurves() =>
    throw new System.NotImplementedException();

  public virtual void SetLayoutAsSingle() => throw new System.NotImplementedException();

  public virtual void SetLayoutAsFixedNumber(
    System.Int32 numberOfBarPositions,
    System.Double arrayLength,
    System.Boolean barsOnNormalSide,
    System.Boolean includeFirstBar,
    System.Boolean includeLastBar
  ) => throw new System.NotImplementedException();

  public virtual void SetLayoutAsMaximumSpacing(
    System.Double spacing,
    System.Double arrayLength,
    System.Boolean barsOnNormalSide,
    System.Boolean includeFirstBar,
    System.Boolean includeLastBar
  ) => throw new System.NotImplementedException();

  public virtual void SetLayoutAsNumberWithSpacing(
    System.Int32 numberOfBarPositions,
    System.Double spacing,
    System.Boolean barsOnNormalSide,
    System.Boolean includeFirstBar,
    System.Boolean includeLastBar
  ) => throw new System.NotImplementedException();

  public virtual void SetLayoutAsMinimumClearSpacing(
    System.Double spacing,
    System.Double arrayLength,
    System.Boolean barsOnNormalSide,
    System.Boolean includeFirstBar,
    System.Boolean includeLastBar
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarBendData GetBendData() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetHookTypeId(System.Int32 end) =>
    throw new System.NotImplementedException();

  public virtual void SetHookTypeId(System.Int32 end, Autodesk.Revit.DB.ElementId hookTypeId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean DoesBarExistAtPosition(System.Int32 barPosition) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarHookOrientation GetHookOrientation(System.Int32 iEnd) =>
    throw new System.NotImplementedException();

  public virtual void SetHookOrientation(
    System.Int32 iEnd,
    Autodesk.Revit.DB.Structure.RebarHookOrientation hookOrientation
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean CanUseHookType(Autodesk.Revit.DB.ElementId proposedHookId) =>
    throw new System.NotImplementedException();

  public virtual void SetBarHiddenStatus(Autodesk.Revit.DB.View view, System.Int32 barIndex, System.Boolean hide) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsBarHidden(Autodesk.Revit.DB.View view, System.Int32 barIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsRebarInSection(Autodesk.Revit.DB.View dBView) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean HasPresentationOverrides(Autodesk.Revit.DB.View dBView) =>
    throw new System.NotImplementedException();

  public virtual void ClearPresentationMode(Autodesk.Revit.DB.View dBView) =>
    throw new System.NotImplementedException();

  public virtual void SetPresentationMode(
    Autodesk.Revit.DB.View dBView,
    Autodesk.Revit.DB.Structure.RebarPresentationMode presentationMode
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarPresentationMode GetPresentationMode(Autodesk.Revit.DB.View dBView) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarPresentationMode FindMatchingPredefinedPresentationMode(
    Autodesk.Revit.DB.View dBView
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean CanApplyPresentationMode(Autodesk.Revit.DB.View dBView) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 ItemIndex
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 NumberOfBarPositions
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId RebarShapeId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Volume
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double TotalLength
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double MultiplanarDepth
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Pitch
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 TopFinishingTurns
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 BaseFinishingTurns
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Height
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IncludeLastBar
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IncludeFirstBar
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Structure.RebarLayoutRule LayoutRule
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double MaxSpacing
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 Quantity
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double ArrayLength
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean BarsOnNormalSide
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ Normal
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId BarTypeId
  {
    get => throw new System.NotImplementedException();
  }
}
