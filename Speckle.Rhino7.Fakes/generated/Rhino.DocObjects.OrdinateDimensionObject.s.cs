namespace Rhino.DocObjects;

public partial class OrdinateDimensionObject : Rhino.DocObjects.DimensionObject
{
	public OrdinateDimensionObject() {}
	public virtual Rhino.Geometry.OrdinateDimension OrdinateDimensionGeometry
	{
		get => throw new System.NotImplementedException();
	}
}
