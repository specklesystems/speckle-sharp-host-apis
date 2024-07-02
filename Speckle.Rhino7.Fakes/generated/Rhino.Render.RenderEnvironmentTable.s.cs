namespace Rhino.Render;

public partial class RenderEnvironmentTable : Rhino.Render.IRenderContentTable<Rhino.Render.RenderEnvironment>,System.Collections.Generic.IEnumerable<Rhino.Render.RenderEnvironment>,System.Collections.IEnumerable,Rhino.Collections.IRhinoTable<Rhino.Render.RenderEnvironment>
{
	public RenderEnvironmentTable() {}
	public virtual System.Boolean Add(Rhino.Render.RenderEnvironment c) => throw new System.NotImplementedException();
	public virtual System.Boolean Remove(Rhino.Render.RenderEnvironment c) => throw new System.NotImplementedException();
	public virtual void BeginChange(Rhino.Render.RenderContent.ChangeContexts changeContext) => throw new System.NotImplementedException();
	public virtual void EndChange() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerator<Rhino.Render.RenderEnvironment> GetEnumerator() => throw new System.NotImplementedException();
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
	public virtual System.Int32 Count
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RenderEnvironment this[System.Int32 index]
	{
		get => throw new System.NotImplementedException();
	}
}
