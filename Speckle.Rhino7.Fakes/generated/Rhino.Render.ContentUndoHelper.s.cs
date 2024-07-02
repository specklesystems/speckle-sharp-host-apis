namespace Rhino.Render;

public partial class ContentUndoHelper : System.IDisposable
{
	public ContentUndoHelper() {}
	public ContentUndoHelper(Rhino.RhinoDoc doc,System.String description) => throw new System.NotImplementedException();
	public virtual System.Boolean AddContent(Rhino.Render.RenderContent content,Rhino.Render.RenderContent parent) => throw new System.NotImplementedException();
	public virtual System.Boolean ModifyContent(Rhino.Render.RenderContent content) => throw new System.NotImplementedException();
	public virtual System.Boolean TweakContent(Rhino.Render.RenderContent content,System.String parameterName) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
}
