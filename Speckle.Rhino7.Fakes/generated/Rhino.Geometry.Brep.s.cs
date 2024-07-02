namespace Rhino.Geometry;

public partial class Brep : Rhino.Geometry.GeometryBase
{
	public Brep() {}
	public virtual System.Boolean IsPointInside(Rhino.Geometry.Point3d point,System.Double tolerance,System.Boolean strictlyIn) => throw new System.NotImplementedException();
	public virtual System.Boolean GetPointInside(System.Double tolerance,out Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep CapPlanarHoles(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean Join(Rhino.Geometry.Brep otherBrep,System.Double tolerance,System.Boolean compact) => throw new System.NotImplementedException();
	public virtual System.Int32 JoinNakedEdges(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean MergeCoplanarFaces(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean MergeCoplanarFaces(System.Double tolerance,System.Double angleTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep[] Split(Rhino.Geometry.Brep cutter,System.Double intersectionTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep[] Split(Rhino.Geometry.Brep cutter,System.Double intersectionTolerance,out System.Boolean toleranceWasRaised) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep[] Split(System.Collections.Generic.IEnumerable<Rhino.Geometry.Brep> cutters,System.Double intersectionTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep[] Split(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> cutters,System.Double intersectionTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep[] Split(System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> cutters,Rhino.Geometry.Vector3d normal,System.Boolean planView,System.Double intersectionTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep[] Trim(Rhino.Geometry.Brep cutter,System.Double intersectionTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep[] Trim(Rhino.Geometry.Plane cutter,System.Double intersectionTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep[] UnjoinEdges(System.Collections.Generic.IEnumerable<System.Int32> edgesToUnjoin) => throw new System.NotImplementedException();
	public virtual System.Boolean JoinEdges(System.Int32 edgeIndex0,System.Int32 edgeIndex1,System.Double joinTolerance,System.Boolean compact) => throw new System.NotImplementedException();
	public virtual System.Boolean TransformComponent(System.Collections.Generic.IEnumerable<Rhino.Geometry.ComponentIndex> components,Rhino.Geometry.Transform xform,System.Double tolerance,System.Double timeLimit,System.Boolean useMultipleThreads) => throw new System.NotImplementedException();
	public virtual System.Double GetArea() => throw new System.NotImplementedException();
	public virtual System.Double GetArea(System.Double relativeTolerance,System.Double absoluteTolerance) => throw new System.NotImplementedException();
	public virtual System.Double GetVolume() => throw new System.NotImplementedException();
	public virtual System.Double GetVolume(System.Double relativeTolerance,System.Double absoluteTolerance) => throw new System.NotImplementedException();
	public virtual System.Int32 AddTrimCurve(Rhino.Geometry.Curve curve) => throw new System.NotImplementedException();
	public virtual System.Int32 AddEdgeCurve(Rhino.Geometry.Curve curve) => throw new System.NotImplementedException();
	public virtual System.Int32 AddSurface(Rhino.Geometry.Surface surface) => throw new System.NotImplementedException();
	public virtual void Append(Rhino.Geometry.Brep other) => throw new System.NotImplementedException();
	public virtual void SetVertices() => throw new System.NotImplementedException();
	public virtual void SetTrimIsoFlags() => throw new System.NotImplementedException();
	public virtual void SetTolerancesBoxesAndFlags() => throw new System.NotImplementedException();
	public virtual void SetTolerancesBoxesAndFlags(System.Boolean bLazy,System.Boolean bSetVertexTolerances,System.Boolean bSetEdgeTolerances,System.Boolean bSetTrimTolerances,System.Boolean bSetTrimIsoFlags,System.Boolean bSetTrimTypeFlags,System.Boolean bSetLoopTypeFlags,System.Boolean bSetTrimBoxes) => throw new System.NotImplementedException();
	public virtual void RebuildTrimsForV2(Rhino.Geometry.BrepFace face,Rhino.Geometry.NurbsSurface nurbsSurface) => throw new System.NotImplementedException();
	public virtual System.Boolean MakeValidForV2() => throw new System.NotImplementedException();
	public virtual void Compact() => throw new System.NotImplementedException();
	public virtual System.Boolean Repair(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep RemoveHoles(System.Double tolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep RemoveHoles(System.Collections.Generic.IEnumerable<Rhino.Geometry.ComponentIndex> loops,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean CullUnusedFaces() => throw new System.NotImplementedException();
	public virtual System.Boolean CullUnusedLoops() => throw new System.NotImplementedException();
	public virtual System.Boolean CullUnusedTrims() => throw new System.NotImplementedException();
	public virtual System.Boolean CullUnusedEdges() => throw new System.NotImplementedException();
	public virtual System.Boolean CullUnusedVertices() => throw new System.NotImplementedException();
	public virtual System.Boolean CullUnused3dCurves() => throw new System.NotImplementedException();
	public virtual System.Boolean CullUnused2dCurves() => throw new System.NotImplementedException();
	public virtual System.Boolean CullUnusedSurfaces() => throw new System.NotImplementedException();
	public virtual void Standardize() => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep TryConvertBrep(Rhino.Geometry.GeometryBase geometry) => throw new System.NotImplementedException();
	public virtual System.Boolean IsBox() => throw new System.NotImplementedException();
	public virtual System.Boolean IsBox(System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep ChangeSeam(Rhino.Geometry.BrepFace face,System.Int32 direction,System.Double parameter,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CopyTrimCurves(Rhino.Geometry.BrepFace trimSource,Rhino.Geometry.Surface surfaceSource,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateBaseballSphere(Rhino.Geometry.Point3d center,System.Double radius,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateDevelopableLoft(Rhino.Geometry.Curve crv0,Rhino.Geometry.Curve crv1,System.Boolean reverse0,System.Boolean reverse1,System.Int32 density) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateDevelopableLoft(Rhino.Geometry.NurbsCurve rail0,Rhino.Geometry.NurbsCurve rail1,System.Collections.Generic.IEnumerable<Rhino.Geometry.Point2d> fixedRulings) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateFromMesh(Rhino.Geometry.Mesh mesh,System.Boolean trimmedTriangles) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateFromBox(Rhino.Geometry.BoundingBox box) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateFromBox(Rhino.Geometry.Box box) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateFromBox(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> corners) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateFromCylinder(Rhino.Geometry.Cylinder cylinder,System.Boolean capBottom,System.Boolean capTop) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateFromSphere(Rhino.Geometry.Sphere sphere) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateQuadSphere(Rhino.Geometry.Sphere sphere) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateFromCone(Rhino.Geometry.Cone cone,System.Boolean capBottom) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateFromRevSurface(Rhino.Geometry.RevSurface surface,System.Boolean capStart,System.Boolean capEnd) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateFromSurface(Rhino.Geometry.Surface surface) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateTrimmedPlane(Rhino.Geometry.Plane plane,Rhino.Geometry.Curve curve) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateTrimmedPlane(Rhino.Geometry.Plane plane,System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreatePlanarBreps(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> inputLoops) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreatePlanarBreps(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> inputLoops,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreatePlanarBreps(Rhino.Geometry.Curve inputLoop) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreatePlanarBreps(Rhino.Geometry.Curve inputLoop,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateTrimmedSurface(Rhino.Geometry.BrepFace trimSource,Rhino.Geometry.Surface surfaceSource) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateTrimmedSurface(Rhino.Geometry.BrepFace trimSource,Rhino.Geometry.Surface surfaceSource,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateFromCornerPoints(Rhino.Geometry.Point3d corner1,Rhino.Geometry.Point3d corner2,Rhino.Geometry.Point3d corner3,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateFromCornerPoints(Rhino.Geometry.Point3d corner1,Rhino.Geometry.Point3d corner2,Rhino.Geometry.Point3d corner3,Rhino.Geometry.Point3d corner4,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateEdgeSurface(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreatePlanarBreps(Rhino.Collections.CurveList inputLoops) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreatePlanarBreps(Rhino.Collections.CurveList inputLoops,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateFromOffsetFace(Rhino.Geometry.BrepFace face,System.Double offsetDistance,System.Double offsetTolerance,System.Boolean bothSides,System.Boolean createSolid) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateSolid(System.Collections.Generic.IEnumerable<Rhino.Geometry.Brep> breps,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep MergeSurfaces(Rhino.Geometry.Surface surface0,Rhino.Geometry.Surface surface1,System.Double tolerance,System.Double angleToleranceRadians) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep MergeSurfaces(Rhino.Geometry.Brep brep0,Rhino.Geometry.Brep brep1,System.Double tolerance,System.Double angleToleranceRadians) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep MergeSurfaces(Rhino.Geometry.Brep brep0,Rhino.Geometry.Brep brep1,System.Double tolerance,System.Double angleToleranceRadians,Rhino.Geometry.Point2d point0,Rhino.Geometry.Point2d point1,System.Double roundness,System.Boolean smooth) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreatePatch(System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> geometry,Rhino.Geometry.Surface startingSurface,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreatePatch(System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> geometry,System.Int32 uSpans,System.Int32 vSpans,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreatePatch(System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> geometry,Rhino.Geometry.Surface startingSurface,System.Int32 uSpans,System.Int32 vSpans,System.Boolean trim,System.Boolean tangency,System.Double pointSpacing,System.Double flexibility,System.Double surfacePull,System.Boolean[] fixEdges,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreatePipe(Rhino.Geometry.Curve rail,System.Double radius,System.Boolean localBlending,Rhino.Geometry.PipeCapMode cap,System.Boolean fitRail,System.Double absoluteTolerance,System.Double angleToleranceRadians) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreatePipe(Rhino.Geometry.Curve rail,System.Collections.Generic.IEnumerable<System.Double> railRadiiParameters,System.Collections.Generic.IEnumerable<System.Double> radii,System.Boolean localBlending,Rhino.Geometry.PipeCapMode cap,System.Boolean fitRail,System.Double absoluteTolerance,System.Double angleToleranceRadians) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateThickPipe(Rhino.Geometry.Curve rail,System.Double radius0,System.Double radius1,System.Boolean localBlending,Rhino.Geometry.PipeCapMode cap,System.Boolean fitRail,System.Double absoluteTolerance,System.Double angleToleranceRadians) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateThickPipe(Rhino.Geometry.Curve rail,System.Collections.Generic.IEnumerable<System.Double> railRadiiParameters,System.Collections.Generic.IEnumerable<System.Double> radii0,System.Collections.Generic.IEnumerable<System.Double> radii1,System.Boolean localBlending,Rhino.Geometry.PipeCapMode cap,System.Boolean fitRail,System.Double absoluteTolerance,System.Double angleToleranceRadians) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFromSweep(Rhino.Geometry.Curve rail,Rhino.Geometry.Curve shape,System.Boolean closed,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFromSweep(Rhino.Geometry.Curve rail,System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> shapes,System.Boolean closed,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFromSweep(Rhino.Geometry.Curve rail,System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> shapes,Rhino.Geometry.Point3d startPoint,Rhino.Geometry.Point3d endPoint,Rhino.Geometry.SweepFrame frameType,Rhino.Geometry.Vector3d roadlikeNormal,System.Boolean closed,Rhino.Geometry.SweepBlend blendType,Rhino.Geometry.SweepMiter miterType,System.Double tolerance,Rhino.Geometry.SweepRebuild rebuildType,System.Int32 rebuildPointCount,System.Double refitTolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFromSweepSegmented(Rhino.Geometry.Curve rail,Rhino.Geometry.Curve shape,System.Boolean closed,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFromSweepSegmented(Rhino.Geometry.Curve rail,System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> shapes,System.Boolean closed,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFromSweepSegmented(Rhino.Geometry.Curve rail,System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> shapes,Rhino.Geometry.Point3d startPoint,Rhino.Geometry.Point3d endPoint,Rhino.Geometry.SweepFrame frameType,Rhino.Geometry.Vector3d roadlikeNormal,System.Boolean closed,Rhino.Geometry.SweepBlend blendType,Rhino.Geometry.SweepMiter miterType,System.Double tolerance,Rhino.Geometry.SweepRebuild rebuildType,System.Int32 rebuildPointCount,System.Double refitTolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFromSweep(Rhino.Geometry.Curve rail1,Rhino.Geometry.Curve rail2,Rhino.Geometry.Curve shape,System.Boolean closed,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFromSweep(Rhino.Geometry.Curve rail1,Rhino.Geometry.Curve rail2,System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> shapes,System.Boolean closed,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFromSweep(Rhino.Geometry.Curve rail1,Rhino.Geometry.Curve rail2,System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> shapes,Rhino.Geometry.Point3d start,Rhino.Geometry.Point3d end,System.Boolean closed,System.Double tolerance,Rhino.Geometry.SweepRebuild rebuild,System.Int32 rebuildPointCount,System.Double refitTolerance,System.Boolean preserveHeight) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFromSweepInParts(Rhino.Geometry.Curve rail1,Rhino.Geometry.Curve rail2,System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> shapes,System.Collections.Generic.IEnumerable<Rhino.Geometry.Point2d> rail_params,System.Boolean closed,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFromTaperedExtrude(Rhino.Geometry.Curve curveToExtrude,System.Double distance,Rhino.Geometry.Vector3d direction,Rhino.Geometry.Point3d basePoint,System.Double draftAngleRadians,Rhino.Geometry.ExtrudeCornerType cornerType,System.Double tolerance,System.Double angleToleranceRadians) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFromTaperedExtrude(Rhino.Geometry.Curve curveToExtrude,System.Double distance,Rhino.Geometry.Vector3d direction,Rhino.Geometry.Point3d basePoint,System.Double draftAngleRadians,Rhino.Geometry.ExtrudeCornerType cornerType) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFromTaperedExtrudeWithRef(Rhino.Geometry.Curve curve,Rhino.Geometry.Vector3d direction,System.Double distance,System.Double draftAngle,Rhino.Geometry.Plane plane,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateBlendSurface(Rhino.Geometry.BrepFace face0,Rhino.Geometry.BrepEdge edge0,Rhino.Geometry.Interval domain0,System.Boolean rev0,Rhino.Geometry.BlendContinuity continuity0,Rhino.Geometry.BrepFace face1,Rhino.Geometry.BrepEdge edge1,Rhino.Geometry.Interval domain1,System.Boolean rev1,Rhino.Geometry.BlendContinuity continuity1) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve CreateBlendShape(Rhino.Geometry.BrepFace face0,Rhino.Geometry.BrepEdge edge0,System.Double t0,System.Boolean rev0,Rhino.Geometry.BlendContinuity continuity0,Rhino.Geometry.BrepFace face1,Rhino.Geometry.BrepEdge edge1,System.Double t1,System.Boolean rev1,Rhino.Geometry.BlendContinuity continuity1) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFilletSurface(Rhino.Geometry.BrepFace face0,Rhino.Geometry.Point2d uv0,Rhino.Geometry.BrepFace face1,Rhino.Geometry.Point2d uv1,System.Double radius,System.Boolean extend,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFilletSurface(Rhino.Geometry.BrepFace face0,Rhino.Geometry.Point2d uv0,Rhino.Geometry.BrepFace face1,Rhino.Geometry.Point2d uv1,System.Double radius,System.Boolean trim,System.Boolean extend,System.Double tolerance,out Rhino.Geometry.Brep[] outBreps0,out Rhino.Geometry.Brep[] outBreps1) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateChamferSurface(Rhino.Geometry.BrepFace face0,Rhino.Geometry.Point2d uv0,System.Double radius0,Rhino.Geometry.BrepFace face1,Rhino.Geometry.Point2d uv1,System.Double radius1,System.Boolean extend,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateChamferSurface(Rhino.Geometry.BrepFace face0,Rhino.Geometry.Point2d uv0,System.Double radius0,Rhino.Geometry.BrepFace face1,Rhino.Geometry.Point2d uv1,System.Double radius1,System.Boolean trim,System.Boolean extend,System.Double tolerance,out Rhino.Geometry.Brep[] outBreps0,out Rhino.Geometry.Brep[] outBreps1) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFilletEdges(Rhino.Geometry.Brep brep,System.Collections.Generic.IEnumerable<System.Int32> edgeIndices,System.Collections.Generic.IEnumerable<System.Double> startRadii,System.Collections.Generic.IEnumerable<System.Double> endRadii,Rhino.Geometry.BlendType blendType,Rhino.Geometry.RailType railType,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateOffsetBrep(Rhino.Geometry.Brep brep,System.Double distance,System.Boolean solid,System.Boolean extend,System.Double tolerance,out Rhino.Geometry.Brep[] outBlends,out Rhino.Geometry.Brep[] outWalls) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateOffsetBrep(Rhino.Geometry.Brep brep,System.Double distance,System.Boolean solid,System.Boolean extend,System.Boolean shrink,System.Double tolerance,out Rhino.Geometry.Brep[] outBlends,out Rhino.Geometry.Brep[] outWalls) => throw new System.NotImplementedException();
	public virtual System.Boolean RemoveFins() => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep CreateFromJoinedEdges(Rhino.Geometry.Brep brep0,System.Int32 edgeIndex0,Rhino.Geometry.Brep brep1,System.Int32 edgeIndex1,System.Double joinTolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFromLoft(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves,Rhino.Geometry.Point3d start,Rhino.Geometry.Point3d end,Rhino.Geometry.LoftType loftType,System.Boolean closed) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFromLoftRebuild(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves,Rhino.Geometry.Point3d start,Rhino.Geometry.Point3d end,Rhino.Geometry.LoftType loftType,System.Boolean closed,System.Int32 rebuildPointCount) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFromLoftRefit(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves,Rhino.Geometry.Point3d start,Rhino.Geometry.Point3d end,Rhino.Geometry.LoftType loftType,System.Boolean closed,System.Double refitTolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateFromLoft(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves,Rhino.Geometry.Point3d start,Rhino.Geometry.Point3d end,System.Boolean StartTangent,System.Boolean EndTangent,Rhino.Geometry.BrepTrim StartTrim,Rhino.Geometry.BrepTrim EndTrim,Rhino.Geometry.LoftType loftType,System.Boolean closed) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreatePlanarUnion(System.Collections.Generic.IEnumerable<Rhino.Geometry.Brep> breps,Rhino.Geometry.Plane plane,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreatePlanarUnion(Rhino.Geometry.Brep b0,Rhino.Geometry.Brep b1,Rhino.Geometry.Plane plane,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreatePlanarDifference(Rhino.Geometry.Brep b0,Rhino.Geometry.Brep b1,Rhino.Geometry.Plane plane,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreatePlanarIntersection(Rhino.Geometry.Brep b0,Rhino.Geometry.Brep b1,Rhino.Geometry.Plane plane,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateBooleanUnion(System.Collections.Generic.IEnumerable<Rhino.Geometry.Brep> breps,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateBooleanUnion(System.Collections.Generic.IEnumerable<Rhino.Geometry.Brep> breps,System.Double tolerance,System.Boolean manifoldOnly) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateBooleanIntersection(System.Collections.Generic.IEnumerable<Rhino.Geometry.Brep> firstSet,System.Collections.Generic.IEnumerable<Rhino.Geometry.Brep> secondSet,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateBooleanIntersection(System.Collections.Generic.IEnumerable<Rhino.Geometry.Brep> firstSet,System.Collections.Generic.IEnumerable<Rhino.Geometry.Brep> secondSet,System.Double tolerance,System.Boolean manifoldOnly) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateBooleanIntersection(Rhino.Geometry.Brep firstBrep,Rhino.Geometry.Brep secondBrep,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateBooleanIntersection(Rhino.Geometry.Brep firstBrep,Rhino.Geometry.Brep secondBrep,System.Double tolerance,System.Boolean manifoldOnly) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateBooleanDifference(System.Collections.Generic.IEnumerable<Rhino.Geometry.Brep> firstSet,System.Collections.Generic.IEnumerable<Rhino.Geometry.Brep> secondSet,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateBooleanDifference(System.Collections.Generic.IEnumerable<Rhino.Geometry.Brep> firstSet,System.Collections.Generic.IEnumerable<Rhino.Geometry.Brep> secondSet,System.Double tolerance,System.Boolean manifoldOnly) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateBooleanDifference(Rhino.Geometry.Brep firstBrep,Rhino.Geometry.Brep secondBrep,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateBooleanDifference(Rhino.Geometry.Brep firstBrep,Rhino.Geometry.Brep secondBrep,System.Double tolerance,System.Boolean manifoldOnly) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateBooleanSplit(Rhino.Geometry.Brep firstBrep,Rhino.Geometry.Brep secondBrep,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateBooleanSplit(System.Collections.Generic.IEnumerable<Rhino.Geometry.Brep> firstSet,System.Collections.Generic.IEnumerable<Rhino.Geometry.Brep> secondSet,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] CreateShell(Rhino.Geometry.Brep brep,System.Collections.Generic.IEnumerable<System.Int32> facesToRemove,System.Double distance,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] JoinBreps(System.Collections.Generic.IEnumerable<Rhino.Geometry.Brep> brepsToJoin,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep MergeBreps(System.Collections.Generic.IEnumerable<Rhino.Geometry.Brep> brepsToMerge,System.Double tolerance) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateContourCurves(Rhino.Geometry.Brep brepToContour,Rhino.Geometry.Point3d contourStart,Rhino.Geometry.Point3d contourEnd,System.Double interval) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Curve[] CreateContourCurves(Rhino.Geometry.Brep brepToContour,Rhino.Geometry.Plane sectionPlane) => throw new System.NotImplementedException();
	public virtual void DestroyRegionTopology() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BrepRegion[] GetRegions() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep DuplicateBrep() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep DuplicateSubBrep(System.Collections.Generic.IEnumerable<System.Int32> faceIndices) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] DuplicateEdgeCurves() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] DuplicateEdgeCurves(System.Boolean nakedOnly) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] DuplicateNakedEdgeCurves(System.Boolean outer,System.Boolean inner) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve[] GetWireframe(System.Int32 density) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d[] DuplicateVertices() => throw new System.NotImplementedException();
	public virtual void Flip() => throw new System.NotImplementedException();
	public virtual System.Boolean IsDuplicate(Rhino.Geometry.Brep other,System.Double tolerance) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidTopology(out System.String log) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidGeometry(out System.String log) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidTolerancesAndFlags(out System.String log) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d ClosestPoint(Rhino.Geometry.Point3d testPoint) => throw new System.NotImplementedException();
	public virtual System.Boolean ClosestPoint(Rhino.Geometry.Point3d testPoint,out Rhino.Geometry.Point3d closestPoint,out Rhino.Geometry.ComponentIndex ci,out System.Double s,out System.Double t,System.Double maximumDistance,out Rhino.Geometry.Vector3d normal) => throw new System.NotImplementedException();
	public virtual void FindCoincidentBrepComponents(Rhino.Geometry.Point3d point,System.Double tolerance,out System.Int32[] faces,out System.Int32[] edges,out System.Int32[] vertices) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Collections.BrepVertexList Vertices
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Collections.BrepSurfaceList Surfaces
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Collections.BrepEdgeList Edges
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Collections.BrepTrimList Trims
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Collections.BrepLoopList Loops
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Collections.BrepFaceList Faces
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Collections.BrepCurveList Curves2D
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Collections.BrepCurveList Curves3D
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsSolid
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.BrepSolidOrientation SolidOrientation
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsManifold
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsSurface
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean HasRegionTopology
	{
		get => throw new System.NotImplementedException();
	}
}
