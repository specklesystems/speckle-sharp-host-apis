namespace Rhino.DocObjects;

public partial class GripObject : Rhino.DocObjects.RhinoObject
{
  public GripObject() { }

  public virtual void Move(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();

  public virtual void Move(Rhino.Geometry.Vector3d delta) => throw new System.NotImplementedException();

  public virtual void Move(Rhino.Geometry.Point3d newLocation) => throw new System.NotImplementedException();

  public virtual void UndoMove() => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.GripObject NeighborGrip(
    System.Int32 directionR,
    System.Int32 directionS,
    System.Int32 directionT,
    System.Boolean wrap
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean GetGripDirections(
    out Rhino.Geometry.Vector3d u,
    out Rhino.Geometry.Vector3d v,
    out Rhino.Geometry.Vector3d normal
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean GetSurfaceParameters(out System.Double u, out System.Double v) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 GetCurveCVIndices(out System.Int32[] cvIndices) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetCageParameters(out System.Double u, out System.Double v, out System.Double w) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetCurveParameters(out System.Double t) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d CurrentLocation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point3d OriginalLocation
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Moved
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Weight
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Guid OwnerId
  {
    get => throw new System.NotImplementedException();
  }
  public override System.Int32 Index
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
