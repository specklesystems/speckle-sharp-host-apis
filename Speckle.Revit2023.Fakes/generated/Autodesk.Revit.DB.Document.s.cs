namespace Autodesk.Revit.DB;

public partial class Document : System.IDisposable
{
  public Document() { }

  public virtual void Save() => throw new System.NotImplementedException();

  public virtual void SaveAs(Autodesk.Revit.DB.ModelPath path, Autodesk.Revit.DB.SaveAsOptions options) =>
    throw new System.NotImplementedException();

  public virtual void SaveAs(System.String filepath, Autodesk.Revit.DB.SaveAsOptions options) =>
    throw new System.NotImplementedException();

  public virtual void SaveAs(System.String filepath) => throw new System.NotImplementedException();

  public virtual void SaveCloudModel() => throw new System.NotImplementedException();

  public virtual void SaveAsCloudModel(
    System.Guid accountId,
    System.Guid projectId,
    System.String folderId,
    System.String modelName
  ) => throw new System.NotImplementedException();

  public virtual void EnableCloudWorksharing() => throw new System.NotImplementedException();

  public virtual void ExportImage(Autodesk.Revit.DB.ImageExportOptions options) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> Link(
    System.String file,
    Autodesk.Revit.DB.DWFImportOptions options
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Link(
    System.String file,
    Autodesk.Revit.DB.DGNImportOptions options,
    Autodesk.Revit.DB.View pDBView,
    out Autodesk.Revit.DB.ElementId elementId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId Link(
    System.String file,
    Autodesk.Revit.DB.ImportOptions3DM options,
    Autodesk.Revit.DB.View pDBView
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId Link(
    System.String file,
    Autodesk.Revit.DB.STLImportOptions options,
    Autodesk.Revit.DB.View pDBView
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId Link(
    System.String file,
    Autodesk.Revit.DB.OBJImportOptions options,
    Autodesk.Revit.DB.View pDBView
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId Link(
    System.String file,
    Autodesk.Revit.DB.SKPImportOptions options,
    Autodesk.Revit.DB.View pDBView
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId Link(
    System.String file,
    Autodesk.Revit.DB.SATImportOptions options,
    Autodesk.Revit.DB.View pDBView
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Link(
    System.String file,
    Autodesk.Revit.DB.DWGImportOptions options,
    Autodesk.Revit.DB.View pDBView,
    out Autodesk.Revit.DB.ElementId elementId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId SaveToProjectAsImage(Autodesk.Revit.DB.ImageExportOptions options) =>
    throw new System.NotImplementedException();

  public virtual void UnpostFailure(Autodesk.Revit.DB.FailureMessageKey messageKey) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FailureMessageKey PostFailure(Autodesk.Revit.DB.FailureMessage failure) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FailureMessage> GetWarnings() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ModelPath GetWorksharingCentralModelPath() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ModelPath GetCloudModelPath() => throw new System.NotImplementedException();

  public virtual System.String GetCloudModelUrn() => throw new System.NotImplementedException();

  public virtual System.String GetHubId() => throw new System.NotImplementedException();

  public virtual System.String GetProjectId() => throw new System.NotImplementedException();

  public virtual System.String GetCloudFolderId(System.Boolean forceRefresh) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetDefaultElementTypeId(
    Autodesk.Revit.DB.ElementTypeGroup defaultTypeId
  ) => throw new System.NotImplementedException();

  public virtual void SetDefaultElementTypeId(
    Autodesk.Revit.DB.ElementTypeGroup defaultTypeId,
    Autodesk.Revit.DB.ElementId typeId
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsDefaultElementTypeIdValid(
    Autodesk.Revit.DB.ElementTypeGroup defaultTypeId,
    Autodesk.Revit.DB.ElementId typeId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetDefaultFamilyTypeId(Autodesk.Revit.DB.ElementId familyCategoryId) =>
    throw new System.NotImplementedException();

  public virtual void SetDefaultFamilyTypeId(
    Autodesk.Revit.DB.ElementId familyCategoryId,
    Autodesk.Revit.DB.ElementId familyTypeId
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsDefaultFamilyTypeIdValid(
    Autodesk.Revit.DB.ElementId familyCategoryId,
    Autodesk.Revit.DB.ElementId familyTypeId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.DocumentPreviewSettings GetDocumentPreviewSettings() =>
    throw new System.NotImplementedException();

  public virtual void MakeTransientElements(Autodesk.Revit.DB.ITransientElementMaker maker) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Element GetElement(Autodesk.Revit.DB.ElementId id) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Element GetElement(System.String uniqueId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Element GetElement(Autodesk.Revit.DB.Reference reference) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Subelement GetSubelement(Autodesk.Revit.DB.ElementId id, System.Int32 subId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Subelement GetSubelement(System.String uniqueId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Subelement GetSubelement(Autodesk.Revit.DB.Reference reference) =>
    throw new System.NotImplementedException();

  public virtual void ReloadLatest(Autodesk.Revit.DB.ReloadLatestOptions reloadOptions) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean HasAllChangesFromCentral() => throw new System.NotImplementedException();

  public virtual void SynchronizeWithCentral(
    Autodesk.Revit.DB.TransactWithCentralOptions transactOptions,
    Autodesk.Revit.DB.SynchronizeWithCentralOptions syncOptions
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsPainted(Autodesk.Revit.DB.ElementId elementId, Autodesk.Revit.DB.Face face) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetPaintedMaterial(
    Autodesk.Revit.DB.ElementId elementId,
    Autodesk.Revit.DB.Face face
  ) => throw new System.NotImplementedException();

  public virtual void RemovePaint(Autodesk.Revit.DB.ElementId elementId, Autodesk.Revit.DB.Face face) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> Delete(
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementIds
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> Delete(
    Autodesk.Revit.DB.ElementId elementId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.DocumentVersion GetDocumentVersion(Autodesk.Revit.DB.Document doc) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.DocumentDifference GetChangedElements(System.Guid baseVersionGUID) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsValidVersionGUID(Autodesk.Revit.DB.Document document, System.Guid versionGUID) =>
    throw new System.NotImplementedException();

  public virtual void AcquireCoordinates(Autodesk.Revit.DB.ElementId linkInstanceId) =>
    throw new System.NotImplementedException();

  public virtual void PublishCoordinates(Autodesk.Revit.DB.LinkElementId locationId) =>
    throw new System.NotImplementedException();

  public virtual void ResetSharedCoordinates() => throw new System.NotImplementedException();

  public virtual System.Boolean IsBackgroundCalculationInProgress() => throw new System.NotImplementedException();

  public virtual void EraseSchemaAndAllEntities(Autodesk.Revit.DB.ExtensibleStorage.Schema schema) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.StorageType GetTypeOfStorage(Autodesk.Revit.DB.ForgeTypeId parameterTypeId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.StorageType get_TypeOfStorage(Autodesk.Revit.DB.BuiltInParameter A_0) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Family LoadFamily(
    Autodesk.Revit.DB.Document targetDocument,
    Autodesk.Revit.DB.IFamilyLoadOptions familyLoadOptions
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Family LoadFamily(Autodesk.Revit.DB.Document targetDocument) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean LoadFamily(
    System.String filename,
    Autodesk.Revit.DB.IFamilyLoadOptions familyLoadOptions,
    out Autodesk.Revit.DB.Family family
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean LoadFamily(System.String filename, out Autodesk.Revit.DB.Family family) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean LoadFamily(System.String filename) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Document EditFamily(Autodesk.Revit.DB.Family loadedFamily) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean LoadFamilySymbol(
    System.String filename,
    System.String name,
    Autodesk.Revit.DB.IFamilyLoadOptions familyLoadOptions,
    out Autodesk.Revit.DB.FamilySymbol symbol
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean LoadFamilySymbol(
    System.String filename,
    System.String name,
    out Autodesk.Revit.DB.FamilySymbol symbol
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean LoadFamilySymbol(System.String filename, System.String name) =>
    throw new System.NotImplementedException();

  public virtual void Print(
    Autodesk.Revit.DB.ViewSet views,
    Autodesk.Revit.DB.View viewTemplate,
    System.Boolean useCurrentPrintSettings
  ) => throw new System.NotImplementedException();

  public virtual void Print(Autodesk.Revit.DB.ViewSet views, Autodesk.Revit.DB.View viewTemplate) =>
    throw new System.NotImplementedException();

  public virtual void Print(Autodesk.Revit.DB.ViewSet views, System.Boolean useCurrentPrintSettings) =>
    throw new System.NotImplementedException();

  public virtual void Print(Autodesk.Revit.DB.ViewSet views) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.PlanTopology get_PlanTopology(
    Autodesk.Revit.DB.Level level,
    Autodesk.Revit.DB.Phase phase
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.PlanTopology get_PlanTopology(Autodesk.Revit.DB.Level level) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.PlanTopologySet get_PlanTopologies(Autodesk.Revit.DB.Phase phase) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Close() => throw new System.NotImplementedException();

  public virtual System.Boolean Close(System.Boolean saveModified) => throw new System.NotImplementedException();

  public virtual System.Boolean Export(
    System.String folder,
    System.String name,
    Autodesk.Revit.DB.GBXMLExportOptions options
  ) => throw new System.NotImplementedException();

  public virtual void Export(
    System.String folder,
    System.String name,
    Autodesk.Revit.DB.Analysis.MassGBXMLExportOptions options
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Export(
    System.String folder,
    System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> viewIds,
    Autodesk.Revit.DB.PDFExportOptions options
  ) => throw new System.NotImplementedException();

  public virtual void Export(
    System.String folder,
    System.String name,
    Autodesk.Revit.DB.NavisworksExportOptions options
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Export(
    System.String folder,
    System.String name,
    Autodesk.Revit.DB.OBJExportOptions options
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Export(
    System.String folder,
    System.String name,
    Autodesk.Revit.DB.STLExportOptions options
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Export(
    System.String folder,
    System.String name,
    Autodesk.Revit.DB.IFCExportOptions options
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Export(
    System.String folder,
    System.String name,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> views,
    Autodesk.Revit.DB.SATExportOptions options
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Export(
    System.String folder,
    System.String name,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> views,
    Autodesk.Revit.DB.DGNExportOptions options
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Export(
    System.String folder,
    System.String name,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> views,
    Autodesk.Revit.DB.DXFExportOptions options
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Export(
    System.String folder,
    System.String name,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> views,
    Autodesk.Revit.DB.DWGExportOptions options
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Export(
    System.String folder,
    System.String name,
    Autodesk.Revit.DB.ViewSet views,
    Autodesk.Revit.DB.FBXExportOptions options
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Export(
    System.String folder,
    System.String name,
    Autodesk.Revit.DB.ViewSet views,
    Autodesk.Revit.DB.DWFXExportOptions options
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Export(
    System.String folder,
    System.String name,
    Autodesk.Revit.DB.ViewSet views,
    Autodesk.Revit.DB.DWFExportOptions options
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId Import(
    System.String file,
    Autodesk.Revit.DB.AXMImportOptions options,
    Autodesk.Revit.DB.View pDBView
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Import(
    System.String file,
    Autodesk.Revit.DB.DGNImportOptions options,
    Autodesk.Revit.DB.View pDBView,
    out Autodesk.Revit.DB.ElementId elementId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId Import(
    System.String file,
    Autodesk.Revit.DB.ImportOptions3DM options,
    Autodesk.Revit.DB.View pDBView
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId Import(
    System.String file,
    Autodesk.Revit.DB.STLImportOptions options,
    Autodesk.Revit.DB.View pDBView
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId Import(
    System.String file,
    Autodesk.Revit.DB.OBJImportOptions options,
    Autodesk.Revit.DB.View pDBView
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId Import(
    System.String file,
    Autodesk.Revit.DB.SKPImportOptions options,
    Autodesk.Revit.DB.View pDBView
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId Import(
    System.String file,
    Autodesk.Revit.DB.SATImportOptions options,
    Autodesk.Revit.DB.View pDBView
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Import(
    System.String file,
    Autodesk.Revit.DB.DWGImportOptions options,
    Autodesk.Revit.DB.View pDBView,
    out Autodesk.Revit.DB.ElementId elementId
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Import(System.String file, Autodesk.Revit.DB.GBXMLImportOptions options) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetPrintSettingIds() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Architecture.Room GetRoomAtPoint(Autodesk.Revit.DB.XYZ point) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Architecture.Room GetRoomAtPoint(
    Autodesk.Revit.DB.XYZ point,
    Autodesk.Revit.DB.Phase phase
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.Space GetSpaceAtPoint(Autodesk.Revit.DB.XYZ point) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.Space GetSpaceAtPoint(
    Autodesk.Revit.DB.XYZ point,
    Autodesk.Revit.DB.Phase phase
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.GeomCombination CombineElements(Autodesk.Revit.DB.CombinableElementArray members) =>
    throw new System.NotImplementedException();

  public virtual void SeparateElements(Autodesk.Revit.DB.CombinableElementArray members) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.DetailCurveArray ConvertModelToDetailCurves(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.ModelCurveArray modelCurves
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ModelCurveArray ConvertDetailToModelCurves(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.DetailCurveArray detailCurves
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.SymbolicCurveArray ConvertModelToSymbolicCurves(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.ModelCurveArray modelCurves
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ModelCurveArray ConvertSymbolicToModelCurves(
    Autodesk.Revit.DB.View view,
    Autodesk.Revit.DB.SymbolicCurveArray symbolicCurve
  ) => throw new System.NotImplementedException();

  public virtual void Regenerate() => throw new System.NotImplementedException();

  public virtual void AutoJoinElements() => throw new System.NotImplementedException();

  public virtual void Paint(
    Autodesk.Revit.DB.ElementId elementId,
    Autodesk.Revit.DB.Face face,
    Autodesk.Revit.DB.ElementId materialId
  ) => throw new System.NotImplementedException();

  public virtual void Paint(
    Autodesk.Revit.DB.ElementId elementId,
    Autodesk.Revit.DB.Face face,
    Autodesk.Revit.DB.FamilyParameter familyParameter
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.WorksetTable GetWorksetTable() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Units GetUnits() => throw new System.NotImplementedException();

  public virtual void SetUnits(Autodesk.Revit.DB.Units units) => throw new System.NotImplementedException();

  public virtual System.Boolean CanEnableCloudWorksharing() => throw new System.NotImplementedException();

  public virtual System.Boolean CanEnableWorksharing() => throw new System.NotImplementedException();

  public virtual void EnableWorksharing(System.String worksetNameGridLevel, System.String worksetName) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.WorksetId GetWorksetId(Autodesk.Revit.DB.ElementId id) =>
    throw new System.NotImplementedException();

  public virtual void Save(Autodesk.Revit.DB.SaveOptions options) => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.MassDisplayTemporaryOverrideType MassDisplayTemporaryOverride
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Guid WorksharingCentralGUID
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsModelInCloud
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsDetached
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsWorkshared
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsLinked
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsReadOnlyFile
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsReadOnly
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsModified
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsModifiable
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Title
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String PathName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.ApplicationServices.Application Application
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Family OwnerFamily
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsFamilyDocument
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.PrintManager PrintManager
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.SiteLocation SiteLocation
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ProjectLocation ActiveProjectLocation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ProjectLocationSet ProjectLocations
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.View ActiveView
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.FamilyManager FamilyManager
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.Creation.FamilyItemFactory FamilyCreate
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.Creation.Document Create
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.PlanTopologySet PlanTopologies
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ProjectInfo ProjectInformation
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean ReactionsAreUpToDate
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.PhaseArray Phases
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.PanelTypeSet PanelTypes
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.MullionTypeSet MullionTypes
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.BindingMap ParameterBindings
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.DisplayUnit DisplayUnitSystem
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Settings Settings
  {
    get => throw new System.NotImplementedException();
  }
}
