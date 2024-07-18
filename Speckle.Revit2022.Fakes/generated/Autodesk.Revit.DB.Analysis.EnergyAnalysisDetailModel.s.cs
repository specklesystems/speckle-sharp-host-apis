namespace Autodesk.Revit.DB.Analysis;

public partial class EnergyAnalysisDetailModel : Autodesk.Revit.DB.Element
{
  public EnergyAnalysisDetailModel() { }

  public static Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelOptions options
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModel GetMainEnergyAnalysisDetailModel(
    Autodesk.Revit.DB.Document document
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Analysis.EnergyAnalysisSpace> GetAnalyticalSpaces() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface> GetAnalyticalSurfaces() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Analysis.EnergyAnalysisOpening> GetAnalyticalOpenings() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface> GetAnalyticalShadingSurfaces() =>
    throw new System.NotImplementedException();

  public virtual void TransformModel() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId ExportCategory
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId BuildingTypeId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ExportMullions
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean SimplifyCurtainSystems
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IncludeShadingSurfaces
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Analysis.EnergyAnalysisDetailModelTier Tier
  {
    get => throw new System.NotImplementedException();
  }
}
