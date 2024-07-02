namespace Rhino.Geometry;

public partial struct MeshFace
  : System.IEquatable<Rhino.Geometry.MeshFace>,
    System.IComparable<Rhino.Geometry.MeshFace>,
    System.IComparable
{
  public MeshFace() { }

  public MeshFace(System.Int32 a, System.Int32 b, System.Int32 c) => throw new System.NotImplementedException();

  public MeshFace(System.Int32 a, System.Int32 b, System.Int32 c, System.Int32 d) =>
    throw new System.NotImplementedException();

  public System.Boolean IsValid() => throw new System.NotImplementedException();

  public System.Boolean IsValid(System.Int32 vertexCount) => throw new System.NotImplementedException();

  public System.Boolean IsValid(Rhino.Geometry.Point3d[] points) => throw new System.NotImplementedException();

  public System.Boolean Repair(Rhino.Geometry.Point3d[] points) => throw new System.NotImplementedException();

  public void Set(System.Int32 a, System.Int32 b, System.Int32 c) => throw new System.NotImplementedException();

  public void Set(System.Int32 a, System.Int32 b, System.Int32 c, System.Int32 d) =>
    throw new System.NotImplementedException();

  public Rhino.Geometry.MeshFace Flip() => throw new System.NotImplementedException();

  public System.Boolean Equals(Rhino.Geometry.MeshFace other) => throw new System.NotImplementedException();

  public System.Int32 CompareTo(Rhino.Geometry.MeshFace other) => throw new System.NotImplementedException();

  System.Int32 System.IComparable.CompareTo(System.Object obj) => throw new System.NotImplementedException();

  public static Rhino.Geometry.MeshFace Unset
  {
    get => throw new System.NotImplementedException();
  }
  public System.Int32 A
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public System.Int32 B
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public System.Int32 C
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public System.Int32 D
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public System.Int32 this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public System.Boolean IsTriangle
  {
    get => throw new System.NotImplementedException();
  }
  public System.Boolean IsQuad
  {
    get => throw new System.NotImplementedException();
  }
}
