namespace Rhino.FileIO;

public partial class CommonComponentTable<T>
  : Rhino.FileIO.ICommonComponentTable<T>,
    System.Collections.Generic.IReadOnlyCollection<T>,
    System.Collections.Generic.IEnumerable<T>,
    System.Collections.IEnumerable,
    System.Collections.Generic.ICollection<T>,
    System.Collections.Generic.IList<T>,
    System.Collections.Generic.IReadOnlyList<T>
{
  public CommonComponentTable() { }

  public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Delete(T item) => throw new System.NotImplementedException();

  public virtual T FindId(System.Guid id) => throw new System.NotImplementedException();

  public virtual void Clear() => throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<T>.Add(T item) => throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();

  System.Boolean System.Collections.Generic.ICollection<T>.Remove(T item) => throw new System.NotImplementedException();

  T Rhino.FileIO.ICommonComponentTable<T>.FindNameHash(Rhino.FileIO.NameHash nameHash) =>
    throw new System.NotImplementedException();

  System.Boolean System.Collections.Generic.ICollection<T>.Contains(T item) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<T>.CopyTo(T[] array, System.Int32 arrayIndex) =>
    throw new System.NotImplementedException();

  System.Int32 System.Collections.Generic.IList<T>.IndexOf(T item) => throw new System.NotImplementedException();

  void System.Collections.Generic.IList<T>.Insert(System.Int32 index, T item) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.IList<T>.RemoveAt(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Int32 Count
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
  T System.Collections.Generic.IList<T>.this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  T System.Collections.Generic.IReadOnlyList<T>.this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
  }
  System.Boolean System.Collections.Generic.ICollection<T>.IsReadOnly
  {
    get => throw new System.NotImplementedException();
  }
}
