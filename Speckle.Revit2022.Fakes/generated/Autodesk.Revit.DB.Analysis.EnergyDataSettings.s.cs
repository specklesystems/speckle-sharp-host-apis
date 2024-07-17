namespace Autodesk.Revit.DB.Analysis;

public partial class EnergyDataSettings : Autodesk.Revit.DB.Element
{
  public EnergyDataSettings() { }

  public static Autodesk.Revit.DB.Analysis.EnergyDataSettings GetFromDocument(Autodesk.Revit.DB.Document cda) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsDocumentUsingEnergyDataAnalyticalModel(Autodesk.Revit.DB.Document ccda) =>
    throw new System.NotImplementedException();

  public static System.Boolean CheckRangeOfSliverSpaceTolerance(System.Double silverSpaceTolerance) =>
    throw new System.NotImplementedException();

  public static System.Boolean CheckRangeOfPercentageGlazing(System.Double percentageGlazing) =>
    throw new System.NotImplementedException();

  public static System.Boolean CheckRangeOfSillHeight(System.Double sillHeight) =>
    throw new System.NotImplementedException();

  public static System.Boolean CheckRangeOfShadeDepth(System.Double shadeDepth) =>
    throw new System.NotImplementedException();

  public static System.Boolean CheckRangeOfPercentageSkylights(System.Double percentageSkylights) =>
    throw new System.NotImplementedException();

  public static System.Boolean CheckRangeOfSkylightWidth(System.Double skylightWidth) =>
    throw new System.NotImplementedException();

  public static System.Boolean CheckExportCategory(Autodesk.Revit.DB.ElementId exportCategoryId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CheckConstructionSetElement(Autodesk.Revit.DB.ElementId constructionSetElementId) =>
    throw new System.NotImplementedException();

  public static System.Boolean CheckGroundPlane(
    Autodesk.Revit.DB.Document ccda,
    Autodesk.Revit.DB.ElementId groundPlaneId
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean CheckGroundPlane(Autodesk.Revit.DB.ElementId groundPlaneId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CheckProjectPhase(Autodesk.Revit.DB.ElementId projectPhaseId) =>
    throw new System.NotImplementedException();

  public static System.Boolean CheckExportComplexity(
    Autodesk.Revit.DB.Analysis.gbXMLExportComplexity exportComplexity
  ) => throw new System.NotImplementedException();

  public static System.Boolean CheckBuildingConstructionClass(
    Autodesk.Revit.DB.Analysis.HVACLoadConstructionClass buildingConstructionClass
  ) => throw new System.NotImplementedException();

  public static System.Boolean CheckProjectReportType(
    Autodesk.Revit.DB.Analysis.HVACLoadLoadsReportType projectReportType
  ) => throw new System.NotImplementedException();

  public static System.Boolean CheckBuildingOperatingSchedule(
    Autodesk.Revit.DB.Analysis.gbXMLBuildingOperatingSchedule buildingOperatingSchedule
  ) => throw new System.NotImplementedException();

  public static System.Boolean CheckBuildingHVACSystem(
    Autodesk.Revit.DB.Analysis.gbXMLBuildingHVACSystem buildingHVACSystem
  ) => throw new System.NotImplementedException();

  public static System.Boolean CheckBuildingType(Autodesk.Revit.DB.Analysis.gbXMLBuildingType buildingType) =>
    throw new System.NotImplementedException();

  public static System.Boolean CheckServiceType(Autodesk.Revit.DB.Analysis.gbXMLServiceType serviceType) =>
    throw new System.NotImplementedException();

  public static System.Boolean CheckBuildingEnvelope(
    Autodesk.Revit.DB.Analysis.gbXMLExportBuildingEnvelope determinationMethod
  ) => throw new System.NotImplementedException();

  public static System.Boolean CheckAnalysisType(Autodesk.Revit.DB.Analysis.AnalysisMode analysisType) =>
    throw new System.NotImplementedException();

  public static System.Boolean EnableConceptualEnergyAnalyticalModel() => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ElementId GetBuildingConstructionSetElementId(Autodesk.Revit.DB.Document ccda) =>
    throw new System.NotImplementedException();

  public virtual void SetCreateAnalyticalModel(System.Boolean createAnalyticalModel) =>
    throw new System.NotImplementedException();

  public virtual System.String GetReportsFolderParsed() => throw new System.NotImplementedException();

  public virtual void SetReportsFolder(System.String folderPath) => throw new System.NotImplementedException();

  public virtual System.Boolean DividePerimeter
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean EnergyModel
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Analysis.gbXMLBuildingType BuildingType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double CoreOffset
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsExportMullionsEnabled
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsExportSimplifiedCurtainSystemsEnabled
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsExportShadingSurfacesEnabled
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ReportsFolder
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double AnalyticalGridCellSize
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Analysis.gbXMLExportBuildingEnvelope BuildingEnvelopeDeterminationMethod
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IncludeThermalProperties
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseAirChangesPerHour
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseOutsideAirPerArea
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseOutsideAirPerPerson
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsGlazingShaded
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean CreateAnalyticalModel
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean UseHeatingCredits
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ExportDefaults
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Analysis.gbXMLServiceType ServiceType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId BuildingTypeId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Analysis.AnalysisMode AnalysisType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId ProjectPhase
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId GroundPlane
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId ExportCategory
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Analysis.gbXMLBuildingHVACSystem BuildingHVACSystem
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Analysis.gbXMLBuildingOperatingSchedule BuildingOperatingSchedule
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Analysis.HVACLoadLoadsReportType ProjectReportType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Analysis.HVACLoadConstructionClass BuildingConstructionClass
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Analysis.gbXMLExportComplexity ExportComplexity
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double OutsideAirChangesRatePerHour
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double OutsideAirPerArea
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double OutsideAirPerPerson
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double SkylightWidth
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double PercentageSkylights
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ShadeDepth
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double SillHeight
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double PercentageGlazing
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double SliverSpaceTolerance
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
