namespace Rhino.FileIO;

public partial class File3dmInstanceDefinitionTable
  : Rhino.FileIO.File3dmCommonComponentTable<Rhino.Geometry.InstanceDefinitionGeometry>
{
  public File3dmInstanceDefinitionTable() { }

  public virtual Rhino.Geometry.InstanceDefinitionGeometry FindName(System.String name) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.InstanceDefinitionGeometry FindNameHash(Rhino.FileIO.NameHash nameHash) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 Add(
    System.String name,
    System.String description,
    System.String url,
    System.String urlTag,
    Rhino.Geometry.Point3d basePoint,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> geometry,
    System.Collections.Generic.IEnumerable<Rhino.DocObjects.ObjectAttributes> attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 Add(
    System.String name,
    System.String description,
    Rhino.Geometry.Point3d basePoint,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> geometry,
    System.Collections.Generic.IEnumerable<Rhino.DocObjects.ObjectAttributes> attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 Add(
    System.String name,
    System.String description,
    Rhino.Geometry.Point3d basePoint,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> geometry
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 Add(
    System.String name,
    System.String description,
    Rhino.Geometry.Point3d basePoint,
    Rhino.Geometry.GeometryBase geometry,
    Rhino.DocObjects.ObjectAttributes attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 AddLinked(System.String filename, System.String name, System.String description) =>
    throw new System.NotImplementedException();

  public override Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
}
