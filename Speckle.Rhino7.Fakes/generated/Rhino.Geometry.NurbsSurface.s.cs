namespace Rhino.Geometry;

public partial class NurbsSurface : Rhino.Geometry.Surface,Rhino.IEpsilonComparable<Rhino.Geometry.NurbsSurface>
{
	public NurbsSurface() {}
	public NurbsSurface(Rhino.Geometry.NurbsSurface other) => throw new System.NotImplementedException();
	public static Rhino.Geometry.NurbsSurface Create(System.Int32 dimension,System.Boolean isRational,System.Int32 order0,System.Int32 order1,System.Int32 controlPointCount0,System.Int32 controlPointCount1) => throw new System.NotImplementedException();
	public static Rhino.Geometry.NurbsSurface CreateFromCone(Rhino.Geometry.Cone cone) => throw new System.NotImplementedException();
	public static Rhino.Geometry.NurbsSurface CreateFromCylinder(Rhino.Geometry.Cylinder cylinder) => throw new System.NotImplementedException();
	public static Rhino.Geometry.NurbsSurface CreateFromSphere(Rhino.Geometry.Sphere sphere) => throw new System.NotImplementedException();
	public static Rhino.Geometry.NurbsSurface CreateFromTorus(Rhino.Geometry.Torus torus) => throw new System.NotImplementedException();
	public static Rhino.Geometry.NurbsSurface CreateRuledSurface(Rhino.Geometry.Curve curveA,Rhino.Geometry.Curve curveB) => throw new System.NotImplementedException();
	public static Rhino.Geometry.NurbsSurface CreateSubDFriendly(Rhino.Geometry.Surface surface) => throw new System.NotImplementedException();
	public static Rhino.Geometry.NurbsSurface CreateFromPlane(Rhino.Geometry.Plane plane,Rhino.Geometry.Interval uInterval,Rhino.Geometry.Interval vInterval,System.Int32 uDegree,System.Int32 vDegree,System.Int32 uPointCount,System.Int32 vPointCount) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Point2d[] CreateCurveOnSurfacePoints(Rhino.Geometry.Surface surface,System.Collections.Generic.IEnumerable<Rhino.Geometry.Point2d> fixedPoints,System.Double tolerance,System.Boolean periodic,System.Int32 initCount,System.Int32 levels) => throw new System.NotImplementedException();
	public static Rhino.Geometry.NurbsCurve CreateCurveOnSurface(Rhino.Geometry.Surface surface,System.Collections.Generic.IEnumerable<Rhino.Geometry.Point2d> points,System.Double tolerance,System.Boolean periodic) => throw new System.NotImplementedException();
	public static System.Boolean MakeCompatible(Rhino.Geometry.Surface surface0,Rhino.Geometry.Surface surface1,out Rhino.Geometry.NurbsSurface nurb0,out Rhino.Geometry.NurbsSurface nurb1) => throw new System.NotImplementedException();
	public static Rhino.Geometry.NurbsSurface CreateFromPoints(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,System.Int32 uCount,System.Int32 vCount,System.Int32 uDegree,System.Int32 vDegree) => throw new System.NotImplementedException();
	public static Rhino.Geometry.NurbsSurface CreateThroughPoints(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,System.Int32 uCount,System.Int32 vCount,System.Int32 uDegree,System.Int32 vDegree,System.Boolean uClosed,System.Boolean vClosed) => throw new System.NotImplementedException();
	public static Rhino.Geometry.NurbsSurface CreateFromCorners(Rhino.Geometry.Point3d corner1,Rhino.Geometry.Point3d corner2,Rhino.Geometry.Point3d corner3,Rhino.Geometry.Point3d corner4) => throw new System.NotImplementedException();
	public static Rhino.Geometry.NurbsSurface CreateFromCorners(Rhino.Geometry.Point3d corner1,Rhino.Geometry.Point3d corner2,Rhino.Geometry.Point3d corner3,Rhino.Geometry.Point3d corner4,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.NurbsSurface CreateFromCorners(Rhino.Geometry.Point3d corner1,Rhino.Geometry.Point3d corner2,Rhino.Geometry.Point3d corner3) => throw new System.NotImplementedException();
	public static Rhino.Geometry.NurbsSurface CreateRailRevolvedSurface(Rhino.Geometry.Curve profile,Rhino.Geometry.Curve rail,Rhino.Geometry.Line axis,System.Boolean scaleHeight) => throw new System.NotImplementedException();
	public static Rhino.Geometry.NurbsSurface CreateNetworkSurface(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> uCurves,System.Int32 uContinuityStart,System.Int32 uContinuityEnd,System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> vCurves,System.Int32 vContinuityStart,System.Int32 vContinuityEnd,System.Double edgeTolerance,System.Double interiorTolerance,System.Double angleTolerance,out System.Int32 error) => throw new System.NotImplementedException();
	public static Rhino.Geometry.NurbsSurface CreateNetworkSurface(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves,System.Int32 continuity,System.Double edgeTolerance,System.Double interiorTolerance,System.Double angleTolerance,out System.Int32 error) => throw new System.NotImplementedException();
	public virtual System.Boolean UVNDirectionsAt(System.Double u,System.Double v,out Rhino.Geometry.Vector3d uDir,out Rhino.Geometry.Vector3d vDir,out Rhino.Geometry.Vector3d nDir) => throw new System.NotImplementedException();
	public virtual System.Boolean MakeRational() => throw new System.NotImplementedException();
	public virtual System.Boolean MakeNonRational() => throw new System.NotImplementedException();
	public virtual System.Boolean IncreaseDegreeU(System.Int32 desiredDegree) => throw new System.NotImplementedException();
	public virtual System.Boolean IncreaseDegreeV(System.Int32 desiredDegree) => throw new System.NotImplementedException();
	public virtual void CopyFrom(Rhino.Geometry.NurbsSurface other) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BezierSurface ConvertSpanToBezier(System.Int32 spanIndex0,System.Int32 spanIndex1) => throw new System.NotImplementedException();
	public virtual System.Boolean EpsilonEquals(Rhino.Geometry.NurbsSurface other,System.Double epsilon) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Collections.NurbsSurfaceKnotList KnotsU
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Collections.NurbsSurfaceKnotList KnotsV
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Collections.NurbsSurfacePointList Points
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsRational
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 OrderU
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 OrderV
	{
		get => throw new System.NotImplementedException();
	}
}
