namespace Autodesk.Revit.DB;

public partial class FabricationConfiguration : Autodesk.Revit.DB.Element
{
  public FabricationConfiguration() { }

  public static Autodesk.Revit.DB.FabricationConfiguration GetFabricationConfiguration(
    Autodesk.Revit.DB.Document document
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean HasValidConfiguration() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FabricationConfigurationInfo GetFabricationConfigurationInfo() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CanBeSwapped() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ConfigurationReloadInfo ReloadConfiguration() =>
    throw new System.NotImplementedException();

  public virtual void SetConfiguration(
    Autodesk.Revit.DB.FabricationConfigurationInfo fabricationConfigurationInfo,
    System.String profile
  ) => throw new System.NotImplementedException();

  public virtual void SetConfiguration(Autodesk.Revit.DB.FabricationConfigurationInfo fabricationConfigurationInfo) =>
    throw new System.NotImplementedException();

  public virtual System.String GetProfile() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FabricationService> GetAllServices() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FabricationService> GetAllLoadedServices() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetServicesToLoad(System.Collections.Generic.IList<System.Int32> serviceIds) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FabricationService> GetAllUsedServices() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FabricationItemFile> GetAllUsedItemFiles() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Int32> LoadServices(
    System.Collections.Generic.IList<System.Int32> serviceIds
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FabricationItemFile> LoadItemFiles(
    System.Collections.Generic.IList<Autodesk.Revit.DB.FabricationItemFile> itemFiles
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean CanUnloadItemFiles(
    System.Collections.Generic.IList<Autodesk.Revit.DB.FabricationItemFile> itemFiles
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean AreItemFilesLoaded(
    System.Collections.Generic.IList<Autodesk.Revit.DB.FabricationItemFile> itemFiles
  ) => throw new System.NotImplementedException();

  public virtual void UnloadServices(System.Collections.Generic.IList<System.Int32> serviceIds) =>
    throw new System.NotImplementedException();

  public virtual void UnloadItemFiles(
    System.Collections.Generic.IList<Autodesk.Revit.DB.FabricationItemFile> itemFiles
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FabricationService GetService(System.Int32 serviceId) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Int32> GetAllSpecifications(
    Autodesk.Revit.DB.FabricationPart part
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 LocateSpecification(System.String group, System.String name) =>
    throw new System.NotImplementedException();

  public virtual System.String GetSpecificationName(System.Int32 specId) => throw new System.NotImplementedException();

  public virtual System.String GetSpecificationGroup(System.Int32 specId) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Int32> GetAllDampers() =>
    throw new System.NotImplementedException();

  public virtual System.String GetDamperName(System.Int32 damperId) => throw new System.NotImplementedException();

  public virtual System.Boolean DamperExists(System.Int32 damperId) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Int32> GetAllPartStatuses() =>
    throw new System.NotImplementedException();

  public virtual System.String GetPartStatusDescription(System.Int32 statusId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CustomDataExists(System.Int32 customDataId) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Int32> GetAllPartCustomData() =>
    throw new System.NotImplementedException();

  public virtual System.String GetPartCustomDataName(System.Int32 customDataId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Fabrication.FabricationCustomDataType GetPartCustomDataType(
    System.Int32 customDataId
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Int32> GetAllInsulationSpecifications(
    Autodesk.Revit.DB.FabricationPart pFabPart
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 LocateInsulationSpecification(System.String group, System.String name) =>
    throw new System.NotImplementedException();

  public virtual System.String GetInsulationSpecificationName(System.Int32 specId) =>
    throw new System.NotImplementedException();

  public virtual System.String GetInsulationSpecificationGroup(System.Int32 specId) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Int32> GetAllMaterials(
    Autodesk.Revit.DB.FabricationPart part
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 LocateMaterial(System.String group, System.String name) =>
    throw new System.NotImplementedException();

  public virtual System.String GetMaterialGroup(System.Int32 materialId) => throw new System.NotImplementedException();

  public virtual System.String GetMaterialName(System.Int32 materialId) => throw new System.NotImplementedException();

  public virtual System.String GetMaterialAbbreviation(System.Int32 materialId) =>
    throw new System.NotImplementedException();

  public virtual System.String GetSpecificationAbbreviation(System.Int32 specificationId) =>
    throw new System.NotImplementedException();

  public virtual System.String GetInsulationSpecificationAbbreviation(System.Int32 insulationSpecificationId) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Int32> GetAllFabricationConnectorDefinitions(
    Autodesk.Revit.DB.ConnectorDomainType domain,
    Autodesk.Revit.DB.ConnectorProfileType shape
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 LocateFabricationConnector(
    System.String group,
    System.String name,
    Autodesk.Revit.DB.ConnectorDomainType domain,
    Autodesk.Revit.DB.ConnectorProfileType shape
  ) => throw new System.NotImplementedException();

  public virtual System.String GetFabricationConnectorName(System.Int32 fabricationConnectorId) =>
    throw new System.NotImplementedException();

  public virtual System.String GetFabricationConnectorGroup(System.Int32 fabricationConnectorId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ConnectorProfileType GetFabricationConnectorShape(
    System.Int32 fabricationConnectorId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ConnectorDomainType GetFabricationConnectorDomain(
    System.Int32 fabricationConnectorId
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 GetServiceByGUID(System.Guid serviceGUID) => throw new System.NotImplementedException();

  public virtual System.Guid GetServiceGUID(System.Int32 serviceId) => throw new System.NotImplementedException();

  public virtual System.Int32 GetSpecificationByGUID(System.Guid specificationGUID) =>
    throw new System.NotImplementedException();

  public virtual System.Guid GetSpecificationGUID(System.Int32 specificationId) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 GetMaterialByGUID(System.Guid materialGUID) => throw new System.NotImplementedException();

  public virtual System.Guid GetMaterialGUID(System.Int32 materialId) => throw new System.NotImplementedException();

  public virtual System.Int32 GetMaterialGaugeByGUID(System.Guid gaugeGUID, System.Int32 materialId) =>
    throw new System.NotImplementedException();

  public virtual System.Guid GetMaterialGaugeGUID(System.Int32 materialId, System.Int32 gaugeId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean AncillaryExists(System.Int32 ancillaryId) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Int32> GetAncillaries(
    Autodesk.Revit.DB.Fabrication.FabricationAncillaryType type,
    System.Boolean includeKits,
    System.Boolean filterKits
  ) => throw new System.NotImplementedException();

  public virtual System.String GetAncillaryName(System.Int32 ancillaryId) => throw new System.NotImplementedException();

  public virtual System.String GetAncillaryGroup(System.Int32 ancillaryId) =>
    throw new System.NotImplementedException();

  public virtual System.String GetAncillaryGroupName(System.Int32 ancillaryId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsAncillaryKit(System.Int32 ancillaryId) => throw new System.NotImplementedException();

  public virtual System.String GetServiceTypeName(System.Int32 serviceTypeId) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FabricationItemFolder> GetItemFolders() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FabricationItemFile> GetAllLoadedItemFiles() =>
    throw new System.NotImplementedException();
}
