namespace Rhino.DocObjects;

public partial class CentermarkObject : Rhino.DocObjects.DimensionObject
{
	public CentermarkObject() {}
	public virtual Rhino.Geometry.Centermark CentermarkGeometry
	{
		get => throw new System.NotImplementedException();
	}
}
