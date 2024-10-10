namespace Rhino.Geometry;

public partial class SubD : Rhino.Geometry.GeometryBase
{
  public SubD() { }

  public virtual Rhino.Geometry.Curve[] DuplicateEdgeCurves() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Curve[] DuplicateEdgeCurves(
    System.Boolean boundaryOnly,
    System.Boolean interiorOnly,
    System.Boolean smoothOnly,
    System.Boolean sharpOnly,
    System.Boolean creaseOnly,
    System.Boolean clampEnds
  ) => throw new System.NotImplementedException();

  public virtual System.UInt32 TransformComponents(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.ComponentIndex> components,
    Rhino.Geometry.Transform xform,
    Rhino.Geometry.SubDComponentLocation componentLocation
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Flip() => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubD[] JoinSubDs(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.SubD> subdsToJoin,
    System.Double tolerance,
    System.Boolean joinedEdgesAreCreases
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubD[] JoinSubDs(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.SubD> subdsToJoin,
    System.Double tolerance,
    System.Boolean joinedEdgesAreCreases,
    System.Boolean preserveSymmetry
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep ToBrep(Rhino.Geometry.SubDToBrepOptions options) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep ToBrep() => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubD CreateFromMesh(Rhino.Geometry.Mesh mesh) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.SubD CreateFromMesh(
    Rhino.Geometry.Mesh mesh,
    Rhino.Geometry.SubDCreationOptions options
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubD CreateFromSurface(
    Rhino.Geometry.Surface surface,
    Rhino.Geometry.SubDFromSurfaceMethods method,
    System.Boolean corners
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubD CreateQuadSphere(
    Rhino.Geometry.Sphere sphere,
    Rhino.Geometry.SubDComponentLocation vertexLocation,
    System.UInt32 quadSubdivisionLevel
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubD CreateGlobeSphere(
    Rhino.Geometry.Sphere sphere,
    Rhino.Geometry.SubDComponentLocation vertexLocation,
    System.UInt32 axialFaceCount,
    System.UInt32 equatorialFaceCount
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubD CreateTriSphere(
    Rhino.Geometry.Sphere sphere,
    Rhino.Geometry.SubDComponentLocation vertexLocation,
    System.UInt32 triSubdivisionLevel
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubD CreateIcosahedron(
    Rhino.Geometry.Sphere sphere,
    Rhino.Geometry.SubDComponentLocation vertexLocation
  ) => throw new System.NotImplementedException();

  public virtual System.UInt32 PackFaces() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.SubD Offset(System.Double distance, System.Boolean solidify) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.SubD CreateFromLoft(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.NurbsCurve> curves,
    System.Boolean closed,
    System.Boolean addCorners,
    System.Boolean addCreases,
    System.Int32 divisions
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubD CreateFromSweep(
    Rhino.Geometry.NurbsCurve rail1,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.NurbsCurve> shapes,
    System.Boolean closed,
    System.Boolean addCorners,
    System.Boolean roadlikeFrame,
    Rhino.Geometry.Vector3d roadlikeNormal
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubD CreateFromSweep(
    Rhino.Geometry.NurbsCurve rail1,
    Rhino.Geometry.NurbsCurve rail2,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.NurbsCurve> shapes,
    System.Boolean closed,
    System.Boolean addCorners
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean MergeAllCoplanarFaces(System.Double tolerance) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean MergeAllCoplanarFaces(System.Double tolerance, System.Double angleTolerance) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.SubD CreateFromCylinder(
    Rhino.Geometry.Cylinder cylinder,
    System.UInt32 circumferenceFaceCount,
    System.UInt32 heightFaceCount,
    Rhino.Geometry.SubDEndCapStyle endCapStyle,
    Rhino.Geometry.SubDEdgeTag endCapEdgeTag,
    Rhino.Geometry.SubDComponentLocation radiusLocation
  ) => throw new System.NotImplementedException();

  public virtual void ClearEvaluationCache() => throw new System.NotImplementedException();

  public virtual System.UInt32 UpdateSurfaceMeshCache(System.Boolean lazyUpdate) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SurfaceMeshCacheExists(
    System.Boolean bTextureCoordinatesExist,
    System.Boolean bCurvaturesExist,
    System.Boolean bColorsExist
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.SubDComponent ComponentFromComponentIndex(
    Rhino.Geometry.ComponentIndex componentIndex
  ) => throw new System.NotImplementedException();

  public virtual System.UInt32 UpdateAllTagsAndSectorCoefficients() => throw new System.NotImplementedException();

  public virtual System.Boolean Subdivide() => throw new System.NotImplementedException();

  public virtual System.Boolean Subdivide(System.Int32 count) => throw new System.NotImplementedException();

  public virtual System.Boolean Subdivide(System.Collections.Generic.IEnumerable<System.Int32> faceIndices) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean InterpolateSurfacePoints(Rhino.Geometry.Point3d[] surfacePoints) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean InterpolateSurfacePoints(
    System.UInt32[] vertexIndices,
    Rhino.Geometry.Point3d[] surfacePoints
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean SetVertexSurfacePoint(System.UInt32 vertexIndex, Rhino.Geometry.Point3d surfacePoint) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Collections.SubDFaceList Faces
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Collections.SubDVertexList Vertices
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Collections.SubDEdgeList Edges
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsSolid
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.SubD Empty
  {
    get => throw new System.NotImplementedException();
  }
}
