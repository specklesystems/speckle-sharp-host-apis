namespace Autodesk.Revit.DB;

public partial class CustomFieldData : System.IDisposable
{
	public CustomFieldData() {}
	public virtual System.Guid GetCustomFieldId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ICustomFieldProperties GetCustomFieldProperties() => throw new System.NotImplementedException();
	public virtual void SetCustomFieldProperties(Autodesk.Revit.DB.ICustomFieldProperties customFieldProperties) => throw new System.NotImplementedException();
	public virtual System.String ValidateCustomFieldProperties(Autodesk.Revit.DB.ICustomFieldProperties customFieldProperties) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double DefaultRowHeightOnSheet
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String FieldName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String FieldTooltip
	{
		get => throw new System.NotImplementedException();
	}
}
