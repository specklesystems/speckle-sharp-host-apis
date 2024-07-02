namespace Rhino.DocObjects;

public partial class HistoryRecord : System.IDisposable
{
  public HistoryRecord() { }

  public HistoryRecord(Rhino.Commands.Command command, System.Int32 version) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean SetBool(System.Int32 id, System.Boolean value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetInt(System.Int32 id, System.Int32 value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetDouble(System.Int32 id, System.Double value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetPoint3d(System.Int32 id, Rhino.Geometry.Point3d value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetVector3d(System.Int32 id, Rhino.Geometry.Vector3d value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetTransorm(System.Int32 id, Rhino.Geometry.Transform value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetColor(System.Int32 id, System.Drawing.Color value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetObjRef(System.Int32 id, Rhino.DocObjects.ObjRef value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetPoint3dOnObject(
    System.Int32 id,
    Rhino.DocObjects.ObjRef objref,
    Rhino.Geometry.Point3d value
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean SetGuid(System.Int32 id, System.Guid value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetString(System.Int32 id, System.String value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetCurve(System.Int32 id, Rhino.Geometry.Curve value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetSurface(System.Int32 id, Rhino.Geometry.Surface value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetBrep(System.Int32 id, Rhino.Geometry.Brep value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetMesh(System.Int32 id, Rhino.Geometry.Mesh value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetBools(
    System.Int32 id,
    System.Collections.Generic.IEnumerable<System.Boolean> values
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean SetInts(System.Int32 id, System.Collections.Generic.IEnumerable<System.Int32> values) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetDoubles(
    System.Int32 id,
    System.Collections.Generic.IEnumerable<System.Double> values
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean SetPoint3ds(
    System.Int32 id,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> values
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean SetVector3ds(
    System.Int32 id,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Vector3d> values
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean SetColors(
    System.Int32 id,
    System.Collections.Generic.IEnumerable<System.Drawing.Color> values
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean SetGuids(System.Int32 id, System.Collections.Generic.IEnumerable<System.Guid> values) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetStrings(
    System.Int32 id,
    System.Collections.Generic.IEnumerable<System.String> values
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean SetHistoryVersion(System.Int32 historyVersion) =>
    throw new System.NotImplementedException();

  public virtual System.IntPtr Handle
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean CopyOnReplaceObject
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
