namespace Rhino.Collections;

public partial class ArchivableDictionary : System.ICloneable,System.Collections.Generic.IDictionary<System.String, System.Object>,System.Runtime.Serialization.ISerializable
{
	public ArchivableDictionary() {}
	public ArchivableDictionary(System.Int32 version) => throw new System.NotImplementedException();
	public ArchivableDictionary(System.Int32 version,System.String name) => throw new System.NotImplementedException();
	public virtual System.Boolean RemoveEnumValue() => throw new System.NotImplementedException();
	public virtual System.Boolean AddContentsFrom(Rhino.Collections.ArchivableDictionary source) => throw new System.NotImplementedException();
	public virtual System.Boolean ReplaceContentsWith(Rhino.Collections.ArchivableDictionary source) => throw new System.NotImplementedException();
	public virtual Rhino.Collections.ArchivableDictionary Clone() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>> GetEnumerator() => throw new System.NotImplementedException();
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info,System.Runtime.Serialization.StreamingContext context) => throw new System.NotImplementedException();
	public virtual System.Boolean ContainsKey(System.String key) => throw new System.NotImplementedException();
	public virtual System.Object get_Item(System.String key) => throw new System.NotImplementedException();
	public virtual void set_Item(System.String key,System.Object value) => throw new System.NotImplementedException();
	public virtual void Clear() => throw new System.NotImplementedException();
	public virtual System.Boolean Remove(System.String key) => throw new System.NotImplementedException();
	public virtual System.String GetString(System.String key) => throw new System.NotImplementedException();
	public virtual System.String GetString(System.String key,System.String defaultValue) => throw new System.NotImplementedException();
	public virtual Rhino.Collections.ArchivableDictionary GetDictionary(System.String key) => throw new System.NotImplementedException();
	public virtual Rhino.Collections.ArchivableDictionary GetDictionary(System.String key,Rhino.Collections.ArchivableDictionary defaultValue) => throw new System.NotImplementedException();
	public virtual System.Byte[] GetBytes(System.String key) => throw new System.NotImplementedException();
	public virtual System.Byte[] GetBytes(System.String key,System.Byte[] defaultValue) => throw new System.NotImplementedException();
	public virtual System.Boolean GetBool(System.String key) => throw new System.NotImplementedException();
	public virtual System.Boolean GetBool(System.String key,System.Boolean defaultValue) => throw new System.NotImplementedException();
	public virtual System.Single GetFloat(System.String key) => throw new System.NotImplementedException();
	public virtual System.Single GetFloat(System.String key,System.Single defaultValue) => throw new System.NotImplementedException();
	public virtual System.Double GetDouble(System.String key) => throw new System.NotImplementedException();
	public virtual System.Double GetDouble(System.String key,System.Double defaultValue) => throw new System.NotImplementedException();
	public virtual System.Int32 GetInteger(System.String key,System.Int32 defaultValue) => throw new System.NotImplementedException();
	public virtual System.Int32 GetInteger(System.String key) => throw new System.NotImplementedException();
	public virtual System.Int32 Getint(System.String key,System.Int32 defaultValue) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3f GetPoint3f(System.String key) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3f GetPoint3f(System.String key,Rhino.Geometry.Point3f defaultValue) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d GetPoint3d(System.String key) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d GetPoint3d(System.String key,Rhino.Geometry.Point3d defaultValue) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Vector3d GetVector3d(System.String key) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Vector3d GetVector3d(System.String key,Rhino.Geometry.Vector3d defaultValue) => throw new System.NotImplementedException();
	public virtual System.Guid GetGuid(System.String key) => throw new System.NotImplementedException();
	public virtual System.Guid GetGuid(System.String key,System.Guid defaultValue) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Plane GetPlane(System.String key) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Plane GetPlane(System.String key,Rhino.Geometry.Plane defaultValue) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.Boolean val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.Byte val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.SByte val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.Int16 val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.UInt16 val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.Int32 val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.UInt32 val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.Int64 val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.Single val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.Double val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.Guid val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.String val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.Collections.Generic.IEnumerable<System.Boolean> val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.Collections.Generic.IEnumerable<System.Byte> val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.Collections.Generic.IEnumerable<System.SByte> val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.Collections.Generic.IEnumerable<System.Int16> val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.Collections.Generic.IEnumerable<System.Int32> val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.Collections.Generic.IEnumerable<System.Single> val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.Collections.Generic.IEnumerable<System.Double> val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.Collections.Generic.IEnumerable<System.Guid> val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.Collections.Generic.IEnumerable<System.String> val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,Rhino.Geometry.Interval val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,Rhino.Geometry.Point2d val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,Rhino.Geometry.Point3d val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,Rhino.Geometry.Point4d val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,Rhino.Geometry.Vector2d val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,Rhino.Geometry.Vector3d val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,Rhino.Geometry.BoundingBox val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,Rhino.Geometry.Ray3d val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,Rhino.Geometry.Transform val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,Rhino.Geometry.Plane val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,Rhino.Geometry.Line val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,Rhino.Geometry.Point3f val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,Rhino.Geometry.Vector3f val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,Rhino.Collections.ArchivableDictionary val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,Rhino.Geometry.MeshingParameters val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,Rhino.Geometry.GeometryBase val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,Rhino.DocObjects.ObjRef val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.Collections.Generic.IEnumerable<Rhino.DocObjects.ObjRef> val) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String key,System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> val) => throw new System.NotImplementedException();
	public virtual System.Int32 Version
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String Name
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.UInt32 ChangeSerialNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String[] Keys
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Object[] Values
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 Count
	{
		get => throw new System.NotImplementedException();
	}
}
