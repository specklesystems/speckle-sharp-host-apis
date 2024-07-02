namespace Rhino.Geometry.Collections;

public partial class MeshNgonList
  : Rhino.Collections.IResizableList<Rhino.Geometry.MeshNgon>,
    System.Collections.Generic.IList<Rhino.Geometry.MeshNgon>,
    System.Collections.Generic.ICollection<Rhino.Geometry.MeshNgon>,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.MeshNgon>,
    System.Collections.IEnumerable,
    System.Collections.IList,
    System.Collections.ICollection,
    System.Collections.Generic.IReadOnlyList<Rhino.Geometry.MeshNgon>,
    System.Collections.Generic.IReadOnlyCollection<Rhino.Geometry.MeshNgon>
{
  public MeshNgonList() { }

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual System.Int32 AddNgon(Rhino.Geometry.MeshNgon ngon) => throw new System.NotImplementedException();

  public virtual System.Int32[] AddNgons(System.Collections.Generic.IEnumerable<Rhino.Geometry.MeshNgon> ngons) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 AddPlanarNgons(System.Double planarTolerance) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 AddPlanarNgons(
    System.Double planarTolerance,
    System.Int32 minimumNgonVertexCount,
    System.Int32 minimumNgonFaceCount,
    System.Boolean allowHoles
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d[] NgonBoundaryVertexList(
    Rhino.Geometry.MeshNgon ngon,
    System.Boolean bAppendStartPoint
  ) => throw new System.NotImplementedException();

  public virtual void Insert(System.Int32 index, Rhino.Geometry.MeshNgon ngon) =>
    throw new System.NotImplementedException();

  public virtual void SetNgon(System.Int32 index, Rhino.Geometry.MeshNgon ngon) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.MeshNgon GetNgon(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Int32 NgonIndexFromFaceIndex(System.Int32 meshFaceIndex) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BoundingBox GetNgonBoundingBox(System.Int32 index) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BoundingBox GetNgonBoundingBox(Rhino.Geometry.MeshNgon ngon) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 GetNgonOuterEdgeCount(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Int32 Orientation(System.Int32 index, System.Boolean permitHoles) =>
    throw new System.NotImplementedException();

  public virtual void ReverseOuterBoundary(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Int32 GetNgonEdgeCount(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Boolean NgonHasHoles(System.Int32 index) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d GetNgonCenter(System.Int32 index) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d GetNgonCenter(Rhino.Geometry.MeshNgon ngon) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 RemoveNgons(System.Collections.Generic.IEnumerable<System.Int32> indices) =>
    throw new System.NotImplementedException();

  public virtual void RemoveAt(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Int32[] GetNgonBoundary(
    System.Collections.Generic.IEnumerable<System.Int32> ngonFaceIndexList
  ) => throw new System.NotImplementedException();

  public virtual System.UInt32 IsValid(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.Geometry.MeshNgon> GetEnumerator() =>
    throw new System.NotImplementedException();

  System.Int32 System.Collections.Generic.IList<Rhino.Geometry.MeshNgon>.IndexOf(Rhino.Geometry.MeshNgon item) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.IList<Rhino.Geometry.MeshNgon>.Insert(
    System.Int32 index,
    Rhino.Geometry.MeshNgon item
  ) => throw new System.NotImplementedException();

  void System.Collections.Generic.IList<Rhino.Geometry.MeshNgon>.RemoveAt(System.Int32 index) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<Rhino.Geometry.MeshNgon>.Add(Rhino.Geometry.MeshNgon item) =>
    throw new System.NotImplementedException();

  System.Boolean System.Collections.Generic.ICollection<Rhino.Geometry.MeshNgon>.Contains(
    Rhino.Geometry.MeshNgon item
  ) => throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<Rhino.Geometry.MeshNgon>.CopyTo(
    Rhino.Geometry.MeshNgon[] array,
    System.Int32 arrayIndex
  ) => throw new System.NotImplementedException();

  System.Boolean System.Collections.Generic.ICollection<Rhino.Geometry.MeshNgon>.Remove(Rhino.Geometry.MeshNgon item) =>
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
  public virtual System.UInt32 UnsignedCount
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.MeshNgon this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  System.Boolean System.Collections.Generic.ICollection<Rhino.Geometry.MeshNgon>.IsReadOnly
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
