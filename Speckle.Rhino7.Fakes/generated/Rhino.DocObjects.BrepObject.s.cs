namespace Rhino.DocObjects;

public partial class BrepObject : Rhino.DocObjects.RhinoObject
{
	public BrepObject() {}
	public virtual Rhino.Geometry.Brep DuplicateBrepGeometry() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep BrepGeometry
	{
		get => throw new System.NotImplementedException();
	}
}
