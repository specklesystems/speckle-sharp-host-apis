namespace Rhino.Geometry;

public partial struct ControlPoint
  : Rhino.IEpsilonComparable<Rhino.Geometry.ControlPoint>,
    System.IEquatable<Rhino.Geometry.ControlPoint>
{
  public ControlPoint() { }

  public ControlPoint(System.Double x, System.Double y, System.Double z) => throw new System.NotImplementedException();

  public ControlPoint(System.Double x, System.Double y, System.Double z, System.Double weight) =>
    throw new System.NotImplementedException();

  public ControlPoint(Rhino.Geometry.Point3d pt) => throw new System.NotImplementedException();

  public ControlPoint(Rhino.Geometry.Point3d euclideanPt, System.Double weight) =>
    throw new System.NotImplementedException();

  public ControlPoint(Rhino.Geometry.Point4d pt) => throw new System.NotImplementedException();

  public System.Boolean EpsilonEquals(Rhino.Geometry.ControlPoint other, System.Double epsilon) =>
    throw new System.NotImplementedException();

  public System.Boolean Equals(Rhino.Geometry.ControlPoint other) => throw new System.NotImplementedException();

  public static Rhino.Geometry.ControlPoint Unset
  {
    get => throw new System.NotImplementedException();
  }
  public Rhino.Geometry.Point3d Location
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public System.Double X
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public System.Double Y
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public System.Double Z
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public System.Double Weight
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
