namespace Rhino.DocObjects;

public partial class ExtrusionObject : Rhino.DocObjects.RhinoObject
{
	public ExtrusionObject() {}
	public virtual Rhino.Geometry.Extrusion DuplicateExtrusionGeometry() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Extrusion ExtrusionGeometry
	{
		get => throw new System.NotImplementedException();
	}
}
