namespace Autodesk.Revit.DB.ExtensibleStorage;

public partial class Field : System.IDisposable
{
	public virtual System.Boolean CompatibleUnit(Autodesk.Revit.DB.ForgeTypeId unitTypeId) => throw new System.NotImplementedException();
	public virtual System.Boolean SubEntityReadAccessGranted() => throw new System.NotImplementedException();
	public virtual System.Boolean SubEntityWriteAccessGranted() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ForgeTypeId GetSpecTypeId() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ExtensibleStorage.Schema SubSchema
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Type KeyType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Type ValueType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String Documentation
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ExtensibleStorage.ContainerType ContainerType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid SubSchemaGUID
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ExtensibleStorage.Schema Schema
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String FieldName
	{
		get => throw new System.NotImplementedException();
	}
}
