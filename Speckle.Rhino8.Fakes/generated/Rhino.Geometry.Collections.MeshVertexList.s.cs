namespace Rhino.Geometry.Collections;

public partial class MeshVertexList
  : Rhino.Collections.IResizableList<Rhino.Geometry.Point3f>,
    System.Collections.Generic.IList<Rhino.Geometry.Point3f>,
    System.Collections.Generic.ICollection<Rhino.Geometry.Point3f>,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3f>,
    System.Collections.IEnumerable,
    System.Collections.Generic.IReadOnlyList<Rhino.Geometry.Point3f>,
    System.Collections.Generic.IReadOnlyCollection<Rhino.Geometry.Point3f>,
    System.Collections.IList,
    System.Collections.ICollection
{
  public MeshVertexList() { }

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual void Destroy() => throw new System.NotImplementedException();

  public virtual System.Int32 Add(System.Single x, System.Single y, System.Single z) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 Add(System.Double x, System.Double y, System.Double z) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 Add(Rhino.Geometry.Point3f vertex) => throw new System.NotImplementedException();

  public virtual System.Int32 Add(Rhino.Geometry.Point3d vertex) => throw new System.NotImplementedException();

  public virtual void AddVertices(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> vertices) =>
    throw new System.NotImplementedException();

  public virtual void AddVertices(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3f> vertices) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetVertex(System.Int32 index, System.Single x, System.Single y, System.Single z) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetVertex(
    System.Int32 index,
    System.Double x,
    System.Double y,
    System.Double z,
    System.Boolean updateNormals
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean SetVertex(System.Int32 index, System.Double x, System.Double y, System.Double z) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetVertex(System.Int32 index, Rhino.Geometry.Point3f vertex) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetVertex(System.Int32 index, Rhino.Geometry.Point3d vertex) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsHidden(System.Int32 vertexIndex) => throw new System.NotImplementedException();

  public virtual void Hide(System.Int32 vertexIndex) => throw new System.NotImplementedException();

  public virtual void Show(System.Int32 vertexIndex) => throw new System.NotImplementedException();

  public virtual void HideAll() => throw new System.NotImplementedException();

  public virtual void ShowAll() => throw new System.NotImplementedException();

  public virtual System.Int32 CullUnused() => throw new System.NotImplementedException();

  public virtual System.Boolean CombineIdentical(System.Boolean ignoreNormals, System.Boolean ignoreAdditional) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 Align(
    System.Double distance,
    System.Collections.Generic.IEnumerable<System.Boolean> whichVertices
  ) => throw new System.NotImplementedException();

  public static System.Int32 Align(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> meshes,
    System.Double distance,
    System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Boolean>> whichVertices
  ) => throw new System.NotImplementedException();

  public virtual System.Int32[] GetVertexFaces(System.Int32 vertexIndex) => throw new System.NotImplementedException();

  public virtual System.Int32[] GetTopologicalIndenticalVertices(System.Int32 vertexIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Int32[] GetConnectedVertices(System.Int32 vertexIndex) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d Point3dAt(System.Int32 index) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3f[] ToPoint3fArray() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d[] ToPoint3dArray() => throw new System.NotImplementedException();

  public virtual System.Single[] ToFloatArray() => throw new System.NotImplementedException();

  public virtual System.Boolean Remove(System.Int32 index, System.Boolean shrinkFaces) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Remove(
    System.Collections.Generic.IEnumerable<System.Int32> indices,
    System.Boolean shrinkFaces
  ) => throw new System.NotImplementedException();

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

  System.Boolean System.Collections.Generic.ICollection<Rhino.Geometry.Point3f>.Contains(Rhino.Geometry.Point3f item) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<Rhino.Geometry.Point3f>.CopyTo(
    Rhino.Geometry.Point3f[] array,
    System.Int32 arrayIndex
  ) => throw new System.NotImplementedException();

  System.Boolean System.Collections.Generic.ICollection<Rhino.Geometry.Point3f>.Remove(Rhino.Geometry.Point3f item) =>
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
  public virtual System.Int32 Capacity
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point3f this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseDoublePrecisionVertices
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
