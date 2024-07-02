namespace Rhino.Geometry;

public partial class BrepLoop : Rhino.Geometry.GeometryBase
{
  public BrepLoop() { }

  public virtual Rhino.Geometry.Curve To3dCurve() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Curve To2dCurve() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep Brep
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 LoopIndex
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.BrepFace Face
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.BrepLoopType LoopType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Collections.BrepTrimList Trims
  {
    get => throw new System.NotImplementedException();
  }
}
