namespace Autodesk.Revit.DB;

public partial class Parameter : Autodesk.Revit.DB.APIObject
{
	public virtual Autodesk.Revit.DB.ForgeTypeId GetTypeId() => throw new System.NotImplementedException();
	public virtual System.String AsValueString(Autodesk.Revit.DB.FormatOptions formatOptions) => throw new System.NotImplementedException();
	public virtual System.String AsValueString() => throw new System.NotImplementedException();
	public virtual System.Boolean SetValueString(System.String valueString) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ForgeTypeId GetUnitTypeId() => throw new System.NotImplementedException();
	public virtual System.String AsString() => throw new System.NotImplementedException();
	public virtual System.Int32 AsInteger() => throw new System.NotImplementedException();
	public virtual System.Double AsDouble() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId AsElementId() => throw new System.NotImplementedException();
	public virtual System.Boolean Set(Autodesk.Revit.DB.ElementId value) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.Double value) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.Int32 value) => throw new System.NotImplementedException();
	public virtual System.Boolean Set(System.String value) => throw new System.NotImplementedException();
	public virtual System.Boolean ClearValue() => throw new System.NotImplementedException();
	public virtual void AssociateWithGlobalParameter(Autodesk.Revit.DB.ElementId gpId) => throw new System.NotImplementedException();
	public virtual void DissociateFromGlobalParameter() => throw new System.NotImplementedException();
	public virtual System.Boolean CanBeAssociatedWithGlobalParameter(Autodesk.Revit.DB.ElementId gpId) => throw new System.NotImplementedException();
	public virtual System.Boolean CanBeAssociatedWithGlobalParameters() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetAssociatedGlobalParameter() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId Id
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid GUID
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsShared
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Element Element
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean HasValue
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean UserModifiable
	{
		get => throw new System.NotImplementedException();
	}
	public new System.Boolean IsReadOnly
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.StorageType StorageType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Definition Definition
	{
		get => throw new System.NotImplementedException();
	}
}
