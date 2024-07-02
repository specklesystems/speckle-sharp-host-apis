namespace Rhino.Render;

public partial interface IRenderContentTable<TContentType>
{
	public  System.Boolean Add(TContentType content);
	public  System.Boolean Remove(TContentType content);
	public  void BeginChange(Rhino.Render.RenderContent.ChangeContexts changeContext);
	public  void EndChange();
}
