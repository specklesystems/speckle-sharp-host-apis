namespace Rhino.DocObjects;

public partial class InstanceDefinition : Rhino.Geometry.InstanceDefinitionGeometry
{
	public InstanceDefinition() {}
	public virtual Rhino.DocObjects.RhinoObject Object(System.Int32 index) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.RhinoObject[] GetObjects() => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.InstanceObject[] GetReferences(System.Int32 wheretoLook) => throw new System.NotImplementedException();
	public virtual System.Int32 UseCount() => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.InstanceDefinition[] GetContainers() => throw new System.NotImplementedException();
	public virtual System.Int32 UsesDefinition(System.Int32 otherIdefIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean InUse(System.Int32 wheretoLook) => throw new System.NotImplementedException();
	public virtual System.Int32 ObjectCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.InstanceDefinitionUpdateType UpdateType
	{
		get => throw new System.NotImplementedException();
	}
	public new System.Int32 Index
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsReference
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsTenuous
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean SkipNestedLinkedDefinitions
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.InstanceDefinitionLayerStyle LayerStyle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsDeleted
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.UnitSystem UnitSystem
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String SourceArchive
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.InstanceDefinitionArchiveFileStatus ArchiveFileStatus
	{
		get => throw new System.NotImplementedException();
	}
}
