namespace Rhino.FileIO;

public partial class File3dmNamedConstructionPlanes
  : System.Collections.Generic.IList<Rhino.DocObjects.ConstructionPlane>,
    System.Collections.Generic.ICollection<Rhino.DocObjects.ConstructionPlane>,
    System.Collections.Generic.IEnumerable<Rhino.DocObjects.ConstructionPlane>,
    System.Collections.IEnumerable,
    Rhino.Collections.IRhinoTable<Rhino.DocObjects.ConstructionPlane>
{
  public File3dmNamedConstructionPlanes() { }

  public virtual Rhino.DocObjects.ConstructionPlane FindName(System.String name) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 IndexOf(Rhino.DocObjects.ConstructionPlane cplane) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Delete(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Boolean Delete(Rhino.DocObjects.ConstructionPlane cplane) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 Add(System.String name, Rhino.Geometry.Plane plane) =>
    throw new System.NotImplementedException();

  public virtual void Add(Rhino.DocObjects.ConstructionPlane cplane) => throw new System.NotImplementedException();

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual System.Boolean Contains(Rhino.DocObjects.ConstructionPlane cplane) =>
    throw new System.NotImplementedException();

  public virtual void CopyTo(Rhino.DocObjects.ConstructionPlane[] array, System.Int32 arrayIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.DocObjects.ConstructionPlane> GetEnumerator() =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.IList<Rhino.DocObjects.ConstructionPlane>.Insert(
    System.Int32 index,
    Rhino.DocObjects.ConstructionPlane cplane
  ) => throw new System.NotImplementedException();

  System.Boolean System.Collections.Generic.ICollection<Rhino.DocObjects.ConstructionPlane>.Remove(
    Rhino.DocObjects.ConstructionPlane cplane
  ) => throw new System.NotImplementedException();

  void System.Collections.Generic.IList<Rhino.DocObjects.ConstructionPlane>.RemoveAt(System.Int32 index) =>
    throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.ConstructionPlane this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Count
  {
    get => throw new System.NotImplementedException();
  }
  Rhino.DocObjects.ConstructionPlane System.Collections.Generic.IList<Rhino.DocObjects.ConstructionPlane>.this[
    System.Int32 index
  ]
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  System.Boolean System.Collections.Generic.ICollection<Rhino.DocObjects.ConstructionPlane>.IsReadOnly
  {
    get => throw new System.NotImplementedException();
  }
}
