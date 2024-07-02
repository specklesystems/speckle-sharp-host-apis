namespace Rhino.DocObjects;

public partial class RhinoObject : Rhino.DocObjects.ModelComponent
{
	public RhinoObject() {}
	public virtual System.Boolean CopyHistoryOnReplace() => throw new System.NotImplementedException();
	public virtual System.Boolean HasHistoryRecord() => throw new System.NotImplementedException();
	public static Rhino.DocObjects.RhinoObject FromRuntimeSerialNumber(System.UInt32 serialNumber) => throw new System.NotImplementedException();
	public static Rhino.DocObjects.ObjRef[] GetRenderMeshes(System.Collections.Generic.IEnumerable<Rhino.DocObjects.RhinoObject> rhinoObjects,System.Boolean okToCreate,System.Boolean returnAllObjects) => throw new System.NotImplementedException();
	public static Rhino.DocObjects.ObjRef[] GetRenderMeshesWithUpdatedTCs(System.Collections.Generic.IEnumerable<Rhino.DocObjects.RhinoObject> rhinoObjects,System.Boolean okToCreate,System.Boolean returnAllObjects,System.Boolean skipHiddenObjects,System.Boolean updateMeshTCs) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] GetFillSurfaces(Rhino.DocObjects.RhinoObject rhinoObject,Rhino.DocObjects.ClippingPlaneObject clippingPlaneObject) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] GetFillSurfaces(Rhino.DocObjects.RhinoObject rhinoObject,System.Collections.Generic.IEnumerable<Rhino.DocObjects.ClippingPlaneObject> clippingPlaneObjects) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Brep[] GetFillSurfaces(Rhino.DocObjects.RhinoObject rhinoObject,System.Collections.Generic.IEnumerable<Rhino.DocObjects.ClippingPlaneObject> clippingPlaneObjects,System.Boolean unclippedFills) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.GeometryBase DuplicateGeometry() => throw new System.NotImplementedException();
	public virtual System.Boolean CommitChanges() => throw new System.NotImplementedException();
	public virtual System.UInt32 MemoryEstimate() => throw new System.NotImplementedException();
	public virtual System.Int32[] GetGroupList() => throw new System.NotImplementedException();
	public virtual System.Int32 IsSelected(System.Boolean checkSubObjects) => throw new System.NotImplementedException();
	public virtual System.Boolean IsSubObjectSelected(Rhino.Geometry.ComponentIndex componentIndex) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.ComponentIndex[] GetSelectedSubObjects() => throw new System.NotImplementedException();
	public virtual System.Boolean IsSelectable(System.Boolean ignoreSelectionState,System.Boolean ignoreGripsState,System.Boolean ignoreLayerLocking,System.Boolean ignoreLayerVisibility) => throw new System.NotImplementedException();
	public virtual System.Boolean IsSelectable() => throw new System.NotImplementedException();
	public virtual System.Boolean IsSubObjectSelectable(Rhino.Geometry.ComponentIndex componentIndex,System.Boolean ignoreSelectionState) => throw new System.NotImplementedException();
	public virtual System.Int32 Select(System.Boolean on,System.Boolean syncHighlight,System.Boolean persistentSelect,System.Boolean ignoreGripsState,System.Boolean ignoreLayerLocking,System.Boolean ignoreLayerVisibility) => throw new System.NotImplementedException();
	public virtual System.Int32 Select(System.Boolean on) => throw new System.NotImplementedException();
	public virtual System.Int32 Select(System.Boolean on,System.Boolean syncHighlight) => throw new System.NotImplementedException();
	public virtual System.Int32 SelectSubObject(Rhino.Geometry.ComponentIndex componentIndex,System.Boolean select,System.Boolean syncHighlight) => throw new System.NotImplementedException();
	public virtual System.Int32 SelectSubObject(Rhino.Geometry.ComponentIndex componentIndex,System.Boolean select,System.Boolean syncHighlight,System.Boolean persistentSelect) => throw new System.NotImplementedException();
	public virtual System.Int32 UnselectAllSubObjects() => throw new System.NotImplementedException();
	public virtual System.Int32 IsHighlighted(System.Boolean checkSubObjects) => throw new System.NotImplementedException();
	public virtual System.Boolean Highlight(System.Boolean enable) => throw new System.NotImplementedException();
	public virtual System.Boolean IsSubObjectHighlighted(Rhino.Geometry.ComponentIndex componentIndex) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.ComponentIndex[] GetHighlightedSubObjects() => throw new System.NotImplementedException();
	public virtual System.Boolean HighlightSubObject(Rhino.Geometry.ComponentIndex componentIndex,System.Boolean highlight) => throw new System.NotImplementedException();
	public virtual System.Int32 UnhighlightAllSubObjects() => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.GripObject[] GetGrips() => throw new System.NotImplementedException();
	public virtual System.Boolean InVisualAnalysisMode() => throw new System.NotImplementedException();
	public virtual System.String ShortDescription(System.Boolean plural) => throw new System.NotImplementedException();
	public virtual System.Boolean IsMeshable(Rhino.Geometry.MeshType meshType) => throw new System.NotImplementedException();
	public virtual System.Boolean SetRenderMeshParameters(Rhino.Geometry.MeshingParameters mp) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.MeshingParameters GetRenderMeshParameters() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.MeshingParameters GetRenderMeshParameters(System.Boolean returnDocumentParametersIfUnset) => throw new System.NotImplementedException();
	public virtual System.Int32 MeshCount(Rhino.Geometry.MeshType meshType,Rhino.Geometry.MeshingParameters parameters) => throw new System.NotImplementedException();
	public virtual System.Int32 CreateMeshes(Rhino.Geometry.MeshType meshType,Rhino.Geometry.MeshingParameters parameters,System.Boolean ignoreCustomParameters) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Mesh[] GetMeshes(Rhino.Geometry.MeshType meshType) => throw new System.NotImplementedException();
	public virtual System.Boolean SupportsRenderPrimitiveList(Rhino.DocObjects.ViewportInfo viewport,System.Boolean preview) => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderPrimitiveList GetRenderPrimitiveList(Rhino.DocObjects.ViewportInfo viewport,System.Boolean preview) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.RhinoObject[] GetSubObjects() => throw new System.NotImplementedException();
	public virtual Rhino.Render.TextureMapping GetTextureMapping(System.Int32 channel) => throw new System.NotImplementedException();
	public virtual System.Int32 SetTextureMapping(System.Int32 channel,Rhino.Render.TextureMapping tm) => throw new System.NotImplementedException();
	public virtual System.Int32 SetTextureMapping(System.Int32 channel,Rhino.Render.TextureMapping tm,Rhino.Geometry.Transform objectTransform) => throw new System.NotImplementedException();
	public virtual System.Boolean HasTextureMapping() => throw new System.NotImplementedException();
	public virtual System.Int32[] GetTextureChannels() => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderMaterial GetRenderMaterial(System.Boolean frontMaterial) => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderMaterial GetRenderMaterial(Rhino.Geometry.ComponentIndex componentIndex,System.Guid plugInId,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderMaterial GetRenderMaterial(Rhino.Geometry.ComponentIndex componentIndex,System.Guid plugInId) => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderMaterial GetRenderMaterial(Rhino.Geometry.ComponentIndex componentIndex) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.Material GetMaterial(System.Boolean frontMaterial) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.Material GetMaterial(Rhino.Geometry.ComponentIndex componentIndex,System.Guid plugInId,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.Material GetMaterial(Rhino.Geometry.ComponentIndex componentIndex,System.Guid plugInId) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.Material GetMaterial(Rhino.Geometry.ComponentIndex componentIndex) => throw new System.NotImplementedException();
	public virtual System.IConvertible GetCustomRenderMeshParameter(System.Guid providerId,System.String parameterName) => throw new System.NotImplementedException();
	public virtual void SetCustomRenderMeshParameter(System.Guid providerId,System.String parameterName,System.Object value) => throw new System.NotImplementedException();
	public virtual void SetCopyHistoryOnReplace(System.Boolean bCopy) => throw new System.NotImplementedException();
	public static  System.UInt32 NextRuntimeSerialNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.ObjectType ObjectType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.RhinoDoc Document
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.GeometryBase Geometry
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.ObjectAttributes Attributes
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.UInt32 RuntimeSerialNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsSolid
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsDeletable
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsDeleted
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsInstanceDefinitionGeometry
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsNormal
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsLocked
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsHidden
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsReference
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.UInt32 WorksessionReferenceSerialNumber
	{
		get => throw new System.NotImplementedException();
	}
	public new System.UInt32 ReferenceModelSerialNumber
	{
		get => throw new System.NotImplementedException();
	}
	public new System.UInt32 InstanceDefinitionModelSerialNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Visible
	{
		get => throw new System.NotImplementedException();
	}
	public new System.Guid Id
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public new System.String Name
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 GroupCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean GripsOn
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean GripsSelected
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsPictureFrame
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean HasDynamicTransform
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RenderMaterial RenderMaterial
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean HasSubobjectMaterials
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.ComponentIndex[] SubobjectMaterialComponents
	{
		get => throw new System.NotImplementedException();
	}
	public new Rhino.DocObjects.ModelComponentType ComponentType
	{
		get => throw new System.NotImplementedException();
	}
}
