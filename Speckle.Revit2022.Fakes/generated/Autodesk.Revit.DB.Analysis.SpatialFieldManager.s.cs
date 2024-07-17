namespace Autodesk.Revit.DB.Analysis;

public partial class SpatialFieldManager : Autodesk.Revit.DB.Element
{
  public SpatialFieldManager() { }

  public static Autodesk.Revit.DB.Analysis.SpatialFieldManager CreateSpatialFieldManager(
    Autodesk.Revit.DB.View view,
    System.Int32 numberOfMeasurements
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Analysis.SpatialFieldManager GetSpatialFieldManager(Autodesk.Revit.DB.View view) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 AddSpatialFieldPrimitive(
    Autodesk.Revit.DB.Curve curve,
    Autodesk.Revit.DB.Transform trf
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 AddSpatialFieldPrimitive(Autodesk.Revit.DB.Face face, Autodesk.Revit.DB.Transform trf) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 AddSpatialFieldPrimitive(
    Autodesk.Revit.DB.Reference reference,
    Autodesk.Revit.DB.Analysis.SpatialFieldPrimitiveHideMode hidingMode
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 AddSpatialFieldPrimitive(Autodesk.Revit.DB.Reference reference) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 AddSpatialFieldPrimitive() => throw new System.NotImplementedException();

  public virtual void RemoveSpatialFieldPrimitive(System.Int32 idx) => throw new System.NotImplementedException();

  public virtual void UpdateSpatialFieldPrimitive(
    System.Int32 idx,
    Autodesk.Revit.DB.Analysis.FieldDomainPoints fieldDomainPoints,
    Autodesk.Revit.DB.Analysis.FieldValues fieldValues,
    System.Int32 resultIndex
  ) => throw new System.NotImplementedException();

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Analysis.AnalysisDisplayLegend GetLegend() =>
    throw new System.NotImplementedException();

  public virtual System.Double GetMinimum(System.Int32 resultIndex, System.Boolean rawValue) =>
    throw new System.NotImplementedException();

  public virtual System.Double GetMaximum(System.Int32 resultIndex, System.Boolean rawValue) =>
    throw new System.NotImplementedException();

  public virtual void SetMeasurementNames(System.Collections.Generic.IList<System.String> measurementNames) =>
    throw new System.NotImplementedException();

  public virtual void SetMeasurementDescriptions(
    System.Collections.Generic.IList<System.String> measurementDescriptions
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsResultSchemaNameUnique(System.String name, System.Int32 resultIndexToSkip) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 RegisterResult(Autodesk.Revit.DB.Analysis.AnalysisResultSchema resultSchema) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Analysis.AnalysisResultSchema GetResultSchema(System.Int32 idx) =>
    throw new System.NotImplementedException();

  public virtual void SetResultSchema(System.Int32 idx, Autodesk.Revit.DB.Analysis.AnalysisResultSchema resultSchema) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Int32> GetRegisteredResults() =>
    throw new System.NotImplementedException();

  public static System.Boolean IsTextTypeIdValid(
    Autodesk.Revit.DB.ElementId textTypeId,
    Autodesk.Revit.DB.Document doc
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean LegendShowDescription
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean LegendShowConfigurationName
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId LegendTextTypeId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ResultsVisibleInView
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseRangeForAllMeasurements
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 CurrentMeasurement
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ LegendPosition
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 NumberOfMeasurements
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean AllowInteractiveSettings
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
