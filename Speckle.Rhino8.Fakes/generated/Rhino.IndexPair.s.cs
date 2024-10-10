namespace Rhino;

public partial class IndexPair
  : System.Collections.Generic.IList<System.Int32>,
    System.Collections.Generic.IReadOnlyList<System.Int32>
{
  public IndexPair() { }

  public IndexPair(System.Int32 i, System.Int32 j) => throw new System.NotImplementedException();

  public virtual System.Int32 IndexOf(System.Int32 item) => throw new System.NotImplementedException();

  public virtual System.Boolean Contains(System.Int32 item) => throw new System.NotImplementedException();

  public virtual void CopyTo(System.Int32[] array, System.Int32 arrayIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<System.Int32> GetEnumerator() =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.IList<System.Int32>.Insert(System.Int32 index, System.Int32 item) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.IList<System.Int32>.RemoveAt(System.Int32 index) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<System.Int32>.Add(System.Int32 item) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<System.Int32>.Clear() => throw new System.NotImplementedException();

  System.Boolean System.Collections.Generic.ICollection<System.Int32>.Remove(System.Int32 item) =>
    throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual System.Int32 I
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 J
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 Count
  {
    get => throw new System.NotImplementedException();
  }
  System.Boolean System.Collections.Generic.ICollection<System.Int32>.IsReadOnly
  {
    get => throw new System.NotImplementedException();
  }
}
