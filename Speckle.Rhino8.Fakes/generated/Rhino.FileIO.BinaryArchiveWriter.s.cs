namespace Rhino.FileIO;

public partial class BinaryArchiveWriter
{
  public BinaryArchiveWriter() { }

  public virtual System.Boolean BeginWrite3dmChunk(
    System.UInt32 typecode,
    System.Int32 majorVersion,
    System.Int32 minorVersion
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean BeginWrite3dmChunk(System.UInt32 typecode, System.Int64 value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean EndWrite3dmChunk() => throw new System.NotImplementedException();

  public virtual System.Boolean EnableCRCCalculation(System.Boolean enable) =>
    throw new System.NotImplementedException();

  public virtual void Write3dmChunkVersion(System.Int32 major, System.Int32 minor) =>
    throw new System.NotImplementedException();

  public virtual void WriteBool(System.Boolean value) => throw new System.NotImplementedException();

  public virtual void WriteByte(System.Byte value) => throw new System.NotImplementedException();

  public virtual void WriteSByte(System.SByte value) => throw new System.NotImplementedException();

  public virtual void WriteShort(System.Int16 value) => throw new System.NotImplementedException();

  public virtual void WriteUShort(System.UInt16 value) => throw new System.NotImplementedException();

  public virtual void WriteInt(System.Int32 value) => throw new System.NotImplementedException();

  public virtual void WriteUInt(System.UInt32 value) => throw new System.NotImplementedException();

  public virtual void WriteInt64(System.Int64 value) => throw new System.NotImplementedException();

  public virtual void WriteSingle(System.Single value) => throw new System.NotImplementedException();

  public virtual void WriteDouble(System.Double value) => throw new System.NotImplementedException();

  public virtual void WriteGuid(System.Guid value) => throw new System.NotImplementedException();

  public virtual void WriteString(System.String value) => throw new System.NotImplementedException();

  public virtual void WriteUtf8String(System.String value) => throw new System.NotImplementedException();

  public virtual void WriteBoolArray(System.Collections.Generic.IEnumerable<System.Boolean> value) =>
    throw new System.NotImplementedException();

  public virtual void WriteByteArray(System.Collections.Generic.IEnumerable<System.Byte> value) =>
    throw new System.NotImplementedException();

  public virtual void WriteCompressedBuffer(System.Collections.Generic.IEnumerable<System.Byte> value) =>
    throw new System.NotImplementedException();

  public virtual void WriteSByteArray(System.Collections.Generic.IEnumerable<System.SByte> value) =>
    throw new System.NotImplementedException();

  public virtual void WriteShortArray(System.Collections.Generic.IEnumerable<System.Int16> value) =>
    throw new System.NotImplementedException();

  public virtual void WriteIntArray(System.Collections.Generic.IEnumerable<System.Int32> value) =>
    throw new System.NotImplementedException();

  public virtual void WriteSingleArray(System.Collections.Generic.IEnumerable<System.Single> value) =>
    throw new System.NotImplementedException();

  public virtual void WriteDoubleArray(System.Collections.Generic.IEnumerable<System.Double> value) =>
    throw new System.NotImplementedException();

  public virtual void WriteGuidArray(System.Collections.Generic.IEnumerable<System.Guid> value) =>
    throw new System.NotImplementedException();

  public virtual void WriteStringArray(System.Collections.Generic.IEnumerable<System.String> value) =>
    throw new System.NotImplementedException();

  public virtual void WriteColor(System.Drawing.Color value) => throw new System.NotImplementedException();

  public virtual void WritePoint(System.Drawing.Point value) => throw new System.NotImplementedException();

  public virtual void WritePointF(System.Drawing.PointF value) => throw new System.NotImplementedException();

  public virtual void WriteRectangle(System.Drawing.Rectangle value) => throw new System.NotImplementedException();

  public virtual void WriteRectangleF(System.Drawing.RectangleF value) => throw new System.NotImplementedException();

  public virtual void WriteSize(System.Drawing.Size value) => throw new System.NotImplementedException();

  public virtual void WriteSizeF(System.Drawing.SizeF value) => throw new System.NotImplementedException();

  public virtual void WriteFont(System.Drawing.Font value) => throw new System.NotImplementedException();

  public virtual void WriteObjRef(Rhino.DocObjects.ObjRef objref) => throw new System.NotImplementedException();

  public virtual void WriteObjRefArray(System.Collections.Generic.IEnumerable<Rhino.DocObjects.ObjRef> objrefs) =>
    throw new System.NotImplementedException();

  public virtual void WriteGeometryArray(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> geometry
  ) => throw new System.NotImplementedException();

  public virtual void WriteInterval(Rhino.Geometry.Interval value) => throw new System.NotImplementedException();

  public virtual void WritePoint2d(Rhino.Geometry.Point2d value) => throw new System.NotImplementedException();

  public virtual void WritePoint3d(Rhino.Geometry.Point3d value) => throw new System.NotImplementedException();

  public virtual void WritePoint4d(Rhino.Geometry.Point4d value) => throw new System.NotImplementedException();

  public virtual void WriteVector2d(Rhino.Geometry.Vector2d value) => throw new System.NotImplementedException();

  public virtual void WriteVector3d(Rhino.Geometry.Vector3d value) => throw new System.NotImplementedException();

  public virtual void WriteBoundingBox(Rhino.Geometry.BoundingBox value) => throw new System.NotImplementedException();

  public virtual void WriteRay3d(Rhino.Geometry.Ray3d value) => throw new System.NotImplementedException();

  public virtual void WriteTransform(Rhino.Geometry.Transform value) => throw new System.NotImplementedException();

  public virtual void WritePlane(Rhino.Geometry.Plane value) => throw new System.NotImplementedException();

  public virtual void WriteLine(Rhino.Geometry.Line value) => throw new System.NotImplementedException();

  public virtual void WritePoint3f(Rhino.Geometry.Point3f value) => throw new System.NotImplementedException();

  public virtual void WriteVector3f(Rhino.Geometry.Vector3f value) => throw new System.NotImplementedException();

  public virtual void WriteMeshingParameters(Rhino.Geometry.MeshingParameters value) =>
    throw new System.NotImplementedException();

  public virtual void WriteGeometry(Rhino.Geometry.GeometryBase value) => throw new System.NotImplementedException();

  public virtual void WriteRenderSettings(Rhino.Render.RenderSettings value) =>
    throw new System.NotImplementedException();

  public virtual void WriteEmptyCheckSum() => throw new System.NotImplementedException();

  public virtual System.Boolean WriteErrorOccured
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 Archive3dmVersion
  {
    get => throw new System.NotImplementedException();
  }
}
