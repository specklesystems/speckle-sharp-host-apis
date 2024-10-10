namespace Rhino.Runtime;

public partial interface IShrinkWrapService
{
  public Rhino.Geometry.Mesh ShrinkWrap(Rhino.Geometry.Mesh mesh, Rhino.Geometry.ShrinkWrapParameters parameters);
  public Rhino.Geometry.Mesh ShrinkWrap(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> meshes,
    Rhino.Geometry.ShrinkWrapParameters parameters
  );
  public Rhino.Geometry.Mesh ShrinkWrap(
    Rhino.Geometry.PointCloud pointCloud,
    Rhino.Geometry.ShrinkWrapParameters parameters
  );
  public Rhino.Geometry.Mesh ShrinkWrap(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> geometryBases,
    Rhino.Geometry.ShrinkWrapParameters parameters,
    Rhino.Geometry.MeshingParameters meshingParameters
  );
}
