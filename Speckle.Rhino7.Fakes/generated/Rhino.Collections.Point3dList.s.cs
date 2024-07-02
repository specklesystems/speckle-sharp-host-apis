namespace Rhino.Collections;

public partial class Point3dList
  : Rhino.Collections.RhinoList<Rhino.Geometry.Point3d>,
    System.IEquatable<Rhino.Collections.Point3dList>
{
  public Point3dList() { }

  public Point3dList(System.Int32 initialCapacity) => throw new System.NotImplementedException();

  public Point3dList(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> collection) =>
    throw new System.NotImplementedException();

  public Point3dList(Rhino.Geometry.Point3d[] initialPoints) => throw new System.NotImplementedException();

  public virtual System.Int32 ClosestIndex(Rhino.Geometry.Point3d testPoint) =>
    throw new System.NotImplementedException();

  public virtual void Add(System.Double x, System.Double y, System.Double z) =>
    throw new System.NotImplementedException();

  public virtual void Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();

  public virtual void SetAllX(System.Double xValue) => throw new System.NotImplementedException();

  public virtual void SetAllY(System.Double yValue) => throw new System.NotImplementedException();

  public virtual void SetAllZ(System.Double zValue) => throw new System.NotImplementedException();

  public static System.Int32 ClosestIndexInList(
    System.Collections.Generic.IList<Rhino.Geometry.Point3d> list,
    Rhino.Geometry.Point3d testPoint
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Point3d ClosestPointInList(
    System.Collections.Generic.IList<Rhino.Geometry.Point3d> list,
    Rhino.Geometry.Point3d testPoint
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Equals(Rhino.Collections.Point3dList other) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BoundingBox BoundingBox
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Collections.Point3dList.XAccess X
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Collections.Point3dList.YAccess Y
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Collections.Point3dList.ZAccess Z
  {
    get => throw new System.NotImplementedException();
  }
}
