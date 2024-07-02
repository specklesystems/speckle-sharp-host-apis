namespace Rhino.Render;

public partial class RenderSourceView : System.IDisposable
{
	public RenderSourceView() {}
	public RenderSourceView(Rhino.RhinoDoc doc) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.ViewInfo GetViewInfo() => throw new System.NotImplementedException();
}
