namespace Rhino.DocObjects;

public partial class DetailViewObject : Rhino.DocObjects.RhinoObject
{
	public DetailViewObject() {}
	public virtual System.Boolean CommitViewportChanges() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.DetailView DetailGeometry
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsActive
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String DescriptiveTitle
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Transform WorldToPageTransform
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Transform PageToWorldTransform
	{
		get => throw new System.NotImplementedException();
	}
}
