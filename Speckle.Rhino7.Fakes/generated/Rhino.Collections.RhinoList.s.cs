namespace Rhino.Collections;

public partial class RhinoList
{
  public RhinoList() { }

  public static System.Collections.Generic.IEnumerable<System.Int32[]> PointCloudKNeighbors(
    Rhino.Geometry.PointCloud pointcloud,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> needlePoints,
    System.Int32 amount
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IEnumerable<System.Int32[]> Point3dKNeighbors(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> hayPoints,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> needlePoints,
    System.Int32 amount
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IEnumerable<System.Int32[]> Point3fKNeighbors(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3f> hayPoints,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3f> needlePoints,
    System.Int32 amount
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IEnumerable<System.Int32[]> Point2dKNeighbors(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point2d> hayPoints,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point2d> needlePoints,
    System.Int32 amount
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IEnumerable<System.Int32[]> Point2fKNeighbors(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point2f> hayPoints,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point2f> needlePoints,
    System.Int32 amount
  ) => throw new System.NotImplementedException();
}
