namespace Rhino.Render;

public partial class LightManagerSupportClient : System.IDisposable
{
	public LightManagerSupportClient() {}
	public LightManagerSupportClient(System.UInt32 doc_uuid) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual Rhino.Render.LightArray GetLights() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Light GetLightFromId(System.Guid uuid) => throw new System.NotImplementedException();
	public virtual void OnEditLight(Rhino.Render.LightArray lights) => throw new System.NotImplementedException();
	public virtual void GroupLights(Rhino.Render.LightArray lights) => throw new System.NotImplementedException();
	public virtual void UnGroup(Rhino.Render.LightArray lights) => throw new System.NotImplementedException();
	public virtual void ModifyLight(Rhino.Geometry.Light light) => throw new System.NotImplementedException();
	public virtual void DeleteLight(Rhino.Geometry.Light light) => throw new System.NotImplementedException();
	public virtual System.String LightDescription(Rhino.Geometry.Light light) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.RhinoObject ObjectFromLight(Rhino.Geometry.Light light) => throw new System.NotImplementedException();
	public virtual System.Boolean SetLightSolo(Rhino.Geometry.Light light,System.Boolean bSolo) => throw new System.NotImplementedException();
	public virtual System.Boolean GetLightSolo(Rhino.Geometry.Light light) => throw new System.NotImplementedException();
	public virtual System.Int32 LightsInSoloStorage() => throw new System.NotImplementedException();
	public virtual System.IntPtr CppPointer
	{
		get => throw new System.NotImplementedException();
	}
}
