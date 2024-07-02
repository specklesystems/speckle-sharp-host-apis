namespace Rhino.Geometry;

public partial class BrepEdge : Rhino.Geometry.CurveProxy
{
  public BrepEdge() { }

  public virtual Rhino.Geometry.Concavity ConcavityAt(System.Double t, System.Double tolerance) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsSmoothManifoldEdge(System.Double angleToleranceRadians) =>
    throw new System.NotImplementedException();

  public virtual System.Int32[] AdjacentFaces() => throw new System.NotImplementedException();

  public virtual System.Int32[] TrimIndices() => throw new System.NotImplementedException();

  public virtual System.Boolean GetEdgeParameter(
    System.Int32 trimIndex,
    System.Double trimParameter,
    out System.Double edgeParameter
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean SetEdgeCurve(System.Int32 curve3dIndex) => throw new System.NotImplementedException();

  public virtual System.Boolean SetEdgeCurve(System.Int32 curve3dIndex, Rhino.Geometry.Interval subDomain) =>
    throw new System.NotImplementedException();

  public virtual System.Double Tolerance
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 TrimCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.EdgeAdjacency Valence
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Brep Brep
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 EdgeIndex
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 EdgeCurveIndex
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Curve EdgeCurve
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.BrepVertex StartVertex
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.BrepVertex EndVertex
  {
    get => throw new System.NotImplementedException();
  }
}
