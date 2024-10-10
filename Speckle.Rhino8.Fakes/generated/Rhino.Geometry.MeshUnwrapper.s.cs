namespace Rhino.Geometry;

public partial class MeshUnwrapper : System.IDisposable
{
  public MeshUnwrapper() { }

  public MeshUnwrapper(Rhino.Geometry.Mesh mesh) => throw new System.NotImplementedException();

  public MeshUnwrapper(System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> meshes) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean Unwrap(Rhino.Geometry.MeshUnwrapMethod method) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Plane SymmetryPlane
  {
    set { }
  }
}
