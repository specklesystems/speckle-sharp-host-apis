namespace Rhino.Geometry.Collections;

public partial class MeshTopologyVertexList
  : System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3f>,
    System.Collections.IEnumerable,
    System.Collections.Generic.IList<Rhino.Geometry.Point3f>,
    System.Collections.Generic.ICollection<Rhino.Geometry.Point3f>,
    System.Collections.IList,
    System.Collections.ICollection,
    System.Collections.Generic.IReadOnlyList<Rhino.Geometry.Point3f>,
    System.Collections.Generic.IReadOnlyCollection<Rhino.Geometry.Point3f>
{
  public MeshTopologyVertexList() { }

  public virtual System.Int32 TopologyVertexIndex(System.Int32 vertexIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Int32[] MeshVertexIndices(System.Int32 topologyVertexIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Int32[] IndicesFromFace(System.Int32 faceIndex) => throw new System.NotImplementedException();

  public virtual System.Int32[] ConnectedTopologyVertices(System.Int32 topologyVertexIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Int32[] ConnectedTopologyVertices(System.Int32 topologyVertexIndex, System.Boolean sorted) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SortEdges() => throw new System.NotImplementedException();

  public virtual System.Boolean SortEdges(System.Int32 topologyVertexIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsHidden(System.Int32 topologyVertexIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Int32[] ConnectedFaces(System.Int32 topologyVertexIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 ConnectedEdgesCount(System.Int32 topologyVertexIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 ConnectedEdge(System.Int32 topologyVertexIndex, System.Int32 edgeAtVertexIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Int32[] ConnectedEdges(System.Int32 topologyVertexIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.Geometry.Point3f> GetEnumerator() =>
    throw new System.NotImplementedException();

  System.Int32 System.Collections.Generic.IList<Rhino.Geometry.Point3f>.IndexOf(Rhino.Geometry.Point3f item) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.IList<Rhino.Geometry.Point3f>.Insert(
    System.Int32 index,
    Rhino.Geometry.Point3f item
  ) => throw new System.NotImplementedException();

  void System.Collections.Generic.IList<Rhino.Geometry.Point3f>.RemoveAt(System.Int32 index) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<Rhino.Geometry.Point3f>.Add(Rhino.Geometry.Point3f item) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<Rhino.Geometry.Point3f>.Clear() =>
    throw new System.NotImplementedException();

  System.Boolean System.Collections.Generic.ICollection<Rhino.Geometry.Point3f>.Contains(Rhino.Geometry.Point3f item) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<Rhino.Geometry.Point3f>.CopyTo(
    Rhino.Geometry.Point3f[] array,
    System.Int32 arrayIndex
  ) => throw new System.NotImplementedException();

  System.Boolean System.Collections.Generic.ICollection<Rhino.Geometry.Point3f>.Remove(Rhino.Geometry.Point3f item) =>
    throw new System.NotImplementedException();

  System.Int32 System.Collections.IList.Add(System.Object value) => throw new System.NotImplementedException();

  void System.Collections.IList.Clear() => throw new System.NotImplementedException();

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
  }
  public virtual Rhino.Geometry.Point3f this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  System.Boolean System.Collections.Generic.ICollection<Rhino.Geometry.Point3f>.IsReadOnly
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
