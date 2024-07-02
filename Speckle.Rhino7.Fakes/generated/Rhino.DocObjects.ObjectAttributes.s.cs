namespace Rhino.DocObjects;

public partial class ObjectAttributes : Rhino.Runtime.CommonObject
{
	public ObjectAttributes() {}
	public virtual Rhino.DocObjects.ObjectAttributes Duplicate() => throw new System.NotImplementedException();
	public virtual System.Boolean Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public virtual System.Boolean HasDisplayModeOverride(System.Guid viewportId) => throw new System.NotImplementedException();
	public virtual System.Guid GetDisplayModeOverride(System.Guid viewportId) => throw new System.NotImplementedException();
	public virtual void RemoveDisplayModeOverride() => throw new System.NotImplementedException();
	public virtual void RemoveDisplayModeOverride(System.Guid rhinoViewportId) => throw new System.NotImplementedException();
	public virtual System.Boolean AddHideInDetailOverride(System.Guid detailId) => throw new System.NotImplementedException();
	public virtual System.Boolean RemoveHideInDetailOverride(System.Guid detailId) => throw new System.NotImplementedException();
	public virtual System.Boolean HasHideInDetailOverrideSet(System.Guid detailId) => throw new System.NotImplementedException();
	public virtual System.Guid[] GetHideInDetailOverrides() => throw new System.NotImplementedException();
	public virtual System.Double ComputedPlotWeight(Rhino.RhinoDoc document) => throw new System.NotImplementedException();
	public virtual System.Double ComputedPlotWeight(Rhino.RhinoDoc document,System.Guid viewportId) => throw new System.NotImplementedException();
	public virtual System.Int32[] GetGroupList() => throw new System.NotImplementedException();
	public virtual void AddToGroup(System.Int32 groupIndex) => throw new System.NotImplementedException();
	public virtual void RemoveFromGroup(System.Int32 groupIndex) => throw new System.NotImplementedException();
	public virtual void RemoveFromAllGroups() => throw new System.NotImplementedException();
	public virtual System.Boolean SetUserString(System.String key,System.String value) => throw new System.NotImplementedException();
	public virtual System.String GetUserString(System.String key) => throw new System.NotImplementedException();
	public virtual System.Collections.Specialized.NameValueCollection GetUserStrings() => throw new System.NotImplementedException();
	public virtual System.Boolean DeleteUserString(System.String key) => throw new System.NotImplementedException();
	public virtual void DeleteAllUserStrings() => throw new System.NotImplementedException();
	public override System.Boolean IsDocumentControlled
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.ObjectMode Mode
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsInstanceDefinitionObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Visible
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean CastsShadows
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ReceivesShadows
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.ObjectLinetypeSource LinetypeSource
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.ObjectColorSource ColorSource
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.ObjectPlotColorSource PlotColorSource
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.ObjectPlotWeightSource PlotWeightSource
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.MeshingParameters CustomMeshingParameters
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Guid ObjectId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String Name
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String Url
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 LayerIndex
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 LinetypeIndex
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 MaterialIndex
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.ObjectMaterialSource MaterialSource
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Render.RenderMaterial RenderMaterial
	{
		set {}
	}
	public virtual Rhino.Render.Decals Decals
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.MaterialRefs MaterialRefs
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean HasMapping
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 DisplayOrder
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double PlotWeight
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.ObjectDecoration ObjectDecoration
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 WireDensity
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Guid ViewportId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.ActiveSpace Space
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 GroupCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 UserStringCount
	{
		get => throw new System.NotImplementedException();
	}
}
