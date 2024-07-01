namespace Autodesk.Revit.DB.ExtensibleStorage;

public partial class Entity : System.Object
{
	public Entity(System.Guid schemaGUID) => throw new System.NotImplementedException();
	public Entity(Autodesk.Revit.DB.ExtensibleStorage.Schema schema) => throw new System.NotImplementedException();
	public Entity(Autodesk.Revit.DB.ExtensibleStorage.Entity other) => throw new System.NotImplementedException();
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
