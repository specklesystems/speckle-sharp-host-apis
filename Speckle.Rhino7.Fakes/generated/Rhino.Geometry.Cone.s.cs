namespace Rhino.Geometry;

public partial struct Cone : Rhino.IEpsilonComparable<Rhino.Geometry.Cone>
{
  public Cone() { }

  public Cone(Rhino.Geometry.Plane plane, System.Double height, System.Double radius) =>
    throw new System.NotImplementedException();

  public System.Double AngleInRadians() => throw new System.NotImplementedException();

  public System.Double AngleInDegrees() => throw new System.NotImplementedException();

  public Rhino.Geometry.NurbsSurface ToNurbsSurface() => throw new System.NotImplementedException();

  public Rhino.Geometry.RevSurface ToRevSurface() => throw new System.NotImplementedException();

  public Rhino.Geometry.Brep ToBrep(System.Boolean capBottom) => throw new System.NotImplementedException();

  public System.Boolean EpsilonEquals(Rhino.Geometry.Cone other, System.Double epsilon) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Cone Unset
  {
    get => throw new System.NotImplementedException();
  }
  public Rhino.Geometry.Plane Plane
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public System.Double Height
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public System.Double Radius
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
  public Rhino.Geometry.Point3d BasePoint
  {
    get => throw new System.NotImplementedException();
  }
  public Rhino.Geometry.Point3d ApexPoint
  {
    get => throw new System.NotImplementedException();
  }
  public Rhino.Geometry.Vector3d Axis
  {
    get => throw new System.NotImplementedException();
  }
}
