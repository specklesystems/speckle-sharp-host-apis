namespace Autodesk.Revit.DB.Structure;

public partial class RebarShape : Autodesk.Revit.DB.ElementType
{
  public static Autodesk.Revit.DB.Structure.RebarShape Create(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.Structure.RebarShapeDefinition definition,
    Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition multiplanarDefinition,
    Autodesk.Revit.DB.Structure.RebarStyle style,
    Autodesk.Revit.DB.Structure.StirrupTieAttachmentType attachmentType,
    System.Int32 startHookAngle,
    Autodesk.Revit.DB.Structure.RebarHookOrientation startHookOrientation,
    System.Int32 endHookAngle,
    Autodesk.Revit.DB.Structure.RebarHookOrientation endHookOrientation,
    System.Int32 higherEnd,
    System.Double hookRotationAngleAtStart,
    System.Double hookRotationAngleAtEnd,
    Autodesk.Revit.DB.ElementId endTreatmentTypeIdAtStart,
    Autodesk.Revit.DB.ElementId endTreatmentTypeIdAtEnd
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Structure.RebarShape Create(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.Structure.RebarShapeDefinition definition,
    Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition multiplanarDefinition,
    Autodesk.Revit.DB.Structure.RebarStyle style,
    Autodesk.Revit.DB.Structure.StirrupTieAttachmentType attachmentType,
    System.Int32 startHookAngle,
    Autodesk.Revit.DB.Structure.RebarHookOrientation startHookOrientation,
    System.Int32 endHookAngle,
    Autodesk.Revit.DB.Structure.RebarHookOrientation endHookOrientation,
    System.Int32 higherEnd
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarShapeDefinition GetRebarShapeDefinition() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarShapeMultiplanarDefinition GetMultiplanarDefinition() =>
    throw new System.NotImplementedException();

  public virtual void SetAllowed(Autodesk.Revit.DB.Structure.RebarBarType barType, System.Boolean allowed) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetAllowed(Autodesk.Revit.DB.Structure.RebarBarType barType) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 GetDefaultHookAngle(System.Int32 index) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarHookOrientation GetDefaultHookOrientation(System.Int32 index) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetCurvesForBrowser() =>
    throw new System.NotImplementedException();

  public virtual System.Double GetHookRotationAngle(System.Int32 iEnd) => throw new System.NotImplementedException();

  public virtual void SetHookRotationAngle(System.Double hookRotationAngle, System.Int32 iEnd) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsSameShapeIgnoringHooks(Autodesk.Revit.DB.Structure.RebarShape otherShape) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetEndTreatmentTypeId(System.Int32 iEnd) =>
    throw new System.NotImplementedException();

  public virtual void SetEndTreatmentTypeId(Autodesk.Revit.DB.ElementId endTreatmentId, System.Int32 iEnd) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean HasEndTreatment() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId ShapeFamilyId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 HigherEnd
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Structure.StirrupTieAttachmentType StirrupTieAttachment
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Structure.RebarStyle RebarStyle
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean SimpleArc
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean SimpleLine
  {
    get => throw new System.NotImplementedException();
  }
}
