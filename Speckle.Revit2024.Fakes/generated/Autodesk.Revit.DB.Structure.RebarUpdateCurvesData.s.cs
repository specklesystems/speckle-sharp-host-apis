namespace Autodesk.Revit.DB.Structure;

public partial class RebarUpdateCurvesData : System.IDisposable
{
  public RebarUpdateCurvesData() { }

  public virtual System.Int32 GetNumberOfBars() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetBarGeometry(System.Int32 barIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Int32> GetChangedCustomHandles() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Guid> GetChangedSharedParameterGUIDs() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.RebarConstraint> GetCustomConstraints() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarConstraint GetStartConstraint() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarConstraint GetEndConstraint() =>
    throw new System.NotImplementedException();

  public virtual System.Double GetBarModelDiameter() => throw new System.NotImplementedException();

  public virtual System.Double GetBarNominalDiameter() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarStyle GetRebarStyle() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.StirrupTieAttachmentType GetAttachmentType() =>
    throw new System.NotImplementedException();

  public virtual System.Double GetBendingRadius() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarLayoutRule GetLayoutRule() =>
    throw new System.NotImplementedException();

  public virtual System.Int32 GetBarsNumber() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetHostId() => throw new System.NotImplementedException();

  public virtual void SetHookPlaneNormalForBarIdx(
    System.Int32 end,
    System.Int32 barPositionIndex,
    Autodesk.Revit.DB.XYZ hookNormal
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ GetHookPlaneNormalForBarIdx(System.Int32 end, System.Int32 barPositionIndex) =>
    throw new System.NotImplementedException();

  public virtual void SetHookOrientationAngle(System.Int32 end, System.Double angle) =>
    throw new System.NotImplementedException();

  public virtual System.Double GetHookOrientationAngle(System.Int32 end) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Document GetDocument() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetRebarId() => throw new System.NotImplementedException();

  public virtual System.Int32 GetCycleCounter() => throw new System.NotImplementedException();

  public virtual void SetCycleCounter(System.Int32 cycleCounter) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Structure.AlignedFreeFormSetOrientationOptions AlignedFreeFormSetOrientationOptions
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean AreOrientationOptionsChanged
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean CycleCounterChanged
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ErrorMessage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsReversed
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean HostMirrored
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Spacing
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsBendingRadiusChanged
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsStyleChanged
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsAttachmentTypeChanged
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsEndConstraintChanged
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsStartConstraintChanged
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsBarsNumberChanged
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsSpacingChanged
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsLayoutChanged
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Structure.RebarWorkInstructions WorkshopInstructions
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean AreWorkshopInstructionsChanged
  {
    get => throw new System.NotImplementedException();
  }
}
