namespace Rhino.Geometry;

public partial class Cylinder : Rhino.IEpsilonComparable<Rhino.Geometry.Cylinder>
{
  public Cylinder() { }

  public Cylinder(Rhino.Geometry.Circle baseCircle) => throw new System.NotImplementedException();

  public Cylinder(Rhino.Geometry.Circle baseCircle, System.Double height) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Circle CircleAt(System.Double linearParameter) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Line LineAt(System.Double angularParameter) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep ToBrep(System.Boolean capBottom, System.Boolean capTop) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.NurbsSurface ToNurbsSurface() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.RevSurface ToRevSurface() => throw new System.NotImplementedException();

  public virtual System.Boolean EpsilonEquals(Rhino.Geometry.Cylinder other, System.Double epsilon) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Cylinder Unset
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsFinite
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point3d Center
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d Axis
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double TotalHeight
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Height1
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Height2
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Radius
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Plane BasePlane
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
