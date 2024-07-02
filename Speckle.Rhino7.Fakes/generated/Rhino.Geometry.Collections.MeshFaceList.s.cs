namespace Rhino.Geometry.Collections;

public partial class MeshFaceList
  : Rhino.Collections.IResizableList<Rhino.Geometry.MeshFace>,
    System.Collections.Generic.IList<Rhino.Geometry.MeshFace>,
    System.Collections.Generic.ICollection<Rhino.Geometry.MeshFace>,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.MeshFace>,
    System.Collections.IEnumerable,
    System.Collections.IList,
    System.Collections.ICollection,
    System.Collections.Generic.IReadOnlyList<Rhino.Geometry.MeshFace>,
    System.Collections.Generic.IReadOnlyCollection<Rhino.Geometry.MeshFace>
{
  public MeshFaceList() { }

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual void Destroy() => throw new System.NotImplementedException();

  public virtual System.Int32 AddFace(Rhino.Geometry.MeshFace face) => throw new System.NotImplementedException();

  public virtual System.Int32 AddFace(System.Int32 vertex1, System.Int32 vertex2, System.Int32 vertex3) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 AddFace(
    System.Int32 vertex1,
    System.Int32 vertex2,
    System.Int32 vertex3,
    System.Int32 vertex4
  ) => throw new System.NotImplementedException();

  public virtual System.Int32[] AddFaces(System.Collections.Generic.IEnumerable<Rhino.Geometry.MeshFace> faces) =>
    throw new System.NotImplementedException();

  public virtual void Insert(System.Int32 index, Rhino.Geometry.MeshFace face) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetFace(System.Int32 index, Rhino.Geometry.MeshFace face) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetFace(
    System.Int32 index,
    System.Int32 vertex1,
    System.Int32 vertex2,
    System.Int32 vertex3
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean SetFace(
    System.Int32 index,
    System.Int32 vertex1,
    System.Int32 vertex2,
    System.Int32 vertex3,
    System.Int32 vertex4
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.MeshFace GetFace(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Boolean MergeAdjacentFaces(System.Int32 edgeIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Double GetFaceAspectRatio(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Boolean GetFaceVertices(
    System.Int32 faceIndex,
    out Rhino.Geometry.Point3f a,
    out Rhino.Geometry.Point3f b,
    out Rhino.Geometry.Point3f c,
    out Rhino.Geometry.Point3f d
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BoundingBox GetFaceBoundingBox(System.Int32 faceIndex) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d GetFaceCenter(System.Int32 faceIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Int32[] AdjacentFaces(System.Int32 faceIndex) => throw new System.NotImplementedException();

  public virtual System.Int32[] ToIntArray(System.Boolean asTriangles) => throw new System.NotImplementedException();

  public virtual System.Int32 DeleteFaces(System.Collections.Generic.IEnumerable<System.Int32> faceIndexes) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 DeleteFaces(
    System.Collections.Generic.IEnumerable<System.Int32> faceIndexes,
    System.Boolean compact
  ) => throw new System.NotImplementedException();

  public virtual void RemoveAt(System.Int32 index) => throw new System.NotImplementedException();

  public virtual void RemoveAt(System.Int32 index, System.Boolean compact) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean ConvertQuadsToTriangles() => throw new System.NotImplementedException();

  public virtual System.Int32 ConvertNonPlanarQuadsToTriangles(
    System.Double planarTolerance,
    System.Double angleToleranceRadians,
    System.Int32 splitMethod
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean ConvertTrianglesToQuads(
    System.Double angleToleranceRadians,
    System.Double minimumDiagonalLengthRatio
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 CullDegenerateFaces() => throw new System.NotImplementedException();

  public virtual System.Boolean IsHidden(System.Int32 faceIndex) => throw new System.NotImplementedException();

  public virtual System.Boolean HasNakedEdges(System.Int32 faceIndex) => throw new System.NotImplementedException();

  public virtual System.Int32[] GetTopologicalVertices(System.Int32 faceIndex) =>
    throw new System.NotImplementedException();

  public virtual Rhino.IndexPair[] GetClashingFacePairs(System.Int32 maxPairCount) =>
    throw new System.NotImplementedException();

  public virtual System.Int32[] GetConnectedFaces(
    System.Int32 faceIndex,
    System.Double angleRadians,
    System.Boolean greaterThanAngle
  ) => throw new System.NotImplementedException();

  public virtual System.Int32[] GetConnectedFaces(System.Int32 faceIndex) => throw new System.NotImplementedException();

  public virtual System.Int32[] GetConnectedFacesToEdges(
    System.Int32 startFaceIndex,
    System.Boolean treatNonmanifoldLikeUnwelded
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean GetZeroAreaFaces(
    out System.Int32[] whollyDegenerateFaces,
    out System.Int32[] partiallyDegenerateFaces
  ) => throw new System.NotImplementedException();

  public virtual System.Int32[] GetDuplicateFaces() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh ExtractDuplicateFaces() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh ExtractFaces(System.Collections.Generic.IEnumerable<System.Int32> faceIndices) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.Geometry.MeshFace> GetEnumerator() =>
    throw new System.NotImplementedException();

  System.Int32 System.Collections.Generic.IList<Rhino.Geometry.MeshFace>.IndexOf(Rhino.Geometry.MeshFace item) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.IList<Rhino.Geometry.MeshFace>.Insert(
    System.Int32 index,
    Rhino.Geometry.MeshFace item
  ) => throw new System.NotImplementedException();

  void System.Collections.Generic.IList<Rhino.Geometry.MeshFace>.RemoveAt(System.Int32 index) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<Rhino.Geometry.MeshFace>.Add(Rhino.Geometry.MeshFace item) =>
    throw new System.NotImplementedException();

  System.Boolean System.Collections.Generic.ICollection<Rhino.Geometry.MeshFace>.Contains(
    Rhino.Geometry.MeshFace item
  ) => throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<Rhino.Geometry.MeshFace>.CopyTo(
    Rhino.Geometry.MeshFace[] array,
    System.Int32 arrayIndex
  ) => throw new System.NotImplementedException();

  System.Boolean System.Collections.Generic.ICollection<Rhino.Geometry.MeshFace>.Remove(Rhino.Geometry.MeshFace item) =>
    throw new System.NotImplementedException();

  System.Int32 System.Collections.IList.Add(System.Object value) => throw new System.NotImplementedException();

  System.Boolean System.Collections.IList.Contains(System.Object value) => throw new System.NotImplementedException();

  System.Int32 System.Collections.IList.IndexOf(System.Object value) => throw new System.NotImplementedException();

  void System.Collections.IList.Insert(System.Int32 index, System.Object value) =>
    throw new System.NotImplementedException();

  void System.Collections.IList.Remove(System.Object value) => throw new System.NotImplementedException();

  void System.Collections.IList.RemoveAt(System.Int32 index) => throw new System.NotImplementedException();

  void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) =>
    throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual System.Int32 Count
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 QuadCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 TriangleCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Capacity
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.MeshFace this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  System.Boolean System.Collections.Generic.ICollection<Rhino.Geometry.MeshFace>.IsReadOnly
  {
    get => throw new System.NotImplementedException();
  }
  System.Boolean System.Collections.IList.IsFixedSize
  {
    get => throw new System.NotImplementedException();
  }
  System.Boolean System.Collections.IList.IsReadOnly
  {
    get => throw new System.NotImplementedException();
  }
  System.Object System.Collections.IList.this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  System.Boolean System.Collections.ICollection.IsSynchronized
  {
    get => throw new System.NotImplementedException();
  }
  System.Object System.Collections.ICollection.SyncRoot
  {
    get => throw new System.NotImplementedException();
  }
}
