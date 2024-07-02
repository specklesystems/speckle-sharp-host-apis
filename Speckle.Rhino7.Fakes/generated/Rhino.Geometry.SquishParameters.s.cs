namespace Rhino.Geometry;

public partial class SquishParameters : System.IDisposable
{
  public SquishParameters() { }

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual void SetSpringConstants(System.Double boundaryBias, System.Double deformationBias) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetSpringConstants(out System.Double boundaryBias, out System.Double deformationBias) =>
    throw new System.NotImplementedException();

  public virtual void SetDeformation(
    Rhino.Geometry.SquishDeformation deformation,
    System.Boolean bPreserveBoundary,
    System.Double boundaryStretchConstant,
    System.Double boundaryCompressConstant,
    System.Double interiorStretchConstant,
    System.Double interiorCompressConstant
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.SquishParameters Default
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean PreserveTopology
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SaveMapping
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double BoundaryStretchConstant
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double BoundaryCompressConstant
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double InteriorStretchConstant
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double InteriorCompressConstant
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double AbsoluteLimit
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.SquishFlatteningAlgorithm Algorithm
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
