namespace Rhino.Geometry;

public partial class MeshFace
  : System.IEquatable<Rhino.Geometry.MeshFace>,
    System.IComparable<Rhino.Geometry.MeshFace>,
    System.IComparable
{
  public MeshFace() { }

  public MeshFace(System.Int32 a, System.Int32 b, System.Int32 c) => throw new System.NotImplementedException();

  public MeshFace(System.Int32 a, System.Int32 b, System.Int32 c, System.Int32 d) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValid() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValid(System.Int32 vertexCount) => throw new System.NotImplementedException();

  public virtual System.Boolean IsValid(Rhino.Geometry.Point3d[] points) => throw new System.NotImplementedException();

  public virtual System.Boolean Repair(Rhino.Geometry.Point3d[] points) => throw new System.NotImplementedException();

  public virtual void Set(System.Int32 a, System.Int32 b, System.Int32 c) => throw new System.NotImplementedException();

  public virtual void Set(System.Int32 a, System.Int32 b, System.Int32 c, System.Int32 d) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.MeshFace Flip() => throw new System.NotImplementedException();

  public virtual System.Boolean Equals(Rhino.Geometry.MeshFace other) => throw new System.NotImplementedException();

  public virtual System.Int32 CompareTo(Rhino.Geometry.MeshFace other) => throw new System.NotImplementedException();

  System.Int32 System.IComparable.CompareTo(System.Object obj) => throw new System.NotImplementedException();

  public static Rhino.Geometry.MeshFace Unset
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 A
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 B
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 C
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 D
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsTriangle
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsQuad
  {
    get => throw new System.NotImplementedException();
  }
}
