namespace Rhino.Geometry;

public partial class MeshCheckParameters
{
  public MeshCheckParameters() { }

  public static Rhino.Geometry.MeshCheckParameters Defaults() => throw new System.NotImplementedException();

  public virtual System.Boolean CheckForDegenerateFaces
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 DegenerateFaceCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean CheckForInvalidNgons
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 InvalidNgonCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean CheckForNakedEdges
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 NakedEdgeCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean CheckForNonManifoldEdges
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 NonManifoldEdgeCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean CheckForExtremelyShortEdges
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 ExtremelyShortEdgeCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean CheckForBadNormals
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 NonUnitVectorNormalCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 ZeroLengthNormalCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 VertexFaceNormalsDifferCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean CheckForDuplicateFaces
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 DuplicateFaceCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean CheckForRandomFaceNormals
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 RandomFaceNormalCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean CheckForDisjointMeshes
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 DisjointMeshCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean CheckForUnusedVertices
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 UnusedVertexCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean CheckForSelfIntersection
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 SelfIntersectingPairsCount
  {
    get => throw new System.NotImplementedException();
  }
}
