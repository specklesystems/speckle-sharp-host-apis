namespace Autodesk.Revit.DB;

public partial class Parameter : Autodesk.Revit.DB.APIObject
{
	public virtual Autodesk.Revit.DB.ForgeTypeId GetTypeId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ForgeTypeId GetUnitTypeId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId AsElementId() => throw new System.NotImplementedException();
	public virtual void AssociateWithGlobalParameter(Autodesk.Revit.DB.ElementId gpId) => throw new System.NotImplementedException();
	public virtual void DissociateFromGlobalParameter() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetAssociatedGlobalParameter() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId Id
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Element Element
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
