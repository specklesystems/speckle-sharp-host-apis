namespace Rhino.Geometry;

public partial struct Triangle3d
{
	public Triangle3d() {}
	public Triangle3d(Rhino.Geometry.Point3d a,Rhino.Geometry.Point3d b,Rhino.Geometry.Point3d c) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Triangle3d Transform(Rhino.Geometry.Transform transform) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Polyline ToPolyline() => throw new System.NotImplementedException();
	public  Rhino.Geometry.Mesh ToMesh() => throw new System.NotImplementedException();
	public  Rhino.Geometry.Triangle3d WithA(Rhino.Geometry.Point3d a) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Triangle3d WithB(Rhino.Geometry.Point3d b) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Triangle3d WithC(Rhino.Geometry.Point3d c) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d PointAtBarycentricCoords(Rhino.Geometry.Point2d coords) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d PointAlongBoundary(System.Double t) => throw new System.NotImplementedException();
	public  System.Double ClosestParameterOnBoundary(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d ClosestPointOnBoundary(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d PointOnInterior(System.Double u,System.Double v) => throw new System.NotImplementedException();
	public  Rhino.Geometry.Point3d A
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Point3d B
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Point3d C
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Circle Circumcircle
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.BoundingBox BoundingBox
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Double AngleA
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Double AngleB
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Double AngleC
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Line AB
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Line BC
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Line CA
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Line MedianA
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Line MedianB
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Line MedianC
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Line AltitudeA
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Line AltitudeB
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Line AltitudeC
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Line PerpendicularAB
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Line PerpendicularBC
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Line PerpendicularCA
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Double Perimeter
	{
		get => throw new System.NotImplementedException();
	}
	public  System.Double Area
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Point3d AreaCenter
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Point3d Orthocenter
	{
		get => throw new System.NotImplementedException();
	}
	public  Rhino.Geometry.Point3d Circumcenter
	{
		get => throw new System.NotImplementedException();
	}
}
