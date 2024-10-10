namespace Rhino.FileIO;

public partial class File3dm : System.IDisposable
{
  public File3dm() { }

  public static Rhino.FileIO.File3dm Read(System.String path) => throw new System.NotImplementedException();

  public static Rhino.FileIO.File3dm Read(
    System.String path,
    Rhino.FileIO.File3dm.TableTypeFilter tableTypeFilterFilter,
    Rhino.FileIO.File3dm.ObjectTypeFilter objectTypeFilter
  ) => throw new System.NotImplementedException();

  public static Rhino.FileIO.File3dm ReadWithLog(
    System.String path,
    Rhino.FileIO.File3dm.TableTypeFilter tableTypeFilterFilter,
    Rhino.FileIO.File3dm.ObjectTypeFilter objectTypeFilter,
    out System.String errorLog
  ) => throw new System.NotImplementedException();

  public static Rhino.FileIO.File3dm ReadWithLog(System.String path, out System.String errorLog) =>
    throw new System.NotImplementedException();

  public static Rhino.FileIO.File3dm FromByteArray(System.Byte[] bytes) => throw new System.NotImplementedException();

  public static System.String ReadNotes(System.String path) => throw new System.NotImplementedException();

  public static System.Int32 ReadArchiveVersion(System.String path) => throw new System.NotImplementedException();

  public static System.Boolean ReadRevisionHistory(
    System.String path,
    out System.String createdBy,
    out System.String lastEditedBy,
    out System.Int32 revision,
    out System.DateTime createdOn,
    out System.DateTime lastEditedOn
  ) => throw new System.NotImplementedException();

  public static Rhino.DocObjects.EarthAnchorPoint ReadEarthAnchorPoint(System.String path) =>
    throw new System.NotImplementedException();

  public static void ReadApplicationData(
    System.String path,
    out System.String applicationName,
    out System.String applicationUrl,
    out System.String applicationDetails
  ) => throw new System.NotImplementedException();

  public static System.Boolean WriteOneObject(System.String path, Rhino.Geometry.GeometryBase geometry) =>
    throw new System.NotImplementedException();

  public static System.Boolean WriteMultipleObjects(
    System.String path,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> geometry
  ) => throw new System.NotImplementedException();

  public static System.Drawing.Bitmap ReadPreviewImage(System.String path) =>
    throw new System.NotImplementedException();

  public static Rhino.DocObjects.DimensionStyle[] ReadDimensionStyles(System.String path) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Write(System.String path, System.Int32 version) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Write(System.String path, Rhino.FileIO.File3dmWriteOptions options) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean WriteWithLog(System.String path, System.Int32 version, out System.String errorLog) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean WriteWithLog(
    System.String path,
    Rhino.FileIO.File3dmWriteOptions options,
    out System.String errorLog
  ) => throw new System.NotImplementedException();

  public virtual System.Byte[] ToByteArray() => throw new System.NotImplementedException();

  public virtual System.Byte[] ToByteArray(Rhino.FileIO.File3dmWriteOptions options) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValid(out System.String errors) => throw new System.NotImplementedException();

  public virtual System.Boolean IsValid(Rhino.FileIO.TextLog errors) => throw new System.NotImplementedException();

  public virtual void Polish() => throw new System.NotImplementedException();

  public virtual System.Int32 Audit(
    System.Boolean attemptRepair,
    out System.Int32 repairCount,
    out System.String errors,
    out System.Int32[] warnings
  ) => throw new System.NotImplementedException();

  public virtual System.Drawing.Bitmap GetPreviewImage() => throw new System.NotImplementedException();

  public virtual void SetPreviewImage(System.Drawing.Bitmap image) => throw new System.NotImplementedException();

  public virtual System.String Dump() => throw new System.NotImplementedException();

  public virtual System.String DumpSummary() => throw new System.NotImplementedException();

  public virtual void DumpToTextLog(Rhino.FileIO.TextLog log) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.String StartSectionComments
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 ArchiveVersion
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.File3dmNotes Notes
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String ApplicationName
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String ApplicationUrl
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String ApplicationDetails
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String CreatedBy
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String LastEditedBy
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.DateTime Created
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.DateTime LastEdited
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Revision
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.EarthAnchorPoint EarthAnchorPoint
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.FileIO.File3dmSettings Settings
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.ManifestTable Manifest
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.File3dmObjectTable Objects
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Collections.Generic.IList<Rhino.DocObjects.Material> Materials
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.File3dmMaterialTable AllMaterials
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Collections.Generic.IList<Rhino.DocObjects.Linetype> Linetypes
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.File3dmLinetypeTable AllLinetypes
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Collections.Generic.IList<Rhino.DocObjects.Layer> Layers
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.File3dmLayerTable AllLayers
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.File3dmGroupTable AllGroups
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Collections.Generic.IList<Rhino.DocObjects.DimensionStyle> DimStyles
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.File3dmDimStyleTable AllDimStyles
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Collections.Generic.IList<Rhino.DocObjects.HatchPattern> HatchPatterns
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.File3dmHatchPatternTable AllHatchPatterns
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Collections.Generic.IList<Rhino.Geometry.InstanceDefinitionGeometry> InstanceDefinitions
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.File3dmInstanceDefinitionTable AllInstanceDefinitions
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Collections.Generic.IList<Rhino.DocObjects.ViewInfo> Views
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.File3dmViewTable AllViews
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Collections.Generic.IList<Rhino.DocObjects.ViewInfo> NamedViews
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.File3dmViewTable AllNamedViews
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Collections.Generic.IList<Rhino.DocObjects.ConstructionPlane> NamedConstructionPlanes
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.File3dmNamedConstructionPlanes AllNamedConstructionPlanes
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.File3dmPlugInDataTable PlugInData
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.File3dmStringTable Strings
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.File3dmEmbeddedFiles EmbeddedFiles
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.File3dmRenderMaterials RenderMaterials
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.File3dmRenderEnvironments RenderEnvironments
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.FileIO.File3dmRenderTextures RenderTextures
  {
    get => throw new System.NotImplementedException();
  }
}
