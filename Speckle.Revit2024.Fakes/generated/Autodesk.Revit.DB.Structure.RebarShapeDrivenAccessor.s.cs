namespace Autodesk.Revit.DB.Structure;

public partial class RebarShapeDrivenAccessor : System.IDisposable
{
  public RebarShapeDrivenAccessor() { }

  public virtual Autodesk.Revit.DB.Line GetDistributionPath() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> ComputeDrivingCurves() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Transform GetBarPositionTransform(System.Int32 barPositionIndex) =>
    throw new System.NotImplementedException();

  public virtual void ScaleToBox(
    Autodesk.Revit.DB.XYZ origin,
    Autodesk.Revit.DB.XYZ xVec,
    Autodesk.Revit.DB.XYZ yVec
  ) => throw new System.NotImplementedException();

  public virtual void ScaleToBoxFor3D(
    Autodesk.Revit.DB.XYZ origin,
    Autodesk.Revit.DB.XYZ xVec,
    Autodesk.Revit.DB.XYZ yVec,
    System.Double height
  ) => throw new System.NotImplementedException();

  public virtual void SetRebarShapeId(Autodesk.Revit.DB.ElementId shapeId) =>
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

  public virtual void FlipRebarSet() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
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
  public virtual System.Double MultiplanarDepth
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 BaseFinishingTurns
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ArrayLength
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Height
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
}
