using Rhino.Geometry;
using Speckle.Rhino7.Interfaces;

namespace Speckle.Rhino7.Api;

public class RhinoMeshFactory : IRhinoMeshFactory
{
  public IRhinoMesh Create() => new MeshProxy(new Mesh());

  public IEnumerable<IRhinoMesh> CreateFromBrep(IRhinoBrep brep, double density, double minimumEdgeLength)
  {
    var b = A.Cast<IRhinoBrepProxy, Brep>(brep, x => x._Instance) ?? throw new NullReferenceException();
    return Mesh.CreateFromBrep(b, new MeshingParameters(density, minimumEdgeLength)).Select(x => new MeshProxy(x));
  }
}
