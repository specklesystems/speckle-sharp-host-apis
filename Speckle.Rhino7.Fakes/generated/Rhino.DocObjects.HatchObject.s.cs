namespace Rhino.DocObjects;

public partial class HatchObject : Rhino.DocObjects.RhinoObject
{
	public HatchObject() {}
	public virtual Rhino.Geometry.Hatch HatchGeometry
	{
		get => throw new System.NotImplementedException();
	}
}
