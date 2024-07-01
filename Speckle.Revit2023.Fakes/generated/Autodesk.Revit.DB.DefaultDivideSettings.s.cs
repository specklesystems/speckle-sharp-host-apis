namespace Autodesk.Revit.DB;

public partial class DefaultDivideSettings : Autodesk.Revit.DB.Element
{
  public DefaultDivideSettings() { }

  public static Autodesk.Revit.DB.DefaultDivideSettings GetDefaultDivideSettings(Autodesk.Revit.DB.Document cda) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.SpacingRuleLayout GetSurfaceLayout(Autodesk.Revit.DB.UVGridlineType gridlines) =>
    throw new System.NotImplementedException();

  public virtual void SetSurfaceLayout(
    Autodesk.Revit.DB.UVGridlineType gridlines,
    Autodesk.Revit.DB.SpacingRuleLayout layout
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 GetSurfaceNumber(Autodesk.Revit.DB.UVGridlineType gridlines) =>
    throw new System.NotImplementedException();

  public virtual void SetSurfaceNumber(Autodesk.Revit.DB.UVGridlineType gridlines, System.Int32 number) =>
    throw new System.NotImplementedException();

  public virtual System.Double GetSurfaceDistance(Autodesk.Revit.DB.UVGridlineType gridlines) =>
    throw new System.NotImplementedException();

  public virtual void SetSurfaceDistance(Autodesk.Revit.DB.UVGridlineType gridlines, System.Double distance) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.DividedPathMeasurementType PathMeasurementType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double PathDistance
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 PathNumber
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.SpacingRuleLayout PathLayout
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
