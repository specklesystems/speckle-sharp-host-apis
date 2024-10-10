namespace Rhino.FileIO;

public partial class File3dmViewTable
  : System.Collections.Generic.IList<Rhino.DocObjects.ViewInfo>,
    System.Collections.Generic.ICollection<Rhino.DocObjects.ViewInfo>,
    System.Collections.Generic.IEnumerable<Rhino.DocObjects.ViewInfo>,
    System.Collections.IEnumerable,
    Rhino.Collections.IRhinoTable<Rhino.DocObjects.ViewInfo>
{
  public File3dmViewTable() { }

  public virtual Rhino.DocObjects.ViewInfo FindName(System.String name) => throw new System.NotImplementedException();

  public virtual System.Int32 IndexOf(Rhino.DocObjects.ViewInfo item) => throw new System.NotImplementedException();

  public virtual System.Boolean Delete(System.Int32 index) => throw new System.NotImplementedException();

  public virtual void Add(Rhino.DocObjects.ViewInfo item) => throw new System.NotImplementedException();

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual System.Boolean Contains(Rhino.DocObjects.ViewInfo item) => throw new System.NotImplementedException();

  public virtual void CopyTo(Rhino.DocObjects.ViewInfo[] array, System.Int32 arrayIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Delete(Rhino.DocObjects.ViewInfo item) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.DocObjects.ViewInfo> GetEnumerator() =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.IList<Rhino.DocObjects.ViewInfo>.Insert(
    System.Int32 index,
    Rhino.DocObjects.ViewInfo item
  ) => throw new System.NotImplementedException();

  System.Boolean System.Collections.Generic.ICollection<Rhino.DocObjects.ViewInfo>.Remove(
    Rhino.DocObjects.ViewInfo item
  ) => throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.IList<Rhino.DocObjects.ViewInfo>.RemoveAt(System.Int32 index) =>
    throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.ViewInfo this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Count
  {
    get => throw new System.NotImplementedException();
  }
  Rhino.DocObjects.ViewInfo System.Collections.Generic.IList<Rhino.DocObjects.ViewInfo>.this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  System.Boolean System.Collections.Generic.ICollection<Rhino.DocObjects.ViewInfo>.IsReadOnly
  {
    get => throw new System.NotImplementedException();
  }
}
