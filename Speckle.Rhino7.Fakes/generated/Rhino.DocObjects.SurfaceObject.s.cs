namespace Rhino.DocObjects;

public partial class SurfaceObject : Rhino.DocObjects.RhinoObject
{
	public SurfaceObject() {}
	public virtual Rhino.Geometry.Surface DuplicateSurfaceGeometry() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Surface SurfaceGeometry
	{
		get => throw new System.NotImplementedException();
	}
}
