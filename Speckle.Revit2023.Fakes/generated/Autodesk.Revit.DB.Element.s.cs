namespace Autodesk.Revit.DB;

public partial class Element : System.IDisposable
{
  public Element() { }

  public virtual Autodesk.Revit.DB.Parameter get_Parameter(Autodesk.Revit.DB.BuiltInParameter parameterId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Parameter get_Parameter(Autodesk.Revit.DB.Definition definition) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Parameter get_Parameter(System.Guid guid) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Parameter GetParameter(Autodesk.Revit.DB.ForgeTypeId parameterTypeId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.GeometryElement get_Geometry(Autodesk.Revit.DB.Options options) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.BoundingBoxXYZ get_BoundingBox(Autodesk.Revit.DB.View A_0) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsHidden(Autodesk.Revit.DB.View pView) => throw new System.NotImplementedException();

  public virtual System.Boolean CanBeHidden(Autodesk.Revit.DB.View pView) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ChangeType GetChangeTypeParameter(Autodesk.Revit.DB.ElementId parameterId) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ChangeType GetChangeTypeParameter(Autodesk.Revit.DB.Parameter param) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Parameter> GetOrderedParameters() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Parameter> GetParameters(System.String name) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Parameter LookupParameter(System.String name) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CanBeLocked() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementOnPhaseStatus GetPhaseStatus(Autodesk.Revit.DB.ElementId phaseId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetTypeId() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetGeneratingElementIds(
    Autodesk.Revit.DB.GeometryObject geometryObject
  ) => throw new System.NotImplementedException();

  public static System.Boolean CanHaveTypeAssigned(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementIds
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean CanHaveTypeAssigned() => throw new System.NotImplementedException();

  public static System.Boolean IsValidType(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementIds,
    Autodesk.Revit.DB.ElementId typeId
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidType(Autodesk.Revit.DB.ElementId typeId) =>
    throw new System.NotImplementedException();

  public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetValidTypes(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementIds
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetValidTypes() =>
    throw new System.NotImplementedException();

  public static System.Collections.Generic.IDictionary<
    Autodesk.Revit.DB.ElementId,
    Autodesk.Revit.DB.ElementId
  > ChangeTypeId(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementIds,
    Autodesk.Revit.DB.ElementId typeId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId ChangeTypeId(Autodesk.Revit.DB.ElementId typeId) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Subelement> GetSubelements() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean DeleteSubelement(Autodesk.Revit.DB.Subelement subelem) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean DeleteSubelements(
    System.Collections.Generic.IList<Autodesk.Revit.DB.Subelement> subelems
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean CanDeleteSubelement(Autodesk.Revit.DB.Subelement subelem) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetDependentElements(
    Autodesk.Revit.DB.ElementFilter filter
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.GeometryObject GetGeometryObjectFromReference(
    Autodesk.Revit.DB.Reference reference
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsExternalFileReference() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ExternalFileReference GetExternalFileReference() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean RefersToExternalResourceReferences() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IDictionary<
    Autodesk.Revit.DB.ExternalResourceType,
    Autodesk.Revit.DB.ExternalResourceReference
  > GetExternalResourceReferences() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IDictionary<
    Autodesk.Revit.DB.ExternalResourceType,
    System.Collections.Generic.IList<Autodesk.Revit.DB.ExternalResourceReference>
  > GetExternalResourceReferencesExpanded() => throw new System.NotImplementedException();

  public virtual System.Boolean RefersToExternalResourceReference(
    Autodesk.Revit.DB.ExternalResourceType resourceType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ExternalResourceReference GetExternalResourceReference(
    Autodesk.Revit.DB.ExternalResourceType resourceType
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ExternalResourceReference> GetExternalResourceReferenceExpanded(
    Autodesk.Revit.DB.ExternalResourceType resourceType
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetMaterialIds(
    System.Boolean returnPaintMaterials
  ) => throw new System.NotImplementedException();

  public virtual System.Double GetMaterialArea(
    Autodesk.Revit.DB.ElementId materialId,
    System.Boolean usePaintMaterial
  ) => throw new System.NotImplementedException();

  public virtual System.Double GetMaterialVolume(Autodesk.Revit.DB.ElementId materialId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FormatOptions GetParameterFormatOptions(Autodesk.Revit.DB.ElementId parameterId) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ChangeType GetChangeTypeElementDeletion() =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ChangeType GetChangeTypeElementAddition() =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ChangeType GetChangeTypeGeometry() => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ChangeType GetChangeTypeAny() => throw new System.NotImplementedException();

  public virtual System.Boolean IsMonitoringLinkElement() => throw new System.NotImplementedException();

  public virtual System.Boolean IsMonitoringLocalElement() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetMonitoredLinkElementIds() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetMonitoredLocalElementIds() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean HasPhases() => throw new System.NotImplementedException();

  public virtual System.Boolean ArePhasesModifiable() => throw new System.NotImplementedException();

  public virtual System.Boolean IsPhaseCreatedValid(Autodesk.Revit.DB.ElementId createdPhaseId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsPhaseDemolishedValid(Autodesk.Revit.DB.ElementId demolishedPhaseId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsDemolishedPhaseOrderValid(Autodesk.Revit.DB.ElementId demolishedPhaseId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsCreatedPhaseOrderValid(Autodesk.Revit.DB.ElementId createdPhaseId) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Guid> GetEntitySchemaGuids() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ExtensibleStorage.Entity GetEntity(
    Autodesk.Revit.DB.ExtensibleStorage.Schema schema
  ) => throw new System.NotImplementedException();

  public virtual void SetEntity(Autodesk.Revit.DB.ExtensibleStorage.Entity entity) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean DeleteEntity(Autodesk.Revit.DB.ExtensibleStorage.Schema schema) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId DemolishedPhaseId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId CreatedPhaseId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId OwnerViewId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean ViewSpecific
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId AssemblyInstanceId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId LevelId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String UniqueId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsTransient
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId Id
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId GroupId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsModifiable
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Guid VersionGuid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.WorksetId WorksetId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Pinned
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.DesignOption DesignOption
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Document Document
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Location Location
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ParameterMap ParametersMap
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ParameterSet Parameters
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Category Category
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Name
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
