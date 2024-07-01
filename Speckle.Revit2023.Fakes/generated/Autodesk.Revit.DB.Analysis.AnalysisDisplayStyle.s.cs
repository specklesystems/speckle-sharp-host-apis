namespace Autodesk.Revit.DB.Analysis;

public partial class AnalysisDisplayStyle : Autodesk.Revit.DB.Element
{
  public AnalysisDisplayStyle() { }

  public static Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle CreateAnalysisDisplayStyle(
    Autodesk.Revit.DB.Document document,
    System.String name,
    Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings deformedShapeSettings,
    Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings colorSettings,
    Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings legendSettings
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle CreateAnalysisDisplayStyle(
    Autodesk.Revit.DB.Document document,
    System.String name,
    Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings vectorSettings,
    Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings colorSettings,
    Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings legendSettings
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle CreateAnalysisDisplayStyle(
    Autodesk.Revit.DB.Document document,
    System.String name,
    Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings diagramSettings,
    Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings colorSettings,
    Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings legendSettings
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle CreateAnalysisDisplayStyle(
    Autodesk.Revit.DB.Document document,
    System.String name,
    Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings markersAndTextSettings,
    Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings colorSettings,
    Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings legendSettings
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle CreateAnalysisDisplayStyle(
    Autodesk.Revit.DB.Document document,
    System.String name,
    Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings coloredSurfaceSettings,
    Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings colorSettings,
    Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings legendSettings
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetElements(
    Autodesk.Revit.DB.Document document
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ElementId FindByName(Autodesk.Revit.DB.Document document, System.String name) =>
    throw new System.NotImplementedException();

  public virtual void SetName(System.String name) => throw new System.NotImplementedException();

  public static System.Boolean IsNameUnique(
    Autodesk.Revit.DB.Document document,
    System.String name,
    Autodesk.Revit.DB.Analysis.AnalysisDisplayStyle excludedElement
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings GetColorSettings() =>
    throw new System.NotImplementedException();

  public virtual void SetColorSettings(Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings colorSettings) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings GetLegendSettings() =>
    throw new System.NotImplementedException();

  public virtual void SetLegendSettings(Autodesk.Revit.DB.Analysis.AnalysisDisplayLegendSettings legendSettings) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean HasColoredSurfaceSettings() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings GetColoredSurfaceSettings() =>
    throw new System.NotImplementedException();

  public virtual void SetColoredSurfaceSettings(
    Autodesk.Revit.DB.Analysis.AnalysisDisplayColoredSurfaceSettings coloredSurfaceSettings
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean HasMarkersAndTextSettings() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings GetMarkersAndTextSettings() =>
    throw new System.NotImplementedException();

  public virtual void SetMarkersAndTextSettings(
    Autodesk.Revit.DB.Analysis.AnalysisDisplayMarkersAndTextSettings markersAndTextSettings
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean HasDiagramSettings() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings GetDiagramSettings() =>
    throw new System.NotImplementedException();

  public virtual void SetDiagramSettings(Autodesk.Revit.DB.Analysis.AnalysisDisplayDiagramSettings diagramSettings) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean HasVectorSettings() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings GetVectorSettings() =>
    throw new System.NotImplementedException();

  public virtual void SetVectorSettings(Autodesk.Revit.DB.Analysis.AnalysisDisplayVectorSettings vectorSettings) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean HasDeformedShapeSettings() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings GetDeformedShapeSettings() =>
    throw new System.NotImplementedException();

  public virtual void SetDeformedShapeSettings(
    Autodesk.Revit.DB.Analysis.AnalysisDisplayDeformedShapeSettings deformedShapeSettings
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsTextTypeIdValid(
    Autodesk.Revit.DB.ElementId textTypeId,
    Autodesk.Revit.DB.Document doc
  ) => throw new System.NotImplementedException();
}
