namespace Rhino.Render;

public partial interface IRenderContentTable<T0>
{
	public  void BeginChange(Rhino.Render.RenderContent.ChangeContexts changeContext);
	public  void EndChange();
}
