namespace Rhino.FileIO;

public partial class FileObjWriteOptions
{
  public FileObjWriteOptions() { }

  public FileObjWriteOptions(Rhino.FileIO.FileWriteOptions writeOptions) => throw new System.NotImplementedException();

  public System.Double AngleTolRadians;
  public Rhino.FileIO.FileWriteOptions WriteOptions;

  public virtual Rhino.Geometry.Transform GetTransform() => throw new System.NotImplementedException();

  public virtual System.String ActualFilePathOnMac
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.FileIO.FileObjWriteOptions.AsciiEol EolType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.FileIO.FileObjWriteOptions.CurveType TrimCurveType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.FileIO.FileObjWriteOptions.GeometryType ObjectType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.FileIO.FileObjWriteOptions.ObjObjectNames ExportObjectNames
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.FileIO.FileObjWriteOptions.ObjGroupNames ExportGroupNameLayerNames
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ExportMaterialDefinitions
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseDisplayColorForMaterial
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean MapZtoY
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 SignificantDigits
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean WrapLongLines
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean MergeNestedGroupingNames
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SortObjGroups
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.FileIO.FileObjWriteOptions.VertexWelding MeshType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.FileIO.FileObjWriteOptions.SubDMeshing SubDMeshType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean CreateNgons
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.FileIO.FileObjWriteOptions.NGons NgonMode
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IncludeUnweldedEdgesInNgons
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean CullUnnecessaryVertexesInNgons
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 MinNgonFaceCount
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ExportTcs
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ExportNormals
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ExportAsTriangles
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ExportVcs
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ExportOpenMeshes
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseRenderMeshes
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UnderbarMaterialNames
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseSimpleDialog
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.MeshingParameters MeshParameters
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseRelativeIndexing
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 SubDSurfaceMeshingDensity
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
