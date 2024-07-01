namespace Autodesk.Revit.DB.ExtensibleStorage;

public partial class SchemaBuilder : System.Object
{
	public SchemaBuilder(System.Guid guid) => throw new System.NotImplementedException();
	public static System.Boolean GUIDIsValid(System.Guid guid) => throw new System.NotImplementedException();
	public static System.Boolean VendorIdIsValid(System.String vendorId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder AddSimpleField(System.String fieldName,System.Type fieldType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder AddArrayField(System.String fieldName,System.Type fieldType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder AddMapField(System.String fieldName,System.Type keyType,System.Type valueType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder SetReadAccessLevel(Autodesk.Revit.DB.ExtensibleStorage.AccessLevel readAccessLevel) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder SetWriteAccessLevel(Autodesk.Revit.DB.ExtensibleStorage.AccessLevel writeAccessLevel) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder SetSchemaName(System.String schemaName) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder SetDocumentation(System.String documentation) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder SetApplicationGUID(System.Guid applicationGUID) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder SetVendorId(System.String vendorId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExtensibleStorage.Schema Finish() => throw new System.NotImplementedException();
	public virtual System.Boolean Ready() => throw new System.NotImplementedException();
	public virtual System.Boolean AcceptableName(System.String name) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}
