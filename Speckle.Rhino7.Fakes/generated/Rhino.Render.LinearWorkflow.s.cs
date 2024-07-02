namespace Rhino.Render;

public partial class LinearWorkflow : Rhino.Render.DocumentOrFreeFloatingBase
{
	public LinearWorkflow() {}
	public LinearWorkflow(Rhino.Render.LinearWorkflow src) => throw new System.NotImplementedException();
	public virtual System.Boolean PreProcessColors
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean PreProcessTextures
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean PostProcessFrameBuffer
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Single PreProcessGamma
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Single PostProcessGamma
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean PostProcessGammaOn
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Single PostProcessGammaReciprocal
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.UInt32 Hash
	{
		get => throw new System.NotImplementedException();
	}
}
