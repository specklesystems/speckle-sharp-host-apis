namespace Rhino.FileIO;

public partial class BinaryArchiveReader
{
  public BinaryArchiveReader() { }

  public virtual System.Boolean EnableCRCCalculation(System.Boolean enable) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SeekFromCurrentPosition(System.Int64 byteOffset) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SeekFromCurrentPosition(System.UInt64 byteOffset, System.Boolean forward) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SeekFromStart(System.UInt64 byteOffset) => throw new System.NotImplementedException();

  public virtual System.Boolean BeginRead3dmChunk(
    System.UInt32 expectedTypeCode,
    out System.Int32 majorVersion,
    out System.Int32 minorVersion
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean BeginRead3dmChunk(out System.UInt32 typeCode, out System.Int64 value) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean EndRead3dmChunk(System.Boolean suppressPartiallyReadChunkWarning) =>
    throw new System.NotImplementedException();

  public virtual void Read3dmChunkVersion(out System.Int32 major, out System.Int32 minor) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean ReadBool() => throw new System.NotImplementedException();

  public virtual System.Byte ReadByte() => throw new System.NotImplementedException();

  public virtual System.SByte ReadSByte() => throw new System.NotImplementedException();

  public virtual System.Int16 ReadShort() => throw new System.NotImplementedException();

  public virtual System.UInt16 ReadUShort() => throw new System.NotImplementedException();

  public virtual System.Int32 ReadInt() => throw new System.NotImplementedException();

  public virtual System.UInt32 ReadUInt() => throw new System.NotImplementedException();

  public virtual System.Int64 ReadInt64() => throw new System.NotImplementedException();

  public virtual System.Single ReadSingle() => throw new System.NotImplementedException();

  public virtual System.Double ReadDouble() => throw new System.NotImplementedException();

  public virtual System.Guid ReadGuid() => throw new System.NotImplementedException();

  public virtual System.String ReadString() => throw new System.NotImplementedException();

  public virtual System.String ReadUtf8String() => throw new System.NotImplementedException();

  public virtual System.Boolean[] ReadBoolArray() => throw new System.NotImplementedException();

  public virtual System.Byte[] ReadByteArray() => throw new System.NotImplementedException();

  public virtual System.Byte[] ReadCompressedBuffer() => throw new System.NotImplementedException();

  public virtual System.SByte[] ReadSByteArray() => throw new System.NotImplementedException();

  public virtual System.Int16[] ReadShortArray() => throw new System.NotImplementedException();

  public virtual System.Int32[] ReadIntArray() => throw new System.NotImplementedException();

  public virtual System.Single[] ReadSingleArray() => throw new System.NotImplementedException();

  public virtual System.Double[] ReadDoubleArray() => throw new System.NotImplementedException();

  public virtual System.Guid[] ReadGuidArray() => throw new System.NotImplementedException();

  public virtual System.String[] ReadStringArray() => throw new System.NotImplementedException();

  public virtual System.Drawing.Color ReadColor() => throw new System.NotImplementedException();

  public virtual System.Drawing.Point ReadPoint() => throw new System.NotImplementedException();

  public virtual System.Drawing.PointF ReadPointF() => throw new System.NotImplementedException();

  public virtual System.Drawing.Rectangle ReadRectangle() => throw new System.NotImplementedException();

  public virtual System.Drawing.RectangleF ReadRectangleF() => throw new System.NotImplementedException();

  public virtual System.Drawing.Size ReadSize() => throw new System.NotImplementedException();

  public virtual System.Drawing.SizeF ReadSizeF() => throw new System.NotImplementedException();

  public virtual System.Drawing.Font ReadFont() => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.ObjRef ReadObjRef() => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.ObjRef[] ReadObjRefArray() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Interval ReadInterval() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point2d ReadPoint2d() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d ReadPoint3d() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point4d ReadPoint4d() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Vector2d ReadVector2d() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Vector3d ReadVector3d() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BoundingBox ReadBoundingBox() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Ray3d ReadRay3d() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Transform ReadTransform() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Plane ReadPlane() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Line ReadLine() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3f ReadPoint3f() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Vector3f ReadVector3f() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.MeshingParameters ReadMeshingParameters() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.GeometryBase ReadGeometry() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.GeometryBase[] ReadGeometryArray() => throw new System.NotImplementedException();

  public virtual Rhino.Render.RenderSettings ReadRenderSettings() => throw new System.NotImplementedException();

  public virtual void ReadCheckSum() => throw new System.NotImplementedException();

  public virtual System.Boolean Read3dmStartSection(out System.Int32 version, out System.String comment) =>
    throw new System.NotImplementedException();

  public virtual System.UInt32 Dump3dmChunk(Rhino.FileIO.TextLog log) => throw new System.NotImplementedException();

  public virtual System.Boolean AtEnd() => throw new System.NotImplementedException();

  public virtual System.Boolean ReadErrorOccured
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 Archive3dmVersion
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.UInt64 CurrentPosition
  {
    get => throw new System.NotImplementedException();
  }
}
