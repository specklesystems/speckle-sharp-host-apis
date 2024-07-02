namespace Rhino.Render;

public partial class PreviewAppearance : System.IDisposable
{
	public PreviewAppearance() {}
	public PreviewAppearance(System.IntPtr pRenderContent) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Double RotationX() => throw new System.NotImplementedException();
	public virtual void SetRotationX(System.Double d) => throw new System.NotImplementedException();
	public virtual System.Double RotationY() => throw new System.NotImplementedException();
	public virtual void SetRotationY(System.Double d) => throw new System.NotImplementedException();
	public virtual System.Double Size() => throw new System.NotImplementedException();
	public virtual void SetSize(System.Double d) => throw new System.NotImplementedException();
	public virtual Rhino.Render.IRhRdkPreviewSceneServer_eRotationType RotationType() => throw new System.NotImplementedException();
	public virtual void SetRotationType(Rhino.Render.IRhRdkPreviewSceneServer_eRotationType type) => throw new System.NotImplementedException();
	public virtual Rhino.Render.PreviewGeometry Geometry() => throw new System.NotImplementedException();
	public virtual void ToMetaData() => throw new System.NotImplementedException();
	public virtual void ToMetaData(Rhino.Render.MetaDataProxy mdp) => throw new System.NotImplementedException();
	public virtual Rhino.Render.PreviewBackground Background() => throw new System.NotImplementedException();
	public virtual Rhino.Render.PreviewLighting Lighting() => throw new System.NotImplementedException();
	public virtual System.IntPtr CppPointer
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Scale
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double SceneScale
	{
		get => throw new System.NotImplementedException();
	}
}
