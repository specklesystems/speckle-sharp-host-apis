namespace Rhino.Geometry;

public partial class Curve : Rhino.Geometry.GeometryBase
{
	public Curve() {}
	public virtual Rhino.Geometry.PointContainment Contains(Rhino.Geometry.Point3d testPoint,Rhino.Geometry.Plane plane,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Double[] ExtremeParameters(Rhino.Geometry.Vector3d direction) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve CreatePeriodicCurve(Rhino.Geometry.Curve curve) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve CreatePeriodicCurve(Rhino.Geometry.Curve curve,System.Boolean smooth) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d PointAt(System.Double t) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d PointAtLength(System.Double length) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d PointAtNormalizedLength(System.Double length) => throw new System.NotImplementedException();
	public virtual System.Boolean SetStartPoint(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public virtual System.Boolean SetEndPoint(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Vector3d TangentAt(System.Double t) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Vector3d[] DerivativeAt(System.Double t,System.Int32 derivativeCount) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Vector3d[] DerivativeAt(System.Double t,System.Int32 derivativeCount,Rhino.Geometry.CurveEvaluationSide side) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Vector3d CurvatureAt(System.Double t) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Plane[] GetPerpendicularFrames(System.Collections.Generic.IEnumerable<System.Double> parameters) => throw new System.NotImplementedException();
	public virtual System.Boolean IsContinuous(Rhino.Geometry.Continuity continuityType,System.Double t) => throw new System.NotImplementedException();
	public virtual System.Double TorsionAt(System.Double t) => throw new System.NotImplementedException();
	public virtual System.Double GetLength() => throw new System.NotImplementedException();
	public virtual System.Double GetLength(System.Double fractionalTolerance) => throw new System.NotImplementedException();
	public virtual System.Double GetLength(Rhino.Geometry.Interval subdomain) => throw new System.NotImplementedException();
	public virtual System.Double GetLength(System.Double fractionalTolerance,Rhino.Geometry.Interval subdomain) => throw new System.NotImplementedException();
	public virtual System.Boolean IsShort(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean IsShort(System.Double tolerance,Rhino.Geometry.Interval subdomain) => throw new System.NotImplementedException();
	public virtual System.Boolean RemoveShortSegments(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Double[] NormalizedLengthParameters(System.Double[] s,System.Double absoluteTolerance) => throw new System.NotImplementedException();
	public virtual System.Double[] NormalizedLengthParameters(System.Double[] s,System.Double absoluteTolerance,System.Double fractionalTolerance) => throw new System.NotImplementedException();
	public virtual System.Double[] NormalizedLengthParameters(System.Double[] s,System.Double absoluteTolerance,Rhino.Geometry.Interval subdomain) => throw new System.NotImplementedException();
	public virtual System.Double[] NormalizedLengthParameters(System.Double[] s,System.Double absoluteTolerance,System.Double fractionalTolerance,Rhino.Geometry.Interval subdomain) => throw new System.NotImplementedException();
	public virtual System.Double[] DivideByCount(System.Int32 segmentCount,System.Boolean includeEnds) => throw new System.NotImplementedException();
	public virtual System.Double[] DivideByLength(System.Double segmentLength,System.Boolean includeEnds) => throw new System.NotImplementedException();
	public virtual System.Double[] DivideByLength(System.Double segmentLength,System.Boolean includeEnds,System.Boolean reverse) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d[] DivideEquidistant(System.Double distance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d[] DivideAsContour(Rhino.Geometry.Point3d contourStart,Rhino.Geometry.Point3d contourEnd,System.Double interval) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve Trim(System.Double t0,System.Double t1) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve Trim(Rhino.Geometry.Interval domain) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve Trim(Rhino.Geometry.CurveEnd side,System.Double length) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] Split(System.Double t) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] Split(System.Collections.Generic.IEnumerable<System.Double> t) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] Split(Rhino.Geometry.Brep cutter,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] Split(Rhino.Geometry.Brep cutter,System.Double tolerance,System.Double angleToleranceRadians) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] Split(Rhino.Geometry.Surface cutter,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] Split(Rhino.Geometry.Surface cutter,System.Double tolerance,System.Double angleToleranceRadians) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve Extend(System.Double t0,System.Double t1) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve Extend(Rhino.Geometry.Interval domain) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve Extend(Rhino.Geometry.CurveEnd side,System.Double length,Rhino.Geometry.CurveExtensionStyle style) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve Extend(Rhino.Geometry.CurveEnd side,Rhino.Geometry.CurveExtensionStyle style,System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> geometry) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve Extend(Rhino.Geometry.CurveEnd side,Rhino.Geometry.CurveExtensionStyle style,Rhino.Geometry.Point3d endPoint) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve ExtendOnSurface(Rhino.Geometry.CurveEnd side,Rhino.Geometry.Surface surface) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve ExtendOnSurface(Rhino.Geometry.CurveEnd side,Rhino.Geometry.BrepFace face) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve ExtendByLine(Rhino.Geometry.CurveEnd side,System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> geometry) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve ExtendByArc(Rhino.Geometry.CurveEnd side,System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> geometry) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve Simplify(Rhino.Geometry.CurveSimplifyOptions options,System.Double distanceTolerance,System.Double angleToleranceRadians) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve SimplifyEnd(Rhino.Geometry.CurveEnd end,Rhino.Geometry.CurveSimplifyOptions options,System.Double distanceTolerance,System.Double angleToleranceRadians) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve Fair(System.Double distanceTolerance,System.Double angleTolerance,System.Int32 clampStart,System.Int32 clampEnd,System.Int32 iterations) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve Fit(System.Int32 degree,System.Double fitTolerance,System.Double angleTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.NurbsCurve Rebuild(System.Int32 pointCount,System.Int32 degree,System.Boolean preserveTangents) => throw new System.NotImplementedException();
	public virtual System.Int32 HasNurbsForm() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.NurbsCurve ToNurbsCurve() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.NurbsCurve ToNurbsCurve(Rhino.Geometry.Interval subdomain) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Interval SpanDomain(System.Int32 spanIndex) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.PolylineCurve ToPolyline(System.Int32 mainSegmentCount,System.Int32 subSegmentCount,System.Double maxAngleRadians,System.Double maxChordLengthRatio,System.Double maxAspectRatio,System.Double tolerance,System.Double minEdgeLength,System.Double maxEdgeLength,System.Boolean keepStartPoint) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.PolylineCurve ToPolyline(System.Int32 mainSegmentCount,System.Int32 subSegmentCount,System.Double maxAngleRadians,System.Double maxChordLengthRatio,System.Double maxAspectRatio,System.Double tolerance,System.Double minEdgeLength,System.Double maxEdgeLength,System.Boolean keepStartPoint,Rhino.Geometry.Interval curveDomain) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.PolylineCurve ToPolyline(System.Double tolerance,System.Double angleTolerance,System.Double minimumLength,System.Double maximumLength) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.PolyCurve ToArcsAndLines(System.Double tolerance,System.Double angleTolerance,System.Double minimumLength,System.Double maximumLength) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.PolylineCurve PullToMesh(Rhino.Geometry.Mesh mesh,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] Offset(Rhino.Geometry.Plane plane,System.Double distance,System.Double tolerance,Rhino.Geometry.CurveOffsetCornerStyle cornerStyle) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] Offset(Rhino.Geometry.Point3d directionPoint,Rhino.Geometry.Vector3d normal,System.Double distance,System.Double tolerance,Rhino.Geometry.CurveOffsetCornerStyle cornerStyle) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] Offset(Rhino.Geometry.Point3d directionPoint,Rhino.Geometry.Vector3d normal,System.Double distance,System.Double tolerance,System.Double angleTolerance,System.Boolean loose,Rhino.Geometry.CurveOffsetCornerStyle cornerStyle,Rhino.Geometry.CurveOffsetEndStyle endStyle) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve RibbonOffset(System.Double distance,System.Double blendRadius,Rhino.Geometry.Point3d directionPoint,Rhino.Geometry.Vector3d normal,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] OffsetOnSurface(Rhino.Geometry.BrepFace face,System.Double distance,System.Double fittingTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] OffsetOnSurface(Rhino.Geometry.BrepFace face,Rhino.Geometry.Point2d throughPoint,System.Double fittingTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] OffsetOnSurface(Rhino.Geometry.BrepFace face,System.Double[] curveParameters,System.Double[] offsetDistances,System.Double fittingTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] OffsetOnSurface(Rhino.Geometry.Surface surface,System.Double distance,System.Double fittingTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] OffsetOnSurface(Rhino.Geometry.Surface surface,Rhino.Geometry.Point2d throughPoint,System.Double fittingTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] OffsetOnSurface(Rhino.Geometry.Surface surface,System.Double[] curveParameters,System.Double[] offsetDistances,System.Double fittingTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] PullToBrepFace(Rhino.Geometry.BrepFace face,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve OffsetNormalToSurface(Rhino.Geometry.Surface surface,System.Double height) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.ConicSectionType GetConicSectionType() => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve CreateInterpolatedCurve(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,System.Int32 degree) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve CreateInterpolatedCurve(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,System.Int32 degree,Rhino.Geometry.CurveKnotStyle knots) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve CreateInterpolatedCurve(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,System.Int32 degree,Rhino.Geometry.CurveKnotStyle knots,Rhino.Geometry.Vector3d startTangent,Rhino.Geometry.Vector3d endTangent) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve CreateSoftEditCurve(Rhino.Geometry.Curve curve,System.Double t,Rhino.Geometry.Vector3d delta,System.Double length,System.Boolean fixEnds) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve CreateFilletCornersCurve(Rhino.Geometry.Curve curve,System.Double radius,System.Double tolerance,System.Double angleTolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve CreateControlPointCurve(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,System.Int32 degree) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve CreateControlPointCurve(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve CreateArcLineArcBlend(Rhino.Geometry.Point3d startPt,Rhino.Geometry.Vector3d startDir,Rhino.Geometry.Point3d endPt,Rhino.Geometry.Vector3d endDir,System.Double radius) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve CreateArcBlend(Rhino.Geometry.Point3d startPt,Rhino.Geometry.Vector3d startDir,Rhino.Geometry.Point3d endPt,Rhino.Geometry.Vector3d endDir,System.Double controlPointLengthRatio) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve CreateMeanCurve(Rhino.Geometry.Curve curveA,Rhino.Geometry.Curve curveB,System.Double angleToleranceRadians) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve CreateMeanCurve(Rhino.Geometry.Curve curveA,Rhino.Geometry.Curve curveB) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve CreateBlendCurve(Rhino.Geometry.Curve curveA,Rhino.Geometry.Curve curveB,Rhino.Geometry.BlendContinuity continuity) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve CreateBlendCurve(Rhino.Geometry.Curve curveA,Rhino.Geometry.Curve curveB,Rhino.Geometry.BlendContinuity continuity,System.Double bulgeA,System.Double bulgeB) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve CreateBlendCurve(Rhino.Geometry.Curve curve0,System.Double t0,System.Boolean reverse0,Rhino.Geometry.BlendContinuity continuity0,Rhino.Geometry.Curve curve1,System.Double t1,System.Boolean reverse1,Rhino.Geometry.BlendContinuity continuity1) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateMatchCurve(Rhino.Geometry.Curve curve0,System.Boolean reverse0,Rhino.Geometry.BlendContinuity continuity,Rhino.Geometry.Curve curve1,System.Boolean reverse1,Rhino.Geometry.PreserveEnd preserve,System.Boolean average) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateTweenCurves(Rhino.Geometry.Curve curve0,Rhino.Geometry.Curve curve1,System.Int32 numCurves) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateTweenCurves(Rhino.Geometry.Curve curve0,Rhino.Geometry.Curve curve1,System.Int32 numCurves,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateTweenCurvesWithMatching(Rhino.Geometry.Curve curve0,Rhino.Geometry.Curve curve1,System.Int32 numCurves) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateTweenCurvesWithMatching(Rhino.Geometry.Curve curve0,Rhino.Geometry.Curve curve1,System.Int32 numCurves,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateTweenCurvesWithSampling(Rhino.Geometry.Curve curve0,Rhino.Geometry.Curve curve1,System.Int32 numCurves,System.Int32 numSamples) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateTweenCurvesWithSampling(Rhino.Geometry.Curve curve0,Rhino.Geometry.Curve curve1,System.Int32 numCurves,System.Int32 numSamples,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] JoinCurves(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> inputCurves) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] JoinCurves(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> inputCurves,System.Double joinTolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] JoinCurves(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> inputCurves,System.Double joinTolerance,System.Boolean preserveDirection) => throw new System.NotImplementedException();
	public static System.Boolean MakeEndsMeet(Rhino.Geometry.Curve curveA,System.Boolean adjustStartCurveA,Rhino.Geometry.Curve curveB,System.Boolean adjustStartCurveB) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Arc CreateFillet(Rhino.Geometry.Curve curve0,Rhino.Geometry.Curve curve1,System.Double radius,System.Double t0Base,System.Double t1Base) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateFilletCurves(Rhino.Geometry.Curve curve0,Rhino.Geometry.Point3d point0,Rhino.Geometry.Curve curve1,Rhino.Geometry.Point3d point1,System.Double radius,System.Boolean join,System.Boolean trim,System.Boolean arcExtension,System.Double tolerance,System.Double angleTolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateBooleanUnion(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateBooleanUnion(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateBooleanIntersection(Rhino.Geometry.Curve curveA,Rhino.Geometry.Curve curveB) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateBooleanIntersection(Rhino.Geometry.Curve curveA,Rhino.Geometry.Curve curveB,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateBooleanDifference(Rhino.Geometry.Curve curveA,Rhino.Geometry.Curve curveB) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateBooleanDifference(Rhino.Geometry.Curve curveA,Rhino.Geometry.Curve curveB,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateBooleanDifference(Rhino.Geometry.Curve curveA,System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> subtractors) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateBooleanDifference(Rhino.Geometry.Curve curveA,System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> subtractors,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.CurveBooleanRegions CreateBooleanRegions(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves,Rhino.Geometry.Plane plane,System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,System.Boolean combineRegions,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.CurveBooleanRegions CreateBooleanRegions(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves,Rhino.Geometry.Plane plane,System.Boolean combineRegions,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateTextOutlines(System.String text,System.String font,System.Double textHeight,System.Int32 textStyle,System.Boolean closeLoops,Rhino.Geometry.Plane plane,System.Double smallCapsScale,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateCurve2View(Rhino.Geometry.Curve curveA,Rhino.Geometry.Curve curveB,Rhino.Geometry.Vector3d vectorA,Rhino.Geometry.Vector3d vectorB,System.Double tolerance,System.Double angleTolerance) => throw new System.NotImplementedException();
	public static System.Boolean DoDirectionsMatch(Rhino.Geometry.Curve curveA,Rhino.Geometry.Curve curveB) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] ProjectToMesh(Rhino.Geometry.Curve curve,Rhino.Geometry.Mesh mesh,Rhino.Geometry.Vector3d direction,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] ProjectToMesh(Rhino.Geometry.Curve curve,System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> meshes,Rhino.Geometry.Vector3d direction,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] ProjectToMesh(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves,System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> meshes,Rhino.Geometry.Vector3d direction,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] ProjectToBrep(Rhino.Geometry.Curve curve,Rhino.Geometry.Brep brep,Rhino.Geometry.Vector3d direction,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] ProjectToBrep(Rhino.Geometry.Curve curve,System.Collections.Generic.IEnumerable<Rhino.Geometry.Brep> breps,Rhino.Geometry.Vector3d direction,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] ProjectToBrep(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves,System.Collections.Generic.IEnumerable<Rhino.Geometry.Brep> breps,Rhino.Geometry.Vector3d direction,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve ProjectToPlane(Rhino.Geometry.Curve curve,Rhino.Geometry.Plane plane) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] PullToBrepFace(Rhino.Geometry.Curve curve,Rhino.Geometry.BrepFace face,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.RegionContainment PlanarClosedCurveRelationship(Rhino.Geometry.Curve curveA,Rhino.Geometry.Curve curveB,Rhino.Geometry.Plane testPlane,System.Double tolerance) => throw new System.NotImplementedException();
	public static System.Boolean PlanarCurveCollision(Rhino.Geometry.Curve curveA,Rhino.Geometry.Curve curveB,Rhino.Geometry.Plane testPlane,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve DuplicateCurve() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] DuplicateSegments() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve Smooth(System.Double smoothFactor,System.Boolean bXSmooth,System.Boolean bYSmooth,System.Boolean bZSmooth,System.Boolean bFixBoundaries,Rhino.Geometry.SmoothingCoordinateSystem coordinateSystem) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve Smooth(System.Double smoothFactor,System.Boolean bXSmooth,System.Boolean bYSmooth,System.Boolean bZSmooth,System.Boolean bFixBoundaries,Rhino.Geometry.SmoothingCoordinateSystem coordinateSystem,Rhino.Geometry.Plane plane) => throw new System.NotImplementedException();
	public virtual System.Boolean ChangeDimension(System.Int32 desiredDimension) => throw new System.NotImplementedException();
	public virtual System.Boolean IsLinear() => throw new System.NotImplementedException();
	public virtual System.Boolean IsLinear(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean IsPolyline() => throw new System.NotImplementedException();
	public virtual System.Boolean IsArc() => throw new System.NotImplementedException();
	public virtual System.Boolean IsArc(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean IsCircle() => throw new System.NotImplementedException();
	public virtual System.Boolean IsCircle(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean IsEllipse() => throw new System.NotImplementedException();
	public virtual System.Boolean IsEllipse(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean IsPlanar() => throw new System.NotImplementedException();
	public virtual System.Boolean IsPlanar(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean IsInPlane(Rhino.Geometry.Plane testPlane) => throw new System.NotImplementedException();
	public virtual System.Boolean IsInPlane(Rhino.Geometry.Plane testPlane,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean ChangeClosedCurveSeam(System.Double t) => throw new System.NotImplementedException();
	public virtual System.Boolean IsClosable(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean IsClosable(System.Double tolerance,System.Double minimumAbsoluteSize,System.Double minimumRelativeSize) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d[] InflectionPoints() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d[] MaxCurvaturePoints() => throw new System.NotImplementedException();
	public virtual System.Boolean MakeClosed(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean CombineShortSegments(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.CurveOrientation ClosedCurveOrientation() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.CurveOrientation ClosedCurveOrientation(Rhino.Geometry.Vector3d upDirection) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.CurveOrientation ClosedCurveOrientation(Rhino.Geometry.Plane plane) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.CurveOrientation ClosedCurveOrientation(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public virtual System.Boolean Reverse() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.PointContainment Contains(Rhino.Geometry.Point3d testPoint) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.PointContainment Contains(Rhino.Geometry.Point3d testPoint,Rhino.Geometry.Plane plane) => throw new System.NotImplementedException();
	public virtual System.Boolean IsSubDFriendly
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Interval Domain
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 Dimension
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 SpanCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 Degree
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsClosed
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsPeriodic
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Point3d PointAtStart
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Point3d PointAtEnd
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Vector3d TangentAtStart
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Vector3d TangentAtEnd
	{
		get => throw new System.NotImplementedException();
	}
}
