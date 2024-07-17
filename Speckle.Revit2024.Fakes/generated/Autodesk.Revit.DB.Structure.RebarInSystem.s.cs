namespace Autodesk.Revit.DB.Structure;

public partial class RebarInSystem : Autodesk.Revit.DB.Element
{
  public RebarInSystem() { }

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetCenterlineCurves(
    System.Boolean adjustForSelfIntersection,
    System.Boolean suppressHooks,
    System.Boolean suppressBendRadius
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetTransformedCenterlineCurves(
    System.Boolean adjustForSelfIntersection,
    System.Boolean suppressHooks,
    System.Boolean suppressBendRadius,
    System.Int32 barPositionIndex
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Line GetDistributionPath() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Transform GetBarPositionTransform(System.Int32 barPositionIndex) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarRoundingManager GetReinforcementRoundingManager() =>
    throw new System.NotImplementedException();

  public virtual void SetBarHiddenStatus(Autodesk.Revit.DB.View view, System.Int32 barIndex, System.Boolean hide) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsBarHidden(Autodesk.Revit.DB.View view, System.Int32 barIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsRebarInSection(Autodesk.Revit.DB.View dBView) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean HasPresentationOverrides(Autodesk.Revit.DB.View dBView) =>
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

  public virtual void ClearPresentationMode(Autodesk.Revit.DB.View dBView) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CanApplyPresentationMode(Autodesk.Revit.DB.View dBView) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetHostId() => throw new System.NotImplementedException();

  public virtual System.Boolean IsUnobscuredInView(Autodesk.Revit.DB.View view) =>
    throw new System.NotImplementedException();

  public virtual void SetUnobscuredInView(Autodesk.Revit.DB.View view, System.Boolean unobscured) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarBendData GetBendData() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetHookTypeId(System.Int32 end) =>
    throw new System.NotImplementedException();

  public virtual void SetBarIncluded(System.Boolean include, System.Int32 barPositionIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean DoesBarExistAtPosition(System.Int32 barPosition) =>
    throw new System.NotImplementedException();

  public virtual void MoveBarInSet(System.Int32 barPositionIndex, Autodesk.Revit.DB.Transform moveTransform) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Transform GetMovedBarTransform(System.Int32 barPositionIndex) =>
    throw new System.NotImplementedException();

  public virtual void ResetMovedBarTransform(System.Int32 barPositionIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 GetBarIndexFromReference(Autodesk.Revit.DB.Reference barReference) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CanEditIndividualBars() => throw new System.NotImplementedException();

  public virtual System.Int32 NumberOfBarPositions
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId RebarShapeId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Volume
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double TotalLength
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Structure.RebarLayoutRule LayoutRule
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double MaxSpacing
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Quantity
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double ArrayLength
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean BarsOnNormalSide
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ Normal
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ScheduleMark
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId SystemId
  {
    get => throw new System.NotImplementedException();
  }
}
