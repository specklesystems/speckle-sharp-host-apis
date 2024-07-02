namespace Rhino.Render;

public partial class RenderMaterialTable : Rhino.Render.IRenderContentTable<TContentType>,System.Collections.Generic.IEnumerable<Rhino.Render.RenderMaterial>,Rhino.Collections.IRhinoTable<T>
{
	public RenderMaterialTable() {}
	public virtual System.Boolean Add(Rhino.Render.RenderMaterial c) => throw new System.NotImplementedException();
	public virtual System.Boolean Remove(Rhino.Render.RenderMaterial c) => throw new System.NotImplementedException();
	public virtual void BeginChange(Rhino.Render.RenderContent.ChangeContexts changeContext) => throw new System.NotImplementedException();
	public virtual void EndChange() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerator<Rhino.Render.RenderMaterial> GetEnumerator() => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderMaterial get_Item(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Int32 Count
	{
		get => throw new System.NotImplementedException();
	}
}
