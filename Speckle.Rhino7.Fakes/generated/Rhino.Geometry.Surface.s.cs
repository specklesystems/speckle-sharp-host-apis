namespace Rhino.Geometry;

public partial class Surface : Rhino.Geometry.GeometryBase
{
	public Surface() {}
	public virtual Rhino.Geometry.Interval Domain(System.Int32 direction) => throw new System.NotImplementedException();
	public virtual System.Boolean SetDomain(System.Int32 direction,Rhino.Geometry.Interval domain) => throw new System.NotImplementedException();
	public virtual System.Int32 Degree(System.Int32 direction) => throw new System.NotImplementedException();
	public virtual System.Int32 SpanCount(System.Int32 direction) => throw new System.NotImplementedException();
	public virtual System.Double[] GetSpanVector(System.Int32 direction) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Surface Reverse(System.Int32 direction) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Surface Reverse(System.Int32 direction,System.Boolean inPlace) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Surface Transpose() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Surface Transpose(System.Boolean inPlace) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d PointAt(System.Double u,System.Double v) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Vector3d NormalAt(System.Double u,System.Double v) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.SurfaceCurvature CurvatureAt(System.Double u,System.Double v) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.IsoStatus IsIsoparametric(Rhino.Geometry.Curve curve,Rhino.Geometry.Interval curveDomain) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.IsoStatus IsIsoparametric(Rhino.Geometry.Curve curve) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.IsoStatus IsIsoparametric(Rhino.Geometry.BoundingBox bbox) => throw new System.NotImplementedException();
	public virtual System.Boolean IsClosed(System.Int32 direction) => throw new System.NotImplementedException();
	public virtual System.Boolean IsPeriodic(System.Int32 direction) => throw new System.NotImplementedException();
	public virtual System.Boolean IsSingular(System.Int32 side) => throw new System.NotImplementedException();
	public virtual System.Boolean IsAtSingularity(System.Double u,System.Double v,System.Boolean exact) => throw new System.NotImplementedException();
	public virtual System.Int32 IsAtSeam(System.Double u,System.Double v) => throw new System.NotImplementedException();
	public virtual System.Boolean IsContinuous(Rhino.Geometry.Continuity continuityType,System.Double u,System.Double v) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Surface Trim(Rhino.Geometry.Interval u,Rhino.Geometry.Interval v) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve IsoCurve(System.Int32 direction,System.Double constantParameter) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Surface Split(System.Int32 direction,System.Double parameter) => throw new System.NotImplementedException();
	public virtual System.Boolean Extend(System.Int32 direction,Rhino.Geometry.Interval interval) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep ToBrep() => throw new System.NotImplementedException();
	public virtual System.Int32 HasNurbsForm() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.NurbsSurface ToNurbsSurface() => throw new System.NotImplementedException();
	public virtual System.Boolean IsPlanar() => throw new System.NotImplementedException();
	public virtual System.Boolean IsPlanar(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean IsSphere() => throw new System.NotImplementedException();
	public virtual System.Boolean IsSphere(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean IsCylinder() => throw new System.NotImplementedException();
	public virtual System.Boolean IsCylinder(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean IsCone() => throw new System.NotImplementedException();
	public virtual System.Boolean IsCone(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean IsTorus() => throw new System.NotImplementedException();
	public virtual System.Boolean IsTorus(System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Surface CreateRollingBallFillet(Rhino.Geometry.Surface surfaceA,Rhino.Geometry.Surface surfaceB,System.Double radius,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Surface CreateRollingBallFillet(Rhino.Geometry.Surface surfaceA,System.Boolean flipA,Rhino.Geometry.Surface surfaceB,System.Boolean flipB,System.Double radius,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Surface CreateRollingBallFillet(Rhino.Geometry.Surface surfaceA,Rhino.Geometry.Point2d uvA,Rhino.Geometry.Surface surfaceB,Rhino.Geometry.Point2d uvB,System.Double radius,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Surface CreateExtrusion(Rhino.Geometry.Curve profile,Rhino.Geometry.Vector3d direction) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Surface CreateExtrusionToPoint(Rhino.Geometry.Curve profile,Rhino.Geometry.Point3d apexPoint) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Surface CreatePeriodicSurface(Rhino.Geometry.Surface surface,System.Int32 direction) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Surface CreatePeriodicSurface(Rhino.Geometry.Surface surface,System.Int32 direction,System.Boolean bSmooth) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Surface CreateSoftEditSurface(Rhino.Geometry.Surface surface,Rhino.Geometry.Point2d uv,Rhino.Geometry.Vector3d delta,System.Double uLength,System.Double vLength,System.Double tolerance,System.Boolean fixEnds) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Surface Smooth(System.Double smoothFactor,System.Boolean bXSmooth,System.Boolean bYSmooth,System.Boolean bZSmooth,System.Boolean bFixBoundaries,Rhino.Geometry.SmoothingCoordinateSystem coordinateSystem) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Surface Smooth(System.Double smoothFactor,System.Boolean bXSmooth,System.Boolean bYSmooth,System.Boolean bZSmooth,System.Boolean bFixBoundaries,Rhino.Geometry.SmoothingCoordinateSystem coordinateSystem,Rhino.Geometry.Plane plane) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Surface VariableOffset(System.Double uMinvMin,System.Double uMinvMax,System.Double uMaxvMin,System.Double uMaxvMax,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Surface VariableOffset(System.Double uMinvMin,System.Double uMinvMax,System.Double uMaxvMin,System.Double uMaxvMax,System.Collections.Generic.IEnumerable<Rhino.Geometry.Point2d> interiorParameters,System.Collections.Generic.IEnumerable<System.Double> interiorDistances,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.IsoStatus ClosestSide(System.Double u,System.Double v) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Surface Extend(Rhino.Geometry.IsoStatus edge,System.Double extensionLength,System.Boolean smooth) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.NurbsSurface Rebuild(System.Int32 uDegree,System.Int32 vDegree,System.Int32 uPointCount,System.Int32 vPointCount) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.NurbsSurface RebuildOneDirection(System.Int32 direction,System.Int32 pointCount,Rhino.Geometry.LoftType loftType,System.Double refitTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Surface Offset(System.Double distance,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Surface Fit(System.Int32 uDegree,System.Int32 vDegree,System.Double fitTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.NurbsCurve InterpolatedCurveOnSurfaceUV(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point2d> points,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.NurbsCurve InterpolatedCurveOnSurfaceUV(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point2d> points,System.Double tolerance,System.Boolean closed,System.Int32 closedSurfaceHandling) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.NurbsCurve InterpolatedCurveOnSurface(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve ShortPath(Rhino.Geometry.Point2d start,Rhino.Geometry.Point2d end,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve Pushup(Rhino.Geometry.Curve curve2d,System.Double tolerance,Rhino.Geometry.Interval curve2dSubdomain) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve Pushup(Rhino.Geometry.Curve curve2d,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve Pullback(Rhino.Geometry.Curve curve3d,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve Pullback(Rhino.Geometry.Curve curve3d,System.Double tolerance,Rhino.Geometry.Interval curve3dSubdomain) => throw new System.NotImplementedException();
	public virtual System.Boolean IsSolid
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsSubDFriendly
	{
		get => throw new System.NotImplementedException();
	}
}
