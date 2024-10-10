namespace Rhino.Geometry;

public partial class Cone : Rhino.IEpsilonComparable<Rhino.Geometry.Cone>
{
  public Cone() { }

  public Cone(Rhino.Geometry.Plane plane, System.Double height, System.Double radius) =>
    throw new System.NotImplementedException();

  public virtual System.Double AngleInRadians() => throw new System.NotImplementedException();

  public virtual System.Double AngleInDegrees() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.NurbsSurface ToNurbsSurface() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.RevSurface ToRevSurface() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep ToBrep(System.Boolean capBottom) => throw new System.NotImplementedException();

  public virtual System.Boolean EpsilonEquals(Rhino.Geometry.Cone other, System.Double epsilon) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Cone Unset
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Plane Plane
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Height
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Radius
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point3d BasePoint
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point3d ApexPoint
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d Axis
  {
    get => throw new System.NotImplementedException();
  }
}
