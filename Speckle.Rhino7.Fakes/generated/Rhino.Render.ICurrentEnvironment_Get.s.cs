namespace Rhino.Render;

public partial interface ICurrentEnvironment_Get
{
	public  Rhino.Render.RenderEnvironment ForBackground
	{
		get;
	}
	public  Rhino.Render.RenderEnvironment ForBackground_CheckMode
	{
		get;
	}
	public  Rhino.Render.RenderEnvironment ForLighting
	{
		get;
	}
	public  Rhino.Render.RenderEnvironment ForReflectionAndRefraction
	{
		get;
	}
}
