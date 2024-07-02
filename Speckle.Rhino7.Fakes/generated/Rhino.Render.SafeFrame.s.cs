namespace Rhino.Render;

public partial class SafeFrame : Rhino.Render.DocumentOrFreeFloatingBase
{
	public SafeFrame() {}
	public SafeFrame(Rhino.RhinoDoc doc) => throw new System.NotImplementedException();
	public SafeFrame(Rhino.Render.SafeFrame g) => throw new System.NotImplementedException();
	public virtual System.Boolean Enabled
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean PerspectiveOnly
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean FieldsOn
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean LiveFrameOn
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ActionFrameOn
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ActionFrameLinked
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ActionFrameXScale
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ActionFrameYScale
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean TitleFrameOn
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean TitleFrameLinked
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double TitleFrameXScale
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double TitleFrameYScale
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
