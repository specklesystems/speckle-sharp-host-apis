namespace Rhino.Geometry;

public partial class MeshExtruder : System.IDisposable
{
  public MeshExtruder() { }

  public MeshExtruder(
    Rhino.Geometry.Mesh inputMesh,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.ComponentIndex> componentIndices
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean ExtrudedMesh(out Rhino.Geometry.Mesh extrudedMeshOut) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean ExtrudedMesh(
    out Rhino.Geometry.Mesh extrudedMeshOut,
    out System.Collections.Generic.List<Rhino.Geometry.ComponentIndex> componentIndicesOut
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.List<System.Int32> GetWallFaces() =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Line[] PreviewLines
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Transform Transform
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UVN
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean EdgeBasedUVN
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean KeepOriginalFaces
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.MeshExtruderParameterMode TextureCoordinateMode
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.MeshExtruderParameterMode SurfaceParameterMode
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.MeshExtruderFaceDirectionMode FaceDirectionMode
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
