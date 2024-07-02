namespace Rhino.Render;

public partial class CustomRenderMeshProvider
{
	public CustomRenderMeshProvider() {}
	public virtual System.Boolean WillBuildCustomMeshes(Rhino.DocObjects.ViewportInfo vp,Rhino.DocObjects.RhinoObject obj,System.Guid requestingPlugIn,System.Boolean preview) => throw new System.NotImplementedException();
	public virtual System.Boolean BuildCustomMeshes(Rhino.DocObjects.ViewportInfo vp,Rhino.Render.RenderPrimitiveList objMeshes,System.Guid requestingPlugIn,System.Boolean meshType) => throw new System.NotImplementedException();
	public static void RegisterProviders(System.Reflection.Assembly assembly,System.Guid pluginId) => throw new System.NotImplementedException();
	public static void AllObjectsChanged() => throw new System.NotImplementedException();
	public static void AllObjectsChanged(Rhino.RhinoDoc doc) => throw new System.NotImplementedException();
	public static void ObjectChanged(Rhino.RhinoDoc doc,Rhino.DocObjects.RhinoObject obj) => throw new System.NotImplementedException();
	public static void DocumentBasedMeshesChanged(Rhino.RhinoDoc doc) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BoundingBox BoundingBox(Rhino.DocObjects.ViewportInfo vp,Rhino.DocObjects.RhinoObject obj,System.Guid requestingPlugIn,System.Boolean preview) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BoundingBox BoundingBox(Rhino.DocObjects.ViewportInfo vp,Rhino.DocObjects.RhinoObject obj,Rhino.RhinoDoc doc,System.Guid requestingPlugIn,Rhino.Display.DisplayPipelineAttributes attrs) => throw new System.NotImplementedException();
	public static  System.Guid EdgeSofteningId
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid DisplacementId
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid CurvePipingId
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid ShutLiningId
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid ThickeningId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String Name
	{
		get => throw new System.NotImplementedException();
	}
}
