namespace Autodesk.Revit.ApplicationServices;

public partial class Application : System.IDisposable
{
  public Application() { }

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Document NewProjectDocument(Autodesk.Revit.DB.UnitSystem unitSystem) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Document NewProjectDocument(System.String templateFileName) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Document NewProjectTemplateDocument(System.String templateFilename) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Document NewFamilyDocument(System.String templateFileName) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Document OpenBuildingComponentDocument(System.String fileName) =>
    throw new System.NotImplementedException();

  public virtual void ExtractPartAtomFromFamilyFile(System.String familyFilePath, System.String xmlFilePath) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.DefinitionFile OpenSharedParameterFile() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Document OpenIFCDocument(System.String fileName) =>
    throw new System.NotImplementedException();

  public static void RegisterFailuresProcessor(Autodesk.Revit.DB.IFailuresProcessor processor) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.FailureDefinitionRegistry GetFailureDefinitionRegistry() =>
    throw new System.NotImplementedException();

  public virtual void WriteJournalComment(System.String comment, System.Boolean timeStamp) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsJournalPlaying() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.String> GetSystemsAnalysisWorkflowNames() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IDictionary<System.String, System.String> GetSystemsAnalysisWorkflows() =>
    throw new System.NotImplementedException();

  public virtual void SetSystemsAnalysisWorkflows(
    System.Collections.Generic.IDictionary<System.String, System.String> paths
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IDictionary<System.String, System.String> GetLibraryPaths() =>
    throw new System.NotImplementedException();

  public virtual void SetLibraryPaths(System.Collections.Generic.IDictionary<System.String, System.String> paths) =>
    throw new System.NotImplementedException();

  public virtual void PurgeReleasedAPIObjects() => throw new System.NotImplementedException();

  public virtual void CopyModel(
    Autodesk.Revit.DB.ModelPath sourceModelPath,
    System.String destFilePath,
    System.Boolean overwrite
  ) => throw new System.NotImplementedException();

  public virtual System.Guid GetWorksharingCentralGUID(Autodesk.Revit.DB.ServerPath serverModelPath) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.String> GetRevitServerNetworkHosts() =>
    throw new System.NotImplementedException();

  public static System.Boolean IsValidThickness(System.Double thickness) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Document OpenDocumentFile(System.String fileName) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Document OpenDocumentFile(
    Autodesk.Revit.DB.ModelPath modelPath,
    Autodesk.Revit.DB.OpenOptions openOptions,
    Autodesk.Revit.DB.IOpenFromCloudCallback openFromCloudCallback
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Document OpenDocumentFile(
    Autodesk.Revit.DB.ModelPath modelPath,
    Autodesk.Revit.DB.OpenOptions openOptions
  ) => throw new System.NotImplementedException();

  public virtual void UpdateRenderAppearanceLibrary() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean AllowNavigationDuringRedraw
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String LoginUserId
  {
    get => throw new System.NotImplementedException();
  }
  public static System.Boolean IsLoggedIn
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Color BackgroundColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String CurrentUsersAddinsDataFolderPath
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String CurrentUsersDataFolderPath
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String AllUsersAddinsLocation
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String CurrentUserAddinsLocation
  {
    get => throw new System.NotImplementedException();
  }
  public static System.Double MinimumThickness
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double ShortCurveTolerance
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String CurrentRevitServerAccelerator
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsInfrastructureEnabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsRouteAnalysisEnabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsPipingAnalysisEnabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsElectricalAnalysisEnabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsMechanicalAnalysisEnabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsPipingEnabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsElectricalEnabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsMechanicalEnabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsStructuralAnalysisEnabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsEnergyAnalysisEnabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsMassingEnabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsSystemsEnabled
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsStructureEnabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsArchitectureEnabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double AngleTolerance
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double VertexTolerance
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ViewDiscipline DefaultViewDiscipline
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowGraphicalWarningHangerDisconnects
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowGraphicalWarningElectricalDisconnects
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowGraphicalWarningCableTrayConduitDisconnects
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowGraphicalWarningPipeDisconnects
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowGraphicalWarningDuctDisconnects
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String ImportIFCCategoryTable
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ExportIFCCategoryTable
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String DefaultIFCProjectTemplate
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String DefaultProjectTemplate
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String SystemsAnalysisWorkfilesRootPath
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String PointCloudsRootPath
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String FamilyTemplatePath
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String SubVersionNumber
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Username
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.AddInId ActiveAddInId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String SharedParametersFilename
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.ApplicationServices.ProductType Product
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.ApplicationServices.LanguageType Language
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.CitySet Cities
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String VersionBuild
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String VersionNumber
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String VersionName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.Creation.Application Create
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String RecordingJournalFilename
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.DocumentSet Documents
  {
    get => throw new System.NotImplementedException();
  }
}
