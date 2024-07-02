namespace Rhino.Geometry.Collections;

public partial class MeshFaceNormalList
  : Rhino.Collections.IResizableList<Rhino.Geometry.Vector3f>,
    System.Collections.Generic.IList<Rhino.Geometry.Vector3f>,
    System.Collections.Generic.ICollection<Rhino.Geometry.Vector3f>,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Vector3f>,
    System.Collections.IEnumerable,
    System.Collections.IList,
    System.Collections.ICollection,
    System.Collections.Generic.IReadOnlyList<Rhino.Geometry.Vector3f>,
    System.Collections.Generic.IReadOnlyCollection<Rhino.Geometry.Vector3f>
{
  public MeshFaceNormalList() { }

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual void Destroy() => throw new System.NotImplementedException();

  public virtual System.Int32 AddFaceNormal(System.Single x, System.Single y, System.Single z) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 AddFaceNormal(System.Double x, System.Double y, System.Double z) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 AddFaceNormal(Rhino.Geometry.Vector3d normal) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 AddFaceNormal(Rhino.Geometry.Vector3f normal) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetFaceNormal(System.Int32 index, System.Single x, System.Single y, System.Single z) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetFaceNormal(System.Int32 index, System.Double x, System.Double y, System.Double z) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetFaceNormal(System.Int32 index, Rhino.Geometry.Vector3d normal) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetFaceNormal(System.Int32 index, Rhino.Geometry.Vector3f normal) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean UnitizeFaceNormals() => throw new System.NotImplementedException();

  public virtual System.Boolean ComputeFaceNormals() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.Geometry.Vector3f> GetEnumerator() =>
    throw new System.NotImplementedException();

  System.Int32 System.Collections.Generic.IList<Rhino.Geometry.Vector3f>.IndexOf(Rhino.Geometry.Vector3f item) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.IList<Rhino.Geometry.Vector3f>.Insert(
    System.Int32 index,
    Rhino.Geometry.Vector3f item
  ) => throw new System.NotImplementedException();

  void System.Collections.Generic.IList<Rhino.Geometry.Vector3f>.RemoveAt(System.Int32 index) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<Rhino.Geometry.Vector3f>.Add(Rhino.Geometry.Vector3f item) =>
    throw new System.NotImplementedException();

  System.Boolean System.Collections.Generic.ICollection<Rhino.Geometry.Vector3f>.Contains(
    Rhino.Geometry.Vector3f item
  ) => throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<Rhino.Geometry.Vector3f>.CopyTo(
    Rhino.Geometry.Vector3f[] array,
    System.Int32 arrayIndex
  ) => throw new System.NotImplementedException();

  System.Boolean System.Collections.Generic.ICollection<Rhino.Geometry.Vector3f>.Remove(Rhino.Geometry.Vector3f item) =>
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
  public virtual Rhino.Geometry.Vector3f this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 Capacity
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  System.Boolean System.Collections.Generic.ICollection<Rhino.Geometry.Vector3f>.IsReadOnly
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
