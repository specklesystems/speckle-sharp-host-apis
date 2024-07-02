namespace Rhino.DocObjects;

public partial class InstanceObject : Rhino.DocObjects.RhinoObject
{
	public InstanceObject() {}
	public virtual Rhino.Geometry.Transform InstanceXform
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Point3d InsertionPoint
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.InstanceDefinition InstanceDefinition
	{
		get => throw new System.NotImplementedException();
	}
}
