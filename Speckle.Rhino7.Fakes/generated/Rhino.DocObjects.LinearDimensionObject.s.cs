namespace Rhino.DocObjects;

public partial class LinearDimensionObject : Rhino.DocObjects.DimensionObject
{
  public LinearDimensionObject() { }

  public virtual Rhino.Geometry.LinearDimension LinearDimensionGeometry
  {
    get => throw new System.NotImplementedException();
  }
}
