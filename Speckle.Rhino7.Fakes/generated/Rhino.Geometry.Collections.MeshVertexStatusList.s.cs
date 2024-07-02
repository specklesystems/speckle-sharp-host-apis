namespace Rhino.Geometry.Collections;

public partial class MeshVertexStatusList
  : Rhino.Collections.IResizableList<System.Boolean>,
    System.Collections.Generic.IList<System.Boolean>,
    System.Collections.Generic.ICollection<System.Boolean>,
    System.Collections.Generic.IEnumerable<System.Boolean>,
    System.Collections.IEnumerable,
    System.Collections.IList,
    System.Collections.ICollection,
    System.Collections.Generic.IReadOnlyList<System.Boolean>,
    System.Collections.Generic.IReadOnlyCollection<System.Boolean>
{
  public MeshVertexStatusList() { }

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual void Add(System.Boolean hidden) => throw new System.NotImplementedException();

  public virtual void AddRange(System.Collections.Generic.IEnumerable<System.Boolean> values) =>
    throw new System.NotImplementedException();

  public virtual void Destroy() => throw new System.NotImplementedException();

  public virtual System.Boolean Contains(System.Boolean hidden) => throw new System.NotImplementedException();

  public virtual void CopyTo(System.Boolean[] array, System.Int32 arrayIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<System.Boolean> GetEnumerator() =>
    throw new System.NotImplementedException();

  System.Int32 System.Collections.Generic.IList<System.Boolean>.IndexOf(System.Boolean item) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.IList<System.Boolean>.Insert(System.Int32 index, System.Boolean item) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.IList<System.Boolean>.RemoveAt(System.Int32 index) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<System.Boolean>.Add(System.Boolean item) =>
    throw new System.NotImplementedException();

  System.Boolean System.Collections.Generic.ICollection<System.Boolean>.Remove(System.Boolean item) =>
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
  public virtual System.Int32 HiddenCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Capacity
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  System.Boolean System.Collections.Generic.ICollection<System.Boolean>.IsReadOnly
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
