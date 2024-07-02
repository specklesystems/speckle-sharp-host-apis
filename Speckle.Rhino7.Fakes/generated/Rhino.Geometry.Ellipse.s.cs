namespace Rhino.Geometry;

public partial struct Ellipse
{
	public Ellipse() {}
	public Ellipse(Rhino.Geometry.Plane plane,System.Double radius1,System.Double radius2) => throw new System.NotImplementedException();
	public Ellipse(Rhino.Geometry.Point3d center,Rhino.Geometry.Point3d second,Rhino.Geometry.Point3d third) => throw new System.NotImplementedException();
	public  Rhino.Geometry.NurbsCurve ToNurbsCurve() => throw new System.NotImplementedException();
	public  System.Boolean EpsilonEquals(Rhino.Geometry.Ellipse other,System.Double epsilon) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Plane Plane
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double Radius1
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Double Radius2
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public  System.Boolean IsValid
	{
		get => throw new System.NotImplementedException();
	}
}
