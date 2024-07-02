namespace Autodesk.Revit.DB.ExtensibleStorage;

public partial class FieldBuilder : System.IDisposable
{
	public FieldBuilder() {}
	public FieldBuilder(Autodesk.Revit.DB.ExtensibleStorage.Field field,Autodesk.Revit.DB.ExtensibleStorage.SchemaBuilder builder) => throw new System.NotImplementedException();
	public FieldBuilder(Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder other) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder SetSpec(Autodesk.Revit.DB.ForgeTypeId specTypeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder SetSubSchemaGUID(System.Guid guid) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExtensibleStorage.FieldBuilder SetDocumentation(System.String documentation) => throw new System.NotImplementedException();
	public virtual System.Boolean Ready() => throw new System.NotImplementedException();
	public virtual System.Boolean NeedsUnits() => throw new System.NotImplementedException();
	public virtual System.Boolean NeedsSubSchemaGUID() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}
