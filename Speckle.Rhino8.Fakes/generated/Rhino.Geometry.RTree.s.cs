namespace Rhino.Geometry;

public partial class RTree : System.IDisposable
{
  public RTree() { }

  public static Rhino.Geometry.RTree CreateMeshFaceTree(Rhino.Geometry.Mesh mesh) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.RTree CreatePointCloudTree(Rhino.Geometry.PointCloud cloud) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.RTree CreateFromPointArray(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Insert(Rhino.Geometry.Point3d point, System.Int32 elementId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Insert(Rhino.Geometry.Point3d point, System.IntPtr elementId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Insert(Rhino.Geometry.BoundingBox box, System.Int32 elementId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Insert(Rhino.Geometry.BoundingBox box, System.IntPtr elementId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Insert(Rhino.Geometry.Point2d point, System.Int32 elementId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Insert(Rhino.Geometry.Point2d point, System.IntPtr elementId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Remove(Rhino.Geometry.Point3d point, System.Int32 elementId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Remove(Rhino.Geometry.Point3d point, System.IntPtr elementId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Remove(Rhino.Geometry.BoundingBox box, System.Int32 elementId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Remove(Rhino.Geometry.BoundingBox box, System.IntPtr elementId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Remove(Rhino.Geometry.Point2d point, System.Int32 elementId) =>
    throw new System.NotImplementedException();

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual System.Boolean Search(
    Rhino.Geometry.BoundingBox box,
    System.EventHandler<Rhino.Geometry.RTreeEventArgs> callback
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Search(
    Rhino.Geometry.BoundingBox box,
    System.EventHandler<Rhino.Geometry.RTreeEventArgs> callback,
    System.Object tag
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Search(
    Rhino.Geometry.Sphere sphere,
    System.EventHandler<Rhino.Geometry.RTreeEventArgs> callback
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Search(
    Rhino.Geometry.Sphere sphere,
    System.EventHandler<Rhino.Geometry.RTreeEventArgs> callback,
    System.Object tag
  ) => throw new System.NotImplementedException();

  public static System.Boolean SearchOverlaps(
    Rhino.Geometry.RTree treeA,
    Rhino.Geometry.RTree treeB,
    System.Double tolerance,
    System.EventHandler<Rhino.Geometry.RTreeEventArgs> callback
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public static System.Collections.Generic.IEnumerable<System.Int32[]> PointCloudClosestPoints(
    Rhino.Geometry.PointCloud pointcloud,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> needlePts,
    System.Double limitDistance
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IEnumerable<System.Int32[]> Point3dClosestPoints(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> hayPoints,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> needlePts,
    System.Double limitDistance
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IEnumerable<System.Int32[]> PointCloudKNeighbors(
    Rhino.Geometry.PointCloud pointcloud,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> needlePts,
    System.Int32 amount
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IEnumerable<System.Int32[]> Point3dKNeighbors(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> hayPoints,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> needlePts,
    System.Int32 amount
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 Count
  {
    get => throw new System.NotImplementedException();
  }
}
