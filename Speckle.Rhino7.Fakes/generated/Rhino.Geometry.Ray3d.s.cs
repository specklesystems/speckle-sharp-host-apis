namespace Rhino.Geometry;

public partial struct Ray3d : System.Runtime.Serialization.ISerializable,System.IEquatable<Rhino.Geometry.Ray3d>,Rhino.IEpsilonComparable<Rhino.Geometry.Ray3d>
{
	public Ray3d() {}
	public Ray3d(Rhino.Geometry.Point3d position,Rhino.Geometry.Vector3d direction) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d PointAt(System.Double t) => throw new System.NotImplementedException();
	public  System.Boolean Equals(Rhino.Geometry.Ray3d ray) => throw new System.NotImplementedException();
	public  System.Boolean EpsilonEquals(Rhino.Geometry.Ray3d other,System.Double epsilon) => throw new System.NotImplementedException();
	void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info,System.Runtime.Serialization.StreamingContext context) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d Position
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Vector3d Direction
	{
		get => throw new System.NotImplementedException();
	}
}
