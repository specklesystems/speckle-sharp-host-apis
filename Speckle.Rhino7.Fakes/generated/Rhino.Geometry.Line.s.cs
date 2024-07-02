namespace Rhino.Geometry;

public partial struct Line : System.IEquatable<Rhino.Geometry.Line>,Rhino.IEpsilonComparable<Rhino.Geometry.Line>,System.ICloneable,System.IFormattable
{
	public Line() {}
	public Line(Rhino.Geometry.Point3d from,Rhino.Geometry.Point3d to) => throw new System.NotImplementedException();
	public Line(Rhino.Geometry.Point3d start,Rhino.Geometry.Vector3d span) => throw new System.NotImplementedException();
	public Line(Rhino.Geometry.Point3d start,Rhino.Geometry.Vector3d direction,System.Double length) => throw new System.NotImplementedException();
	public Line(System.Double x0,System.Double y0,System.Double z0,System.Double x1,System.Double y1,System.Double z1) => throw new System.NotImplementedException();
	public  System.Boolean Equals(Rhino.Geometry.Line other) => throw new System.NotImplementedException();
	public  System.Boolean EpsilonEquals(Rhino.Geometry.Line other,System.Double epsilon) => throw new System.NotImplementedException();
	public  System.String ToString(System.String format,System.IFormatProvider formatProvider) => throw new System.NotImplementedException();
	public  void Flip() => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d PointAt(System.Double t) => throw new System.NotImplementedException();
	public  System.Double ClosestParameter(Rhino.Geometry.Point3d testPoint) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d ClosestPoint(Rhino.Geometry.Point3d testPoint,System.Boolean limitToFiniteSegment) => throw new System.NotImplementedException();
	public  System.Double DistanceTo(Rhino.Geometry.Point3d testPoint,System.Boolean limitToFiniteSegment) => throw new System.NotImplementedException();
	public  System.Double MinimumDistanceTo(Rhino.Geometry.Point3d testPoint) => throw new System.NotImplementedException();
	public  System.Double MinimumDistanceTo(Rhino.Geometry.Line testLine) => throw new System.NotImplementedException();
	public  System.Double MaximumDistanceTo(Rhino.Geometry.Point3d testPoint) => throw new System.NotImplementedException();
	public  System.Double MaximumDistanceTo(Rhino.Geometry.Line testLine) => throw new System.NotImplementedException();
	public  System.Boolean Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public  Rhino.Geometry.NurbsCurve ToNurbsCurve() => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d PointAtLength(System.Double distance) => throw new System.NotImplementedException();
	public  System.Boolean Extend(System.Double startLength,System.Double endLength) => throw new System.NotImplementedException();
	public  System.Boolean ExtendThroughBox(Rhino.Geometry.BoundingBox box) => throw new System.NotImplementedException();
	public  System.Boolean ExtendThroughBox(Rhino.Geometry.BoundingBox box,System.Double additionalLength) => throw new System.NotImplementedException();
	public  System.Boolean ExtendThroughBox(Rhino.Geometry.Box box) => throw new System.NotImplementedException();
	public  System.Boolean ExtendThroughBox(Rhino.Geometry.Box box,System.Double additionalLength) => throw new System.NotImplementedException();
	System.Object System.ICloneable.Clone() => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d From
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double FromX
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double FromY
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double FromZ
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  Rhino.Geometry.Point3d To
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double ToX
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double ToY
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double ToZ
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public static Rhino.Geometry.Line Unset
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Boolean IsValid
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Double Length
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  Rhino.Geometry.Vector3d Direction
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Vector3d UnitTangent
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.BoundingBox BoundingBox
	{
		get => throw new System.NotImplementedException();
	}
}
