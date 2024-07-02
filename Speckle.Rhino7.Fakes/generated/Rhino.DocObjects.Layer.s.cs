namespace Rhino.DocObjects;

public partial class Layer : Rhino.DocObjects.ModelComponent,System.IEquatable<Rhino.DocObjects.Layer>
{
	public Layer() {}
	public static Rhino.DocObjects.Layer GetDefaultLayerProperties() => throw new System.NotImplementedException();
	public virtual System.Boolean CommitChanges() => throw new System.NotImplementedException();
	public virtual System.Boolean HasPerViewportSettings(System.Guid viewportId) => throw new System.NotImplementedException();
	public virtual void DeletePerViewportSettings(System.Guid viewportId) => throw new System.NotImplementedException();
	public virtual void DeletePerViewportColor(System.Guid viewportId) => throw new System.NotImplementedException();
	public virtual void DeletePerViewportPlotColor(System.Guid viewportId) => throw new System.NotImplementedException();
	public virtual System.Double PerViewportPlotWeight(System.Guid viewportId) => throw new System.NotImplementedException();
	public virtual void SetPerViewportPlotWeight(System.Guid viewportId,System.Double plotWeight) => throw new System.NotImplementedException();
	public virtual void DeletePerViewportPlotWeight(System.Guid viewportId) => throw new System.NotImplementedException();
	public virtual System.Boolean PerViewportIsVisible(System.Guid viewportId) => throw new System.NotImplementedException();
	public virtual void SetPerViewportVisible(System.Guid viewportId,System.Boolean visible) => throw new System.NotImplementedException();
	public virtual void DeletePerViewportVisible(System.Guid viewportId) => throw new System.NotImplementedException();
	public virtual System.Boolean PerViewportPersistentVisibility(System.Guid viewportId) => throw new System.NotImplementedException();
	public virtual void SetPerViewportPersistentVisibility(System.Guid viewportId,System.Boolean persistentVisibility) => throw new System.NotImplementedException();
	public virtual void UnsetPerViewportPersistentVisibility(System.Guid viewportId) => throw new System.NotImplementedException();
	public virtual System.Boolean GetPersistentVisibility() => throw new System.NotImplementedException();
	public virtual void SetPersistentVisibility(System.Boolean persistentVisibility) => throw new System.NotImplementedException();
	public virtual void UnsetPersistentVisibility() => throw new System.NotImplementedException();
	public virtual System.Boolean GetPersistentLocking() => throw new System.NotImplementedException();
	public virtual void SetPersistentLocking(System.Boolean persistentLocking) => throw new System.NotImplementedException();
	public virtual void UnsetPersistentLocking() => throw new System.NotImplementedException();
	public virtual void Default() => throw new System.NotImplementedException();
	public virtual void CopyAttributesFrom(Rhino.DocObjects.Layer otherLayer) => throw new System.NotImplementedException();
	public static System.Boolean IsValidName(System.String name) => throw new System.NotImplementedException();
	public static System.String GetLeafName(System.String fullPath) => throw new System.NotImplementedException();
	public static System.String GetLeafName(Rhino.DocObjects.Layer layer) => throw new System.NotImplementedException();
	public static System.String GetParentName(System.String fullPath) => throw new System.NotImplementedException();
	public static System.String GetParentName(Rhino.DocObjects.Layer layer) => throw new System.NotImplementedException();
	public virtual System.Boolean IsChildOf(System.Int32 layerIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean IsChildOf(Rhino.DocObjects.Layer otherLayer) => throw new System.NotImplementedException();
	public virtual System.Boolean IsChildOf(System.Guid otherlayerId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsParentOf(System.Int32 layerIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean IsParentOf(Rhino.DocObjects.Layer otherLayer) => throw new System.NotImplementedException();
	public virtual System.Boolean IsParentOf(System.Guid otherLayer) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.Layer GetChildren() => throw new System.NotImplementedException();
	public virtual System.Boolean SetUserString(System.String key,System.String value) => throw new System.NotImplementedException();
	public virtual System.String GetUserString(System.String key) => throw new System.NotImplementedException();
	public virtual System.Collections.Specialized.NameValueCollection GetUserStrings() => throw new System.NotImplementedException();
	public virtual System.Boolean Equals(Rhino.DocObjects.Layer other) => throw new System.NotImplementedException();
	public new System.String Name
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String FullPath
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 LayerIndex
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public new System.Guid Id
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Guid ParentLayerId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 IgesLevel
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double PlotWeight
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 LinetypeIndex
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 RenderMaterialIndex
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsVisible
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsLocked
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public new Rhino.DocObjects.ModelComponentType ComponentType
	{
		get => throw new System.NotImplementedException();
	}
	public new Rhino.Geometry.ComponentStatus ComponentStatus
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsExpanded
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsDeleted
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsReference
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RenderMaterial RenderMaterial
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 SortIndex
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.String PathSeparator
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 UserStringCount
	{
		get => throw new System.NotImplementedException();
	}
}
