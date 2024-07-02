namespace Rhino.Geometry;

public partial class Polyline : Rhino.Collections.Point3dList
{
  public Polyline() { }

  public Polyline(System.Int32 initialCapacity)
    : base(initialCapacity) => throw new System.NotImplementedException();

  public Polyline(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> collection)
    : base(collection) => throw new System.NotImplementedException();

  public virtual System.Boolean IsClosedWithinTolerance(System.Double tolerance) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Line SegmentAt(System.Int32 index) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d PointAt(System.Double t) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Vector3d TangentAt(System.Double t) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Polyline Trim(Rhino.Geometry.Interval domain) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d ClosestPoint(Rhino.Geometry.Point3d testPoint) =>
    throw new System.NotImplementedException();

  public virtual System.Double ClosestParameter(Rhino.Geometry.Point3d testPoint) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Line[] GetSegments() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.NurbsCurve ToNurbsCurve() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.PolylineCurve ToPolylineCurve() => throw new System.NotImplementedException();

  public virtual System.Int32 DeleteShortSegments(System.Double tolerance) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 CollapseShortSegments(System.Double tolerance) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 ReduceSegments(System.Double tolerance) => throw new System.NotImplementedException();

  public virtual System.Int32 MergeColinearSegments(System.Double angleTolerance, System.Boolean includeSeam) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Smooth(System.Double amount) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Polyline[] BreakAtAngles(System.Double angle) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d CenterPoint() => throw new System.NotImplementedException();

  public static Rhino.Geometry.Polyline CreateInscribedPolygon(Rhino.Geometry.Circle circle, System.Int32 sideCount) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Polyline CreateCircumscribedPolygon(
    Rhino.Geometry.Circle circle,
    System.Int32 sideCount
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Polyline CreateStarPolygon(
    Rhino.Geometry.Circle circle,
    System.Double radius,
    System.Int32 cornerCount
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.MeshFace[] TriangulateClosedPolyline() => throw new System.NotImplementedException();

  public virtual void RemoveNearlyEqualSubsequentPoints(System.Double tolerance) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 SegmentCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsClosed
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Length
  {
    get => throw new System.NotImplementedException();
  }
}
