namespace Rhino.Geometry;

public partial class NurbsCurve : Rhino.Geometry.Curve, Rhino.IEpsilonComparable<Rhino.Geometry.NurbsCurve>
{
  public NurbsCurve() { }

  public NurbsCurve(Rhino.Geometry.NurbsCurve other) => throw new System.NotImplementedException();

  public NurbsCurve(System.Int32 degree, System.Int32 pointCount) => throw new System.NotImplementedException();

  public NurbsCurve(System.Int32 dimension, System.Boolean rational, System.Int32 order, System.Int32 pointCount) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.NurbsCurve CreateFromLine(Rhino.Geometry.Line line) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.NurbsCurve CreateFromArc(Rhino.Geometry.Arc arc) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean UVNDirectionsAt(
    System.Double t,
    out Rhino.Geometry.Vector3d uDir,
    out Rhino.Geometry.Vector3d vDir,
    out Rhino.Geometry.Vector3d nDir
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.NurbsCurve[] MakeCompatible(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves,
    Rhino.Geometry.Point3d startPt,
    Rhino.Geometry.Point3d endPt,
    System.Int32 simplifyMethod,
    System.Int32 numPoints,
    System.Double refitTolerance,
    System.Double angleTolerance
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.NurbsCurve CreateParabolaFromVertex(
    Rhino.Geometry.Point3d vertex,
    Rhino.Geometry.Point3d startPoint,
    Rhino.Geometry.Point3d endPoint
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.NurbsCurve CreateParabolaFromFocus(
    Rhino.Geometry.Point3d focus,
    Rhino.Geometry.Point3d startPoint,
    Rhino.Geometry.Point3d endPoint
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.NurbsCurve CreateFromArc(
    Rhino.Geometry.Arc arc,
    System.Int32 degree,
    System.Int32 cvCount
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.NurbsCurve CreateHSpline(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.NurbsCurve CreateHSpline(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,
    Rhino.Geometry.Vector3d startTangent,
    Rhino.Geometry.Vector3d endTangent
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.NurbsCurve CreateSubDFriendly(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,
    System.Boolean interpolatePoints,
    System.Boolean periodicClosedCurve
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.NurbsCurve CreateSubDFriendly(Rhino.Geometry.Curve curve) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.NurbsCurve CreateSubDFriendly(
    Rhino.Geometry.Curve curve,
    System.Int32 pointCount,
    System.Boolean periodicClosedCurve
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Plane[] CreatePlanarRailFrames(
    System.Collections.Generic.IEnumerable<System.Double> parameters,
    Rhino.Geometry.Vector3d normal
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Plane[] CreateRailFrames(
    System.Collections.Generic.IEnumerable<System.Double> parameters
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.NurbsCurve CreateFromCircle(Rhino.Geometry.Circle circle) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.NurbsCurve CreateFromCircle(
    Rhino.Geometry.Circle circle,
    System.Int32 degree,
    System.Int32 cvCount
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.NurbsCurve CreateFromEllipse(Rhino.Geometry.Ellipse ellipse) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsDuplicate(
    Rhino.Geometry.NurbsCurve curveA,
    Rhino.Geometry.NurbsCurve curveB,
    System.Boolean ignoreParameterization,
    System.Double tolerance
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.NurbsCurve Create(
    System.Boolean periodic,
    System.Int32 degree,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean SetEndCondition(
    System.Boolean bSetEnd,
    Rhino.Geometry.NurbsCurve.NurbsCurveEndConditionType continuity,
    Rhino.Geometry.Point3d point,
    Rhino.Geometry.Vector3d tangent
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean SetEndCondition(
    System.Boolean bSetEnd,
    Rhino.Geometry.NurbsCurve.NurbsCurveEndConditionType continuity,
    Rhino.Geometry.Point3d point,
    Rhino.Geometry.Vector3d tangent,
    Rhino.Geometry.Vector3d curvature
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IncreaseDegree(System.Int32 desiredDegree) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean MakePiecewiseBezier(System.Boolean setEndWeightsToOne) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Reparameterize(System.Double c) => throw new System.NotImplementedException();

  public virtual System.Boolean Append(Rhino.Geometry.NurbsCurve nurbsCurve) =>
    throw new System.NotImplementedException();

  public virtual System.Double GrevilleParameter(System.Int32 index) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d GrevillePoint(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Double[] GrevilleParameters() => throw new System.NotImplementedException();

  public virtual Rhino.Collections.Point3dList GrevillePoints() => throw new System.NotImplementedException();

  public virtual Rhino.Collections.Point3dList GrevillePoints(System.Boolean all) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetGrevillePoints(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean EpsilonEquals(Rhino.Geometry.NurbsCurve other, System.Double epsilon) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.NurbsCurve CreateSpiral(
    Rhino.Geometry.Point3d axisStart,
    Rhino.Geometry.Vector3d axisDir,
    Rhino.Geometry.Point3d radiusPoint,
    System.Double pitch,
    System.Double turnCount,
    System.Double radius0,
    System.Double radius1
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.NurbsCurve CreateSpiral(
    Rhino.Geometry.Curve railCurve,
    System.Double t0,
    System.Double t1,
    Rhino.Geometry.Point3d radiusPoint,
    System.Double pitch,
    System.Double turnCount,
    System.Double radius0,
    System.Double radius1,
    System.Int32 pointsPerTurn
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 Order
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsRational
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Collections.NurbsCurveKnotList Knots
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Collections.NurbsCurvePointList Points
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean HasBezierSpans
  {
    get => throw new System.NotImplementedException();
  }
}
