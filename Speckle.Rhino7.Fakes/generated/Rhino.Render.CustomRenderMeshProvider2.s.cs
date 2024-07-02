namespace Rhino.Render;

public partial class CustomRenderMeshProvider2 : Rhino.Render.CustomRenderMeshProvider
{
	public CustomRenderMeshProvider2() {}
	public virtual System.Boolean WillBuildCustomMeshes(Rhino.DocObjects.ViewportInfo vp,Rhino.DocObjects.RhinoObject obj,Rhino.RhinoDoc doc,System.Guid requestingPlugIn,Rhino.Display.DisplayPipelineAttributes attrs) => throw new System.NotImplementedException();
	public virtual System.Boolean BuildCustomMeshes(Rhino.DocObjects.ViewportInfo vp,Rhino.RhinoDoc doc,Rhino.Render.RenderPrimitiveList objMeshes,System.Guid requestingPlugIn,Rhino.Display.DisplayPipelineAttributes attrs) => throw new System.NotImplementedException();
}
