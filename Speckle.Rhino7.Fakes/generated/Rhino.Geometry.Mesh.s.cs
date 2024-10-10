namespace Rhino.Geometry;

public partial class Mesh : Rhino.Geometry.GeometryBase
{
  public Mesh() { }

  public virtual Rhino.Geometry.Mesh Offset(
    System.Double distance,
    System.Boolean solidify,
    Rhino.Geometry.Vector3d direction,
    out System.Collections.Generic.List<System.Int32> wallFacesOut
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 CollapseFacesByEdgeLength(System.Boolean bGreaterThan, System.Double edgeLength) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 CollapseFacesByArea(System.Double lessThanArea, System.Double greaterThanArea) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 CollapseFacesByByAspectRatio(System.Double aspectRatio) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.MeshUnsafeLock GetUnsafeLock(System.Boolean writable) =>
    throw new System.NotImplementedException();

  public virtual void ReleaseUnsafeLock(Rhino.Geometry.MeshUnsafeLock meshData) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh WithShutLining(
    System.Boolean faceted,
    System.Double tolerance,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.ShutLiningCurveInfo> curves
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh WithDisplacement(Rhino.Geometry.MeshDisplacementInfo displacement) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh WithEdgeSoftening(
    System.Double softeningRadius,
    System.Boolean chamfer,
    System.Boolean faceted,
    System.Boolean force,
    System.Double angleThreshold
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean[] GetNakedEdgePointStatus() => throw new System.NotImplementedException();

  public virtual System.Boolean CreatePartitions(System.Int32 maximumVertexCount, System.Int32 maximumTriangleCount) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.MeshPart GetPartition(System.Int32 which) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerable<Rhino.Geometry.MeshNgon> GetNgonAndFacesEnumerable() =>
    throw new System.NotImplementedException();

  public virtual System.Int32 GetNgonAndFacesCount() => throw new System.NotImplementedException();

  public virtual System.Boolean CreateVertexColorsFromBitmap(
    Rhino.RhinoDoc doc,
    Rhino.Render.TextureMapping mapping,
    Rhino.Geometry.Transform xform,
    System.Drawing.Bitmap bitmap
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh QuadRemeshBrep(
    Rhino.Geometry.Brep brep,
    Rhino.Geometry.QuadRemeshParameters parameters
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh QuadRemeshBrep(
    Rhino.Geometry.Brep brep,
    Rhino.Geometry.QuadRemeshParameters parameters,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> guideCurves
  ) => throw new System.NotImplementedException();

  public static System.Threading.Tasks.Task<Rhino.Geometry.Mesh> QuadRemeshBrepAsync(
    Rhino.Geometry.Brep brep,
    Rhino.Geometry.QuadRemeshParameters parameters,
    System.IProgress<System.Int32> progress,
    System.Threading.CancellationToken cancelToken
  ) => throw new System.NotImplementedException();

  public static System.Threading.Tasks.Task<Rhino.Geometry.Mesh> QuadRemeshBrepAsync(
    Rhino.Geometry.Brep brep,
    Rhino.Geometry.QuadRemeshParameters parameters,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> guideCurves,
    System.IProgress<System.Int32> progress,
    System.Threading.CancellationToken cancelToken
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh QuadRemesh(Rhino.Geometry.QuadRemeshParameters parameters) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh QuadRemesh(
    Rhino.Geometry.QuadRemeshParameters parameters,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> guideCurves
  ) => throw new System.NotImplementedException();

  public virtual System.Threading.Tasks.Task<Rhino.Geometry.Mesh> QuadRemeshAsync(
    Rhino.Geometry.QuadRemeshParameters parameters,
    System.IProgress<System.Int32> progress,
    System.Threading.CancellationToken cancelToken
  ) => throw new System.NotImplementedException();

  public virtual System.Threading.Tasks.Task<Rhino.Geometry.Mesh> QuadRemeshAsync(
    Rhino.Geometry.QuadRemeshParameters parameters,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> guideCurves,
    System.IProgress<System.Int32> progress,
    System.Threading.CancellationToken cancelToken
  ) => throw new System.NotImplementedException();

  public virtual System.Threading.Tasks.Task<Rhino.Geometry.Mesh> QuadRemeshAsync(
    System.Collections.Generic.IEnumerable<System.Int32> faceBlocks,
    Rhino.Geometry.QuadRemeshParameters parameters,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> guideCurves,
    System.IProgress<System.Int32> progress,
    System.Threading.CancellationToken cancelToken
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Reduce(
    System.Int32 desiredPolygonCount,
    System.Boolean allowDistortion,
    System.Int32 accuracy,
    System.Boolean normalizeSize
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Reduce(
    System.Int32 desiredPolygonCount,
    System.Boolean allowDistortion,
    System.Int32 accuracy,
    System.Boolean normalizeSize,
    System.Boolean threaded
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Reduce(
    System.Int32 desiredPolygonCount,
    System.Boolean allowDistortion,
    System.Int32 accuracy,
    System.Boolean normalizeSize,
    System.Threading.CancellationToken cancelToken,
    System.IProgress<System.Double> progress,
    out System.String problemDescription
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Reduce(
    System.Int32 desiredPolygonCount,
    System.Boolean allowDistortion,
    System.Int32 accuracy,
    System.Boolean normalizeSize,
    System.Threading.CancellationToken cancelToken,
    System.IProgress<System.Double> progress,
    out System.String problemDescription,
    System.Boolean threaded
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Reduce(Rhino.Geometry.ReduceMeshParameters parameters) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Reduce(Rhino.Geometry.ReduceMeshParameters parameters, System.Boolean threaded) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.MeshThicknessMeasurement[] ComputeThickness(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> meshes,
    System.Double maximumThickness
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.MeshThicknessMeasurement[] ComputeThickness(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> meshes,
    System.Double maximumThickness,
    System.Threading.CancellationToken cancelToken
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.MeshThicknessMeasurement[] ComputeThickness(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> meshes,
    System.Double maximumThickness,
    System.Double sharpAngle,
    System.Threading.CancellationToken cancelToken
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Curve[] CreateContourCurves(
    Rhino.Geometry.Mesh meshToContour,
    Rhino.Geometry.Point3d contourStart,
    Rhino.Geometry.Point3d contourEnd,
    System.Double interval
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Curve[] CreateContourCurves(
    Rhino.Geometry.Mesh meshToContour,
    Rhino.Geometry.Point3d contourStart,
    Rhino.Geometry.Point3d contourEnd,
    System.Double interval,
    System.Double tolerance
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Curve[] CreateContourCurves(
    Rhino.Geometry.Mesh meshToContour,
    Rhino.Geometry.Plane sectionPlane
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Curve[] CreateContourCurves(
    Rhino.Geometry.Mesh meshToContour,
    Rhino.Geometry.Plane sectionPlane,
    System.Double tolerance
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean GetSelfIntersections(
    System.Double tolerance,
    out Rhino.Geometry.Polyline[] perforations,
    System.Boolean overlapsPolylines,
    out Rhino.Geometry.Polyline[] overlapsPolylinesResult,
    System.Boolean overlapsMesh,
    out Rhino.Geometry.Mesh overlapsMeshResult,
    Rhino.FileIO.TextLog textLog,
    System.Threading.CancellationToken cancel,
    System.IProgress<System.Double> progress
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromLines(
    Rhino.Geometry.Curve[] lines,
    System.Int32 maxFaceValence,
    System.Double tolerance
  ) => throw new System.NotImplementedException();

  public virtual System.Byte[] ComputeAutoCreaseInformation() => throw new System.NotImplementedException();

  public virtual System.Int32[] ExtendSelectionByEdgeRidge(
    System.Int32[] preselectedEdges,
    System.Int32 newEdge,
    System.Boolean iterative
  ) => throw new System.NotImplementedException();

  public virtual System.Int32[] ExtendSelectionByFaceLoop(
    System.Int32[] preselectedFaces,
    System.Int32 newFace,
    System.Boolean iterative
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromPlane(
    Rhino.Geometry.Plane plane,
    Rhino.Geometry.Interval xInterval,
    Rhino.Geometry.Interval yInterval,
    System.Int32 xCount,
    System.Int32 yCount
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromFilteredFaceList(
    Rhino.Geometry.Mesh original,
    System.Collections.Generic.IEnumerable<System.Boolean> inclusion
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromBox(
    Rhino.Geometry.BoundingBox box,
    System.Int32 xCount,
    System.Int32 yCount,
    System.Int32 zCount
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromBox(
    Rhino.Geometry.Box box,
    System.Int32 xCount,
    System.Int32 yCount,
    System.Int32 zCount
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromBox(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> corners,
    System.Int32 xCount,
    System.Int32 yCount,
    System.Int32 zCount
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromSphere(
    Rhino.Geometry.Sphere sphere,
    System.Int32 xCount,
    System.Int32 yCount
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateIcoSphere(Rhino.Geometry.Sphere sphere, System.Int32 subdivisions) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateQuadSphere(Rhino.Geometry.Sphere sphere, System.Int32 subdivisions) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromCylinder(
    Rhino.Geometry.Cylinder cylinder,
    System.Int32 vertical,
    System.Int32 around
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromCylinder(
    Rhino.Geometry.Cylinder cylinder,
    System.Int32 vertical,
    System.Int32 around,
    System.Boolean capBottom,
    System.Boolean capTop
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromCylinder(
    Rhino.Geometry.Cylinder cylinder,
    System.Int32 vertical,
    System.Int32 around,
    System.Boolean capBottom,
    System.Boolean capTop,
    System.Boolean quadCaps
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromCylinder(
    Rhino.Geometry.Cylinder cylinder,
    System.Int32 vertical,
    System.Int32 around,
    System.Boolean capBottom,
    System.Boolean capTop,
    System.Boolean circumscribe,
    System.Boolean quadCaps
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromCone(
    Rhino.Geometry.Cone cone,
    System.Int32 vertical,
    System.Int32 around
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromCone(
    Rhino.Geometry.Cone cone,
    System.Int32 vertical,
    System.Int32 around,
    System.Boolean solid
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromCone(
    Rhino.Geometry.Cone cone,
    System.Int32 vertical,
    System.Int32 around,
    System.Boolean solid,
    System.Boolean quadCaps
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromTorus(
    Rhino.Geometry.Torus torus,
    System.Int32 vertical,
    System.Int32 around
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromPlanarBoundary(
    Rhino.Geometry.Curve boundary,
    Rhino.Geometry.MeshingParameters parameters
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromPlanarBoundary(
    Rhino.Geometry.Curve boundary,
    Rhino.Geometry.MeshingParameters parameters,
    System.Double tolerance
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromClosedPolyline(Rhino.Geometry.Polyline polyline) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromTessellation(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,
    System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d>> edges,
    Rhino.Geometry.Plane plane,
    System.Boolean allowNewVertices
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh[] CreateFromBrep(Rhino.Geometry.Brep brep) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh[] CreateFromBrep(
    Rhino.Geometry.Brep brep,
    Rhino.Geometry.MeshingParameters meshingParameters
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromSurface(Rhino.Geometry.Surface surface) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromSurface(
    Rhino.Geometry.Surface surface,
    Rhino.Geometry.MeshingParameters meshingParameters
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromSubD(Rhino.Geometry.SubD subd, System.Int32 displayDensity) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromSubDControlNet(Rhino.Geometry.SubD subd) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreatePatch(
    Rhino.Geometry.Polyline outerBoundary,
    System.Double angleToleranceRadians,
    Rhino.Geometry.Surface pullbackSurface,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> innerBoundaryCurves,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> innerBothSideCurves,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> innerPoints,
    System.Boolean trimback,
    System.Int32 divisions
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh[] CreateBooleanUnion(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> meshes
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh[] CreateBooleanDifference(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> firstSet,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> secondSet
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh[] CreateBooleanIntersection(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> firstSet,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> secondSet
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh[] CreateBooleanSplit(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> meshesToSplit,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> meshSplitters
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromCurvePipe(
    Rhino.Geometry.Curve curve,
    System.Double radius,
    System.Int32 segments,
    System.Int32 accuracy,
    Rhino.Geometry.MeshPipeCapStyle capType,
    System.Boolean faceted,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Interval> intervals
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh CreateFromCurveExtrusion(
    Rhino.Geometry.Curve curve,
    Rhino.Geometry.Vector3d direction,
    Rhino.Geometry.MeshingParameters parameters,
    Rhino.Geometry.BoundingBox boundingBox
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Mesh[] CreateFromIterativeCleanup(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> meshes,
    System.Double tolerance
  ) => throw new System.NotImplementedException();

  public static System.Boolean RequireIterativeCleanup(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> meshes,
    System.Double tolerance
  ) => throw new System.NotImplementedException();

  public virtual void CopyFrom(Rhino.Geometry.Mesh other) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh DuplicateMesh() => throw new System.NotImplementedException();

  public virtual System.Boolean IsManifold() => throw new System.NotImplementedException();

  public virtual System.Boolean IsManifold(
    System.Boolean topologicalTest,
    out System.Boolean isOriented,
    out System.Boolean hasBoundary
  ) => throw new System.NotImplementedException();

  public virtual void ClearTextureData() => throw new System.NotImplementedException();

  public virtual void ClearSurfaceData() => throw new System.NotImplementedException();

  public virtual void DestroyTopology() => throw new System.NotImplementedException();

  public virtual void DestroyTree() => throw new System.NotImplementedException();

  public virtual void DestroyPartition() => throw new System.NotImplementedException();

  public virtual System.Boolean EvaluateMeshGeometry(Rhino.Geometry.Surface surface) =>
    throw new System.NotImplementedException();

  public virtual void SetTextureCoordinates(
    Rhino.Render.TextureMapping tm,
    Rhino.Geometry.Transform xf,
    System.Boolean lazy
  ) => throw new System.NotImplementedException();

  public virtual void SetTextureCoordinates(
    Rhino.Render.TextureMapping tm,
    Rhino.Geometry.Transform xf,
    System.Boolean lazy,
    System.Boolean seamCheck
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Render.CachedTextureCoordinates GetCachedTextureCoordinates(System.Guid textureMappingId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Compact() => throw new System.NotImplementedException();

  public virtual System.Double Volume() => throw new System.NotImplementedException();

  public virtual void Flip(System.Boolean vertexNormals, System.Boolean faceNormals, System.Boolean faceOrientation) =>
    throw new System.NotImplementedException();

  public virtual void Flip(
    System.Boolean vertexNormals,
    System.Boolean faceNormals,
    System.Boolean faceOrientation,
    System.Boolean ngonsBoundaryDirection
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 SolidOrientation() => throw new System.NotImplementedException();

  public virtual System.Boolean IsPointInside(
    Rhino.Geometry.Point3d point,
    System.Double tolerance,
    System.Boolean strictlyIn
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Smooth(
    System.Double smoothFactor,
    System.Boolean bXSmooth,
    System.Boolean bYSmooth,
    System.Boolean bZSmooth,
    System.Boolean bFixBoundaries,
    Rhino.Geometry.SmoothingCoordinateSystem coordinateSystem
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Smooth(
    System.Double smoothFactor,
    System.Boolean bXSmooth,
    System.Boolean bYSmooth,
    System.Boolean bZSmooth,
    System.Boolean bFixBoundaries,
    Rhino.Geometry.SmoothingCoordinateSystem coordinateSystem,
    Rhino.Geometry.Plane plane
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Smooth(
    System.Collections.Generic.IEnumerable<System.Int32> vertexIndices,
    System.Double smoothFactor,
    System.Boolean bXSmooth,
    System.Boolean bYSmooth,
    System.Boolean bZSmooth,
    System.Boolean bFixBoundaries,
    Rhino.Geometry.SmoothingCoordinateSystem coordinateSystem,
    Rhino.Geometry.Plane plane
  ) => throw new System.NotImplementedException();

  public virtual void Unweld(System.Double angleToleranceRadians, System.Boolean modifyNormals) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean UnweldEdge(
    System.Collections.Generic.IEnumerable<System.Int32> edgeIndices,
    System.Boolean modifyNormals
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean UnweldVertices(
    System.Collections.Generic.IEnumerable<System.Int32> topologyVertexIndices,
    System.Boolean modifyNormals
  ) => throw new System.NotImplementedException();

  public virtual void Weld(System.Double angleToleranceRadians) => throw new System.NotImplementedException();

  public virtual void RebuildNormals() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh ExtractNonManifoldEdges(System.Boolean selective) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean HealNakedEdges(System.Double distance) => throw new System.NotImplementedException();

  public virtual System.Boolean FillHoles() => throw new System.NotImplementedException();

  public virtual System.Boolean FileHole(System.Int32 topologyEdgeIndex) => throw new System.NotImplementedException();

  public virtual System.Boolean MatchEdges(System.Double distance, System.Boolean rachet) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 UnifyNormals() => throw new System.NotImplementedException();

  public virtual System.Int32 UnifyNormals(System.Boolean countOnly) => throw new System.NotImplementedException();

  public virtual System.Boolean MergeAllCoplanarFaces(System.Double tolerance) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean MergeAllCoplanarFaces(System.Double tolerance, System.Double angleTolerance) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh[] SplitDisjointPieces() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh[] Split(Rhino.Geometry.Plane plane) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh[] Split(Rhino.Geometry.Mesh mesh) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh[] Split(System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> meshes) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh[] Split(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> meshes,
    System.Double tolerance,
    System.Boolean splitAtCoplanar,
    Rhino.FileIO.TextLog textLog,
    System.Threading.CancellationToken cancel,
    System.IProgress<System.Double> progress
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh[] Split(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> meshes,
    System.Double tolerance,
    System.Boolean splitAtCoplanar,
    System.Boolean createNgons,
    Rhino.FileIO.TextLog textLog,
    System.Threading.CancellationToken cancel,
    System.IProgress<System.Double> progress
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Polyline[] GetOutlines(Rhino.Geometry.Plane plane) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Polyline[] GetOutlines(Rhino.Display.RhinoViewport viewport) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Polyline[] GetOutlines(
    Rhino.DocObjects.ViewportInfo viewportInfo,
    Rhino.Geometry.Plane plane
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Polyline[] GetNakedEdges() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh[] ExplodeAtUnweldedEdges() => throw new System.NotImplementedException();

  public virtual void Append(Rhino.Geometry.Mesh other) => throw new System.NotImplementedException();

  public virtual void Append(System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> meshes) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d ClosestPoint(Rhino.Geometry.Point3d testPoint) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.MeshPoint ClosestMeshPoint(
    Rhino.Geometry.Point3d testPoint,
    System.Double maximumDistance
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 ClosestPoint(
    Rhino.Geometry.Point3d testPoint,
    out Rhino.Geometry.Point3d pointOnMesh,
    System.Double maximumDistance
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 ClosestPoint(
    Rhino.Geometry.Point3d testPoint,
    out Rhino.Geometry.Point3d pointOnMesh,
    out Rhino.Geometry.Vector3d normalAtPoint,
    System.Double maximumDistance
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d PointAt(Rhino.Geometry.MeshPoint meshPoint) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d PointAt(
    System.Int32 faceIndex,
    System.Double t0,
    System.Double t1,
    System.Double t2,
    System.Double t3
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Vector3d NormalAt(Rhino.Geometry.MeshPoint meshPoint) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Vector3d NormalAt(
    System.Int32 faceIndex,
    System.Double t0,
    System.Double t1,
    System.Double t2,
    System.Double t3
  ) => throw new System.NotImplementedException();

  public virtual System.Drawing.Color ColorAt(Rhino.Geometry.MeshPoint meshPoint) =>
    throw new System.NotImplementedException();

  public virtual System.Drawing.Color ColorAt(
    System.Int32 faceIndex,
    System.Double t0,
    System.Double t1,
    System.Double t2,
    System.Double t3
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d[] PullPointsToMesh(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.PolylineCurve PullCurve(Rhino.Geometry.Curve curve, System.Double tolerance) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh[] SplitWithProjectedPolylines(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.PolylineCurve> curves,
    System.Double tolerance
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh[] SplitWithProjectedPolylines(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.PolylineCurve> curves,
    System.Double tolerance,
    Rhino.FileIO.TextLog textLog,
    System.Threading.CancellationToken cancel,
    System.IProgress<System.Double> progress
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh Offset(System.Double distance) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh Offset(System.Double distance, System.Boolean solidify) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh Offset(
    System.Double distance,
    System.Boolean solidify,
    Rhino.Geometry.Vector3d direction
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 DisjointMeshCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsClosed
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsOriented
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsSolid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean HasCachedTextureCoordinates
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean HasPrincipalCurvatures
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Collections.MeshVertexList Vertices
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Collections.MeshTopologyVertexList TopologyVertices
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Collections.MeshTopologyEdgeList TopologyEdges
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Collections.MeshVertexNormalList Normals
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Collections.MeshFaceList Faces
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Collections.MeshNgonList Ngons
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Collections.MeshFaceNormalList FaceNormals
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Collections.MeshVertexColorList VertexColors
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Collections.MeshTextureCoordinateList TextureCoordinates
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Collections.MeshVertexStatusList ComponentStates
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 PartitionCount
  {
    get => throw new System.NotImplementedException();
  }
}
