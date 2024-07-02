namespace Rhino.Render;

public partial interface ICurrentEnvironment
{
	public  Rhino.Render.RenderEnvironment ForBackground
	{
		get;
		set;
	}
	public  Rhino.Render.RenderEnvironment ForBackground_CheckMode
	{
		get;
		set;
	}
	public  Rhino.Render.RenderEnvironment ForLighting
	{
		get;
		set;
	}
	public  Rhino.Render.RenderEnvironment ForReflectionAndRefraction
	{
		get;
		set;
	}
	public  Rhino.Render.RenderEnvironment ForAnyUsage
	{
		set;
	}
}
