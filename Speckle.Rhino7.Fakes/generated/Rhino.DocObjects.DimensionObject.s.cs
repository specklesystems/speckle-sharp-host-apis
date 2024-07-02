namespace Rhino.DocObjects;

public partial class DimensionObject : Rhino.DocObjects.AnnotationObjectBase
{
	public DimensionObject() {}
	public virtual Rhino.DocObjects.DimensionStyle DimensionStyle
	{
		get => throw new System.NotImplementedException();
	}
}
