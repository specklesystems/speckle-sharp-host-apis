namespace Rhino.Geometry;

public partial class InstanceReferenceGeometry : Rhino.Geometry.GeometryBase
{
	public InstanceReferenceGeometry() {}
	public InstanceReferenceGeometry(System.Guid instanceDefinitionId,Rhino.Geometry.Transform transform) => throw new System.NotImplementedException();
	public virtual System.Guid ParentIdefId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Transform Xform
	{
		get => throw new System.NotImplementedException();
	}
}
