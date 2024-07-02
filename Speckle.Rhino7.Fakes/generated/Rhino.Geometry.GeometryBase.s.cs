namespace Rhino.Geometry;

public partial class GeometryBase : Rhino.Runtime.CommonObject
{
	public GeometryBase() {}
	public virtual Rhino.Geometry.GeometryBase DuplicateShallow() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.GeometryBase Duplicate() => throw new System.NotImplementedException();
	public virtual System.Boolean Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public virtual System.Boolean Translate(Rhino.Geometry.Vector3d translationVector) => throw new System.NotImplementedException();
	public virtual System.Boolean Translate(System.Double x,System.Double y,System.Double z) => throw new System.NotImplementedException();
	public virtual System.Boolean Scale(System.Double scaleFactor) => throw new System.NotImplementedException();
	public virtual System.Boolean Rotate(System.Double angleRadians,Rhino.Geometry.Vector3d rotationAxis,Rhino.Geometry.Point3d rotationCenter) => throw new System.NotImplementedException();
	public virtual System.UInt32 MemoryEstimate() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BoundingBox GetBoundingBox(System.Boolean accurate) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BoundingBox GetBoundingBox(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BoundingBox GetBoundingBox(Rhino.Geometry.Plane plane) => throw new System.NotImplementedException();
	public virtual System.Boolean MakeDeformable() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.ComponentIndex ComponentIndex() => throw new System.NotImplementedException();
	public virtual System.Boolean SetUserString(System.String key,System.String value) => throw new System.NotImplementedException();
	public virtual System.String GetUserString(System.String key) => throw new System.NotImplementedException();
	public virtual System.Collections.Specialized.NameValueCollection GetUserStrings() => throw new System.NotImplementedException();
	public static System.Boolean GeometryEquals(Rhino.Geometry.GeometryBase first,Rhino.Geometry.GeometryBase second) => throw new System.NotImplementedException();
	public static System.Boolean GeometryReferenceEquals(Rhino.Geometry.GeometryBase one,Rhino.Geometry.GeometryBase other) => throw new System.NotImplementedException();
	public new System.Boolean IsDocumentControlled
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.ObjectType ObjectType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsDeformable
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean HasBrepForm
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 UserStringCount
	{
		get => throw new System.NotImplementedException();
	}
}
