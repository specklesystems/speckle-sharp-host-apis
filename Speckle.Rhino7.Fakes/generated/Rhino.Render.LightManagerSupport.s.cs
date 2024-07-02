namespace Rhino.Render;

public partial class LightManagerSupport
{
	public LightManagerSupport() {}
	public static void RegisterProviders(System.Reflection.Assembly assembly,System.Guid pluginId) => throw new System.NotImplementedException();
	public virtual System.Guid PluginId() => throw new System.NotImplementedException();
	public virtual System.Guid RenderEngineId() => throw new System.NotImplementedException();
	public virtual void ModifyLight(Rhino.RhinoDoc doc,Rhino.Geometry.Light light) => throw new System.NotImplementedException();
	public virtual System.Boolean DeleteLight(Rhino.RhinoDoc doc,Rhino.Geometry.Light light,System.Boolean bUndelete) => throw new System.NotImplementedException();
	public virtual System.Boolean SetLightSolo(Rhino.RhinoDoc doc,System.Guid uuid_light,System.Boolean bSolo) => throw new System.NotImplementedException();
	public virtual System.Boolean GetLightSolo(Rhino.RhinoDoc doc,System.Guid uuid_light) => throw new System.NotImplementedException();
	public virtual System.Int32 LightsInSoloStorage(Rhino.RhinoDoc doc) => throw new System.NotImplementedException();
}
