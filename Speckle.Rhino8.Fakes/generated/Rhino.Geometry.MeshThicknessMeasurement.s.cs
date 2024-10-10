namespace Rhino.Geometry;

public partial class MeshThicknessMeasurement
{
  public MeshThicknessMeasurement() { }

  public MeshThicknessMeasurement(
    System.Int32 meshIndex,
    System.Int32 vertexIndex,
    System.Double thickness,
    Rhino.Geometry.Point3d point,
    Rhino.Geometry.Point3d oppositePoint
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 MeshIndex
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 VertexIndex
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Thickness
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point3d Point
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point3d OppositePoint
  {
    get => throw new System.NotImplementedException();
  }
}
