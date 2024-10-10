namespace Rhino.Geometry;

public partial class SubDEdge : Rhino.Geometry.SubDComponent
{
  public SubDEdge() { }

  public virtual Rhino.Geometry.ComponentIndex ComponentIndex() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.SubDFace FaceAt(System.Int32 index) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.NurbsCurve ToNurbsCurve(System.Boolean clampEnds) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 FaceCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Line ControlNetLine
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.SubDVertex VertexFrom
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.SubDVertex VertexTo
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.SubDEdgeTag Tag
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
