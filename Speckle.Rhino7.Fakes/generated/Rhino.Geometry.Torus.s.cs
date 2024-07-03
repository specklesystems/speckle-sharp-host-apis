namespace Rhino.Geometry;

public partial class Torus : Rhino.IEpsilonComparable<Rhino.Geometry.Torus>
{
  public Torus() { }

  public Torus(Rhino.Geometry.Plane basePlane, System.Double majorRadius, System.Double minorRadius) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.NurbsSurface ToNurbsSurface() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.RevSurface ToRevSurface() => throw new System.NotImplementedException();

  public virtual System.Boolean EpsilonEquals(Rhino.Geometry.Torus other, System.Double epsilon) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Torus Unset
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Plane Plane
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double MajorRadius
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double MinorRadius
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
