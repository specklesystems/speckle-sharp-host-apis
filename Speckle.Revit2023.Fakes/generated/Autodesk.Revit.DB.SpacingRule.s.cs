namespace Autodesk.Revit.DB;

public partial class SpacingRule : Autodesk.Revit.DB.APIObject
{
  public SpacingRule() { }

  public virtual void SetLayoutNone() => throw new System.NotImplementedException();

  public virtual void SetLayoutFixedDistance(
    System.Double distance,
    Autodesk.Revit.DB.SpacingRuleJustification just,
    System.Double gridlinesRotation,
    System.Double offset
  ) => throw new System.NotImplementedException();

  public virtual void SetLayoutFixedNumber(
    System.Int32 number,
    Autodesk.Revit.DB.SpacingRuleJustification just,
    System.Double gridlinesRotation,
    System.Double offset
  ) => throw new System.NotImplementedException();

  public virtual void SetLayoutMaximumSpacing(
    System.Double distance,
    Autodesk.Revit.DB.SpacingRuleJustification just,
    System.Double gridlinesRotation,
    System.Double offset
  ) => throw new System.NotImplementedException();

  public virtual void SetLayoutMinimumSpacing(
    System.Double distance,
    Autodesk.Revit.DB.SpacingRuleJustification just,
    System.Double gridlinesRotation,
    System.Double offset
  ) => throw new System.NotImplementedException();

  public virtual System.Double BeltMeasurement
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean HasBeltMeasurement
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Offset
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double GridlinesRotation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.SpacingRuleJustification Justification
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 Number
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Distance
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.SpacingRuleLayout Layout
  {
    get => throw new System.NotImplementedException();
  }
}
