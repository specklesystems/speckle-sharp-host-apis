namespace Rhino.Render;

public partial class CreatePreviewEventArgs : System.EventArgs
{
	public CreatePreviewEventArgs() {}
	public virtual void SkipInitialisation() => throw new System.NotImplementedException();
	public virtual Rhino.Render.CreatePreviewReason Reason
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RenderContent PreviewContent
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.PreviewSceneQuality Quality
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Cancel
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 Id
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RenderContentKind ContentKind
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid ContentTypeId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RenderEnvironment Environment
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Collections.Generic.List<Rhino.Geometry.Light> Lights
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.ViewportInfo Viewport
	{
		get => throw new System.NotImplementedException();
	}
}
