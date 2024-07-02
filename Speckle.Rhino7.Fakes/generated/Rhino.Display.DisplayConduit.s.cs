namespace Rhino.Display;

public partial class DisplayConduit
{
	public DisplayConduit() {}
	public virtual void SetSelectionFilter(System.Boolean on,System.Boolean checkSubObjects) => throw new System.NotImplementedException();
	public virtual void SetObjectIdFilter(System.Guid id) => throw new System.NotImplementedException();
	public virtual void SetObjectIdFilter(System.Collections.Generic.IEnumerable<System.Guid> ids) => throw new System.NotImplementedException();
	public virtual System.Boolean Enabled
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.ObjectType GeometryFilter
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.ActiveSpace SpaceFilter
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
