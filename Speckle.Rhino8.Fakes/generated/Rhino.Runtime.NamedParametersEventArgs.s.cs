namespace Rhino.Runtime;

public partial class NamedParametersEventArgs : System.EventArgs, System.IDisposable
{
  public NamedParametersEventArgs() { }

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetString(System.String name, out System.String value) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, System.String value) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetStrings(System.String name, out System.String[] value) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, System.Collections.Generic.IEnumerable<System.String> strings) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetObjRefs(System.String name, out Rhino.DocObjects.ObjRef[] value) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, System.Collections.Generic.IEnumerable<Rhino.DocObjects.ObjRef> values) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetUints(System.String name, out System.UInt32[] value) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, System.Collections.Generic.IEnumerable<System.UInt32> values) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetGuids(System.String name, out System.Guid[] value) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, System.Collections.Generic.IEnumerable<System.Guid> guidList) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetBool(System.String name, out System.Boolean value) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, System.Boolean value) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetInt(System.String name, out System.Int32 value) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, System.Int32 value) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetUnsignedInt(System.String name, out System.UInt32 value) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, System.UInt32 value) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetDouble(System.String name, out System.Double value) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, System.Double value) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetPoint2i(System.String name, out System.Drawing.Point value) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, System.Drawing.Point value) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetPoint(System.String name, out Rhino.Geometry.Point3d value) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, Rhino.Geometry.Point3d value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetVector(System.String name, out Rhino.Geometry.Vector3d value) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, Rhino.Geometry.Vector3d value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetColor(System.String name, out System.Drawing.Color value) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, System.Drawing.Color value) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetGuid(System.String name, out System.Guid value) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, System.Guid value) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetViewport(System.String name, out Rhino.DocObjects.ViewportInfo viewport) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, Rhino.Geometry.GeometryBase value) =>
    throw new System.NotImplementedException();

  public virtual void Set(
    System.String name,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> values
  ) => throw new System.NotImplementedException();

  public virtual void SetWindowHandle(System.String name, System.IntPtr value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetWindowImageHandle(System.String name, out System.IntPtr value) =>
    throw new System.NotImplementedException();

  public virtual void SetWindowImageHandle(System.String name, System.IntPtr value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetWindowHandle(System.String name, out System.IntPtr value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetUnmangedPointer(System.String name, out System.IntPtr value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetGeometry(System.String name, out Rhino.Geometry.GeometryBase[] values) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetRhinoObjects(System.String key, out Rhino.DocObjects.RhinoObject[] values) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetLine(System.String name, out Rhino.Geometry.Line value) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, Rhino.Geometry.Line value) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetArc(System.String name, out Rhino.Geometry.Arc value) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, Rhino.Geometry.Arc value) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetPlane(System.String name, out Rhino.Geometry.Plane plane) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, Rhino.Geometry.Plane plane) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetPoints(System.String name, out Rhino.Geometry.Point3d[] pts) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, Rhino.Geometry.Point3d[] pts) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetMeshParameters(System.String name, out Rhino.Geometry.MeshingParameters value) =>
    throw new System.NotImplementedException();

  public virtual void Set(System.String name, Rhino.Geometry.MeshingParameters value) =>
    throw new System.NotImplementedException();
}
