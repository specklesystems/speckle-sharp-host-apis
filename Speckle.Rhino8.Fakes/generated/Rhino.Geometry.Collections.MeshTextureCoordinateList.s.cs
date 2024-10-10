namespace Rhino.Geometry.Collections;

public partial class MeshTextureCoordinateList
  : Rhino.Collections.IResizableList<Rhino.Geometry.Point2f>,
    System.Collections.Generic.IList<Rhino.Geometry.Point2f>,
    System.Collections.Generic.ICollection<Rhino.Geometry.Point2f>,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point2f>,
    System.Collections.IEnumerable,
    System.Collections.IList,
    System.Collections.ICollection,
    System.Collections.Generic.IReadOnlyList<Rhino.Geometry.Point2f>,
    System.Collections.Generic.IReadOnlyCollection<Rhino.Geometry.Point2f>
{
  public MeshTextureCoordinateList() { }

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual System.Int32 Add(System.Single s, System.Single t) => throw new System.NotImplementedException();

  public virtual System.Int32 Add(System.Double s, System.Double t) => throw new System.NotImplementedException();

  public virtual System.Int32 Add(Rhino.Geometry.Point2f tc) => throw new System.NotImplementedException();

  public virtual System.Int32 Add(Rhino.Geometry.Point3d tc) => throw new System.NotImplementedException();

  public virtual System.Boolean AddRange(Rhino.Geometry.Point2f[] textureCoordinates) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetTextureCoordinate(System.Int32 index, System.Single s, System.Single t) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetTextureCoordinate(System.Int32 index, System.Double s, System.Double t) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetTextureCoordinate(System.Int32 index, Rhino.Geometry.Point2f tc) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetTextureCoordinate(System.Int32 index, Rhino.Geometry.Point3f tc) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetTextureCoordinates(Rhino.Geometry.Point2f[] textureCoordinates) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetTextureCoordinates(Rhino.Render.TextureMapping mapping) =>
    throw new System.NotImplementedException();

  public virtual void Destroy() => throw new System.NotImplementedException();

  public virtual System.Boolean NormalizeTextureCoordinates() => throw new System.NotImplementedException();

  public virtual System.Boolean TransposeTextureCoordinates() => throw new System.NotImplementedException();

  public virtual System.Boolean ReverseTextureCoordinates(System.Int32 direction) =>
    throw new System.NotImplementedException();

  public virtual System.Single[] ToFloatArray() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.Geometry.Point2f> GetEnumerator() =>
    throw new System.NotImplementedException();

  System.Int32 System.Collections.Generic.IList<Rhino.Geometry.Point2f>.IndexOf(Rhino.Geometry.Point2f item) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.IList<Rhino.Geometry.Point2f>.Insert(
    System.Int32 index,
    Rhino.Geometry.Point2f item
  ) => throw new System.NotImplementedException();

  void System.Collections.Generic.IList<Rhino.Geometry.Point2f>.RemoveAt(System.Int32 index) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<Rhino.Geometry.Point2f>.Add(Rhino.Geometry.Point2f item) =>
    throw new System.NotImplementedException();

  System.Boolean System.Collections.Generic.ICollection<Rhino.Geometry.Point2f>.Contains(Rhino.Geometry.Point2f item) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<Rhino.Geometry.Point2f>.CopyTo(
    Rhino.Geometry.Point2f[] array,
    System.Int32 arrayIndex
  ) => throw new System.NotImplementedException();

  System.Boolean System.Collections.Generic.ICollection<Rhino.Geometry.Point2f>.Remove(Rhino.Geometry.Point2f item) =>
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
  public virtual Rhino.Geometry.Point2f this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  System.Boolean System.Collections.Generic.ICollection<Rhino.Geometry.Point2f>.IsReadOnly
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
