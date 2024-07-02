namespace Rhino.DocObjects;

public partial class ReplayHistoryData : System.IDisposable
{
  public ReplayHistoryData() { }

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.ObjRef GetRhinoObjRef(System.Int32 id) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetBool(System.Int32 id, out System.Boolean value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetInt(System.Int32 id, out System.Int32 value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetDouble(System.Int32 id, out System.Double value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetPoint3d(System.Int32 id, out Rhino.Geometry.Point3d value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetVector3d(System.Int32 id, out Rhino.Geometry.Vector3d value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetTransform(System.Int32 id, out Rhino.Geometry.Transform value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetColor(System.Int32 id, out System.Drawing.Color value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetPoint3dOnObject(System.Int32 id, out Rhino.Geometry.Point3d value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetGuid(System.Int32 id, out System.Guid value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetString(System.Int32 id, out System.String value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetDoubles(System.Int32 id, out System.Double[] values) =>
    throw new System.NotImplementedException();

  public virtual Rhino.RhinoDoc Document
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 HistoryVersion
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Guid RecordId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.ReplayHistoryResult[] Results
  {
    get => throw new System.NotImplementedException();
  }
}
