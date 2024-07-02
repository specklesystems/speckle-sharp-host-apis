namespace Rhino.DocObjects;

public partial class RadialDimensionObject : Rhino.DocObjects.DimensionObject
{
  public RadialDimensionObject() { }

  public virtual Rhino.Geometry.RadialDimension RadialDimensionGeometry
  {
    get => throw new System.NotImplementedException();
  }
}
