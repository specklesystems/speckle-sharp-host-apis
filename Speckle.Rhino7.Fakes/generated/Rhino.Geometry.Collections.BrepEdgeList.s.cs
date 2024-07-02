namespace Rhino.Geometry.Collections;

public partial class BrepEdgeList
  : System.Collections.Generic.IEnumerable<Rhino.Geometry.BrepEdge>,
    System.Collections.IEnumerable,
    Rhino.Collections.IRhinoTable<Rhino.Geometry.BrepEdge>
{
  public BrepEdgeList() { }

  public virtual System.Int32 RemoveNakedMicroEdges(System.Double tolerance) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 RemoveNakedMicroEdges(System.Double tolerance, System.Boolean cleanUp) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 MergeEdge(System.Int32 edgeIndex, System.Double angleTolerance) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 MergeAllEdges(System.Double angleTolerance) => throw new System.NotImplementedException();

  public virtual System.Boolean SplitKinkyEdge(System.Int32 edgeIndex, System.Double kinkToleranceRadians) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 SplitEdgeAtParameters(
    System.Int32 edgeIndex,
    System.Collections.Generic.IEnumerable<System.Double> edgeParameters
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BrepEdge Add(System.Int32 curve3dIndex) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BrepEdge Add(
    Rhino.Geometry.BrepVertex startVertex,
    Rhino.Geometry.BrepVertex endVertex,
    System.Int32 curve3dIndex,
    Rhino.Geometry.Interval subDomain,
    System.Double edgeTolerance
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BrepEdge Add(
    Rhino.Geometry.BrepVertex startVertex,
    Rhino.Geometry.BrepVertex endVertex,
    System.Int32 curve3dIndex,
    System.Double edgeTolerance
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BrepEdge Add(
    System.Int32 startVertexIndex,
    System.Int32 endVertexIndex,
    System.Int32 curve3dIndex,
    Rhino.Geometry.Interval subDomain,
    System.Double edgeTolerance
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BrepEdge Add(
    System.Int32 startVertexIndex,
    System.Int32 endVertexIndex,
    System.Int32 curve3dIndex,
    System.Double edgeTolerance
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.Geometry.BrepEdge> GetEnumerator() =>
    throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual System.Int32 Count
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.BrepEdge this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
  }
}
