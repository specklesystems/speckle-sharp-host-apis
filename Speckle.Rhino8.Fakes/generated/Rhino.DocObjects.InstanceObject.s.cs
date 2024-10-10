namespace Rhino.DocObjects;

public partial class InstanceObject : Rhino.DocObjects.RhinoObject
{
  public InstanceObject() { }

  public virtual System.Boolean UsesDefinition(System.Int32 definitionIndex, out System.Int32 nestingLevel) =>
    throw new System.NotImplementedException();

  public virtual void Explode(
    System.Boolean explodeNestedInstances,
    out Rhino.DocObjects.RhinoObject[] pieces,
    out Rhino.DocObjects.ObjectAttributes[] pieceAttributes,
    out Rhino.Geometry.Transform[] pieceTransforms
  ) => throw new System.NotImplementedException();

  public virtual void Explode(
    System.Boolean skipHiddenPieces,
    System.Guid viewportId,
    System.Boolean explodeNestedInstances,
    out Rhino.DocObjects.RhinoObject[] pieces,
    out Rhino.DocObjects.ObjectAttributes[] pieceAttributes,
    out Rhino.Geometry.Transform[] pieceTransforms
  ) => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.RhinoObject SubObjectFromComponentIndex(Rhino.Geometry.ComponentIndex ci) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Transform InstanceXform
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point3d InsertionPoint
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.InstanceDefinition InstanceDefinition
  {
    get => throw new System.NotImplementedException();
  }
}
