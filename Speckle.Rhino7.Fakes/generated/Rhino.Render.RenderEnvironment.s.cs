namespace Rhino.Render;

public partial class RenderEnvironment : Rhino.Render.RenderContent
{
	public RenderEnvironment() {}
	public static Rhino.Render.RenderEnvironment NewBasicEnvironment(Rhino.Render.SimulatedEnvironment environment) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderEnvironment NewBasicEnvironment(Rhino.Render.SimulatedEnvironment environment,Rhino.RhinoDoc doc) => throw new System.NotImplementedException();
	public virtual Rhino.Render.SimulatedEnvironment SimulateEnvironment(System.Boolean isForDataOnly) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderEnvironment CurrentEnvironment
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String TextureChildSlotName
	{
		get => throw new System.NotImplementedException();
	}
}
