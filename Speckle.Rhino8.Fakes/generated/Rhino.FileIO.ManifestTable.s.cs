namespace Rhino.FileIO;

public partial class ManifestTable
  : Rhino.FileIO.ICommonComponentTable<Rhino.DocObjects.ModelComponent>,
    System.Collections.Generic.IReadOnlyCollection<Rhino.DocObjects.ModelComponent>,
    System.Collections.Generic.IEnumerable<Rhino.DocObjects.ModelComponent>,
    System.Collections.IEnumerable,
    System.Collections.Generic.ICollection<Rhino.DocObjects.ModelComponent>
{
  public ManifestTable() { }

  public virtual Rhino.DocObjects.ModelComponent FindId(System.Guid id) => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.ModelComponent FindId(System.Guid id, Rhino.DocObjects.ModelComponentType type) =>
    throw new System.NotImplementedException();

  public virtual T FindId<T>(System.Guid id) => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.ModelComponent FindIndex(
    System.Int32 index,
    Rhino.DocObjects.ModelComponentType type
  ) => throw new System.NotImplementedException();

  public virtual T FindIndex<T>(System.Int32 index) => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.ModelComponent FindName(
    System.String name,
    Rhino.DocObjects.ModelComponentType type,
    System.Guid parent
  ) => throw new System.NotImplementedException();

  public virtual T FindName<T>(System.String name, System.Guid parent) => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.ModelComponent FindNameHash(
    Rhino.FileIO.NameHash nameHash,
    Rhino.DocObjects.ModelComponentType type
  ) => throw new System.NotImplementedException();

  public virtual T FindNameHash<T>(Rhino.FileIO.NameHash nameHash) => throw new System.NotImplementedException();

  public virtual System.Int32 ActiveObjectCount(Rhino.DocObjects.ModelComponentType type) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator<T>() =>
    throw new System.NotImplementedException();

  public static Rhino.DocObjects.ModelComponentType GetModelComponentTypeFromGenericType<T>() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.DocObjects.ModelComponent> GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.DocObjects.ModelComponent> GetEnumerator(
    Rhino.DocObjects.ModelComponentType type
  ) => throw new System.NotImplementedException();

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual System.Boolean Contains(Rhino.DocObjects.ModelComponent item) =>
    throw new System.NotImplementedException();

  public virtual void CopyTo(Rhino.DocObjects.ModelComponent[] array, System.Int32 arrayIndex) =>
    throw new System.NotImplementedException();

  Rhino.DocObjects.ModelComponent Rhino.FileIO.ICommonComponentTable<Rhino.DocObjects.ModelComponent>.FindNameHash(
    Rhino.FileIO.NameHash nameHash
  ) => throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<Rhino.DocObjects.ModelComponent>.Add(
    Rhino.DocObjects.ModelComponent item
  ) => throw new System.NotImplementedException();

  System.Boolean System.Collections.Generic.ICollection<Rhino.DocObjects.ModelComponent>.Remove(
    Rhino.DocObjects.ModelComponent item
  ) => throw new System.NotImplementedException();

  public virtual System.Object Parent
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Count
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int64 LongCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
  System.Boolean System.Collections.Generic.ICollection<Rhino.DocObjects.ModelComponent>.IsReadOnly
  {
    get => throw new System.NotImplementedException();
  }
}
