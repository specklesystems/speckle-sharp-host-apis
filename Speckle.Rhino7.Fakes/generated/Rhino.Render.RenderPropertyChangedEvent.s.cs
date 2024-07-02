namespace Rhino.Render;

public partial class RenderPropertyChangedEvent : System.EventArgs
{
	public RenderPropertyChangedEvent() {}
	public virtual Rhino.RhinoDoc Document
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 Context
	{
		get => throw new System.NotImplementedException();
	}
}
