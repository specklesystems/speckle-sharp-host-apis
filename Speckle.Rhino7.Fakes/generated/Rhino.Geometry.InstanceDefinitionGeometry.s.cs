namespace Rhino.Geometry;

public partial class InstanceDefinitionGeometry : Rhino.DocObjects.ModelComponent
{
	public InstanceDefinitionGeometry() {}
	public virtual System.Guid[] GetObjectIds() => throw new System.NotImplementedException();
	public virtual System.String Description
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String Url
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String UrlDescription
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public new Rhino.DocObjects.ModelComponentType ComponentType
	{
		get => throw new System.NotImplementedException();
	}
}
