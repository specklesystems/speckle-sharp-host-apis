namespace Autodesk.Revit.DB.ExtensibleStorage;

public partial class Entity : System.IDisposable
{
	public Entity() {}
	public Entity(System.Guid schemaGUID) => throw new System.NotImplementedException();
	public Entity(Autodesk.Revit.DB.ExtensibleStorage.Schema schema) => throw new System.NotImplementedException();
	public Entity(Autodesk.Revit.DB.ExtensibleStorage.Entity other) => throw new System.NotImplementedException();
	public virtual FieldType Get<FieldType>(System.String fieldName,Autodesk.Revit.DB.ForgeTypeId unitTypeId) => throw new System.NotImplementedException();
	public virtual FieldType Get<FieldType>(Autodesk.Revit.DB.ExtensibleStorage.Field field,Autodesk.Revit.DB.ForgeTypeId unitTypeId) => throw new System.NotImplementedException();
	public virtual FieldType Get<FieldType>(System.String fieldName) => throw new System.NotImplementedException();
	public virtual FieldType Get<FieldType>(Autodesk.Revit.DB.ExtensibleStorage.Field field) => throw new System.NotImplementedException();
	public virtual void Set<FieldType>(System.String fieldName,FieldType value,Autodesk.Revit.DB.ForgeTypeId unitTypeId) => throw new System.NotImplementedException();
	public virtual void Set<FieldType>(Autodesk.Revit.DB.ExtensibleStorage.Field field,FieldType value,Autodesk.Revit.DB.ForgeTypeId unitTypeId) => throw new System.NotImplementedException();
	public virtual void Set<FieldType>(System.String fieldName,FieldType value) => throw new System.NotImplementedException();
	public virtual void Set<FieldType>(Autodesk.Revit.DB.ExtensibleStorage.Field field,FieldType value) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValid() => throw new System.NotImplementedException();
	public virtual System.Boolean ReadAccessGranted() => throw new System.NotImplementedException();
	public virtual System.Boolean WriteAccessGranted() => throw new System.NotImplementedException();
	public virtual System.Boolean RecognizedField(Autodesk.Revit.DB.ExtensibleStorage.Field field) => throw new System.NotImplementedException();
	public virtual void Clear(System.String fieldName) => throw new System.NotImplementedException();
	public virtual void Clear(Autodesk.Revit.DB.ExtensibleStorage.Field field) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid SchemaGUID
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ExtensibleStorage.Schema Schema
	{
		get => throw new System.NotImplementedException();
	}
}
