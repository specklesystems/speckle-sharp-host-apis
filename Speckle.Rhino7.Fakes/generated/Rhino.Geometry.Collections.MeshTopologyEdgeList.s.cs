namespace Rhino.Geometry.Collections;

public partial class MeshTopologyEdgeList
{
	public MeshTopologyEdgeList() {}
	public virtual Rhino.IndexPair GetTopologyVertices(System.Int32 topologyEdgeIndex) => throw new System.NotImplementedException();
	public virtual System.Int32[] GetConnectedFaces(System.Int32 topologyEdgeIndex) => throw new System.NotImplementedException();
	public virtual System.Int32[] GetEdgesForFace(System.Int32 faceIndex) => throw new System.NotImplementedException();
	public virtual System.Int32 GetEdgeIndex(System.Int32 topologyVertex1,System.Int32 topologyVertex2) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Line EdgeLine(System.Int32 topologyEdgeIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean CollapseEdge(System.Int32 topologyEdgeIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean SplitEdge(System.Int32 topologyEdgeIndex,System.Double t) => throw new System.NotImplementedException();
	public virtual System.Boolean SplitEdge(System.Int32 topologyEdgeIndex,Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public virtual System.Boolean IsEdgeUnwelded(System.Int32 topologyEdgeIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean IsSwappableEdge(System.Int32 topologyEdgeIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean SwapEdge(System.Int32 topologyEdgeIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean IsHidden(System.Int32 topologyEdgeIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean IsNgonInterior(System.Int32 topologyEdgeIndex) => throw new System.NotImplementedException();
	public virtual System.Int32 Count
	{
		get => throw new System.NotImplementedException();
	}
}
