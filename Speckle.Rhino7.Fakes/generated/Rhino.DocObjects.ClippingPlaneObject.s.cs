namespace Rhino.DocObjects;

public partial class ClippingPlaneObject : Rhino.DocObjects.RhinoObject
{
	public ClippingPlaneObject() {}
	public virtual Rhino.Geometry.ClippingPlaneSurface ClippingPlaneGeometry
	{
		get => throw new System.NotImplementedException();
	}
}
