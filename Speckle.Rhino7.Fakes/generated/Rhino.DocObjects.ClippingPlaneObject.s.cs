namespace Rhino.DocObjects;

public partial class ClippingPlaneObject : Rhino.DocObjects.RhinoObject
{
	public ClippingPlaneObject() {}
	public virtual System.Boolean AddClipViewport(Rhino.Display.RhinoViewport viewport,System.Boolean commit) => throw new System.NotImplementedException();
	public virtual System.Boolean RemoveClipViewport(Rhino.Display.RhinoViewport viewport,System.Boolean commit) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.ClippingPlaneSurface ClippingPlaneGeometry
	{
		get => throw new System.NotImplementedException();
	}
}
