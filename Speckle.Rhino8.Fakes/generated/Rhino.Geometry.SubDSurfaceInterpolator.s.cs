namespace Rhino.Geometry;

public partial class SubDSurfaceInterpolator : System.IDisposable
{
  public SubDSurfaceInterpolator() { }

  public virtual void Dispose() => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubDSurfaceInterpolator CreateFromSubD(
    Rhino.Geometry.SubD subd,
    out System.UInt32 freeVertexCount
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubDSurfaceInterpolator CreateFromMarkedVertices(
    Rhino.Geometry.SubD subd,
    System.Boolean interpolatedVerticesMark,
    out System.UInt32 freeVertexCount
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubDSurfaceInterpolator CreateFromSelectedVertices(
    Rhino.Geometry.SubD subd,
    out System.UInt32 freeVertexCount
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubDSurfaceInterpolator CreateFromVertexIdList(
    Rhino.Geometry.SubD subd,
    System.Collections.Generic.IEnumerable<System.UInt32> vertexIndices,
    out System.UInt32 freeVertexCount
  ) => throw new System.NotImplementedException();

  public virtual void Clear() => throw new System.NotImplementedException();

  public virtual System.UInt32 InterpolatedVertexCount() => throw new System.NotImplementedException();

  public virtual System.UInt32 FixedVertexCount() => throw new System.NotImplementedException();

  public virtual System.Boolean IsInterpolatedVertex(System.UInt32 vertexId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsInterpolatedVertex(Rhino.Geometry.SubDVertex vertex) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Solve(Rhino.Geometry.Point3d[] surfacePoints) =>
    throw new System.NotImplementedException();

  public virtual System.UInt32 InterpolatedVertexIndex(System.UInt32 vertexId) =>
    throw new System.NotImplementedException();

  public virtual System.UInt32[] VertexIdList() => throw new System.NotImplementedException();

  public virtual void Transform(Rhino.Geometry.Transform transform) => throw new System.NotImplementedException();

  public static System.UInt32 MaximumRecommendedInterpolatedVertexCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Guid ContextId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
