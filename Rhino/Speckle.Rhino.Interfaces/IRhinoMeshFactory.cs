namespace Speckle.Rhino7.Interfaces;

public interface IRhinoMeshFactory
{
  IRhinoMesh Create();
  IEnumerable<IRhinoMesh> CreateFromBrep(IRhinoBrep brep, double density, double minimumEdgeLength);
}
