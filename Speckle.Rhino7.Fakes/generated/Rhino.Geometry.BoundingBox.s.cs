namespace Rhino.Geometry;

public partial class BoundingBox : System.ICloneable
{
  public BoundingBox() { }

  public BoundingBox(Rhino.Geometry.Point3d min, Rhino.Geometry.Point3d max) =>
    throw new System.NotImplementedException();

  public BoundingBox(
    System.Double minX,
    System.Double minY,
    System.Double minZ,
    System.Double maxX,
    System.Double maxY,
    System.Double maxZ
  ) => throw new System.NotImplementedException();

  public BoundingBox(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points) =>
    throw new System.NotImplementedException();

  public BoundingBox(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,
    Rhino.Geometry.Transform xform
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d PointAt(System.Double tx, System.Double ty, System.Double tz) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d ClosestPoint(Rhino.Geometry.Point3d point) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d ClosestPoint(Rhino.Geometry.Point3d point, System.Boolean includeInterior) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d FurthestPoint(Rhino.Geometry.Point3d point) =>
    throw new System.NotImplementedException();

  public virtual void Inflate(System.Double amount) => throw new System.NotImplementedException();

  public virtual void Inflate(System.Double xAmount, System.Double yAmount, System.Double zAmount) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Contains(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();

  public virtual System.Boolean Contains(Rhino.Geometry.Point3d point, System.Boolean strict) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Contains(Rhino.Geometry.BoundingBox box) => throw new System.NotImplementedException();

  public virtual System.Boolean Contains(Rhino.Geometry.BoundingBox box, System.Boolean strict) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean MakeValid() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d Corner(System.Boolean minX, System.Boolean minY, System.Boolean minZ) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 IsDegenerate(System.Double tolerance) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d[] GetCorners() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Line[] GetEdges() => throw new System.NotImplementedException();

  public virtual System.Boolean Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep ToBrep() => throw new System.NotImplementedException();

  public virtual void Union(Rhino.Geometry.BoundingBox other) => throw new System.NotImplementedException();

  public virtual void Union(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();

  public static Rhino.Geometry.BoundingBox Union(Rhino.Geometry.BoundingBox a, Rhino.Geometry.BoundingBox b) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.BoundingBox Intersection(Rhino.Geometry.BoundingBox a, Rhino.Geometry.BoundingBox b) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.BoundingBox Union(Rhino.Geometry.BoundingBox box, Rhino.Geometry.Point3d point) =>
    throw new System.NotImplementedException();

  System.Object System.ICloneable.Clone() => throw new System.NotImplementedException();

  public static Rhino.Geometry.BoundingBox Empty
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.BoundingBox Unset
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point3d Min
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point3d Max
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point3d Center
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Area
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Volume
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d Diagonal
  {
    get => throw new System.NotImplementedException();
  }
}
