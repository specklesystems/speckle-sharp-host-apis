namespace Rhino.DocObjects;

public partial class AngularDimensionObject : Rhino.DocObjects.DimensionObject
{
	public AngularDimensionObject() {}
	public virtual Rhino.Geometry.AngularDimension AngularDimensionGeometry
	{
		get => throw new System.NotImplementedException();
	}
}
