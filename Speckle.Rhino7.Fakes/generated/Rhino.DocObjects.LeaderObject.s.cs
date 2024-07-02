namespace Rhino.DocObjects;

public partial class LeaderObject : Rhino.DocObjects.AnnotationObjectBase
{
	public LeaderObject() {}
	public virtual Rhino.Geometry.Leader LeaderGeometry
	{
		get => throw new System.NotImplementedException();
	}
}
