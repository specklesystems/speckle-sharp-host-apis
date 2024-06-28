namespace Autodesk.Revit.DB;

public partial class MEPSystem : Autodesk.Revit.DB.Element
{
	public virtual void Add(Autodesk.Revit.DB.ConnectorSet connectors) => throw new System.NotImplementedException();
	public virtual void Remove(Autodesk.Revit.DB.ConnectorSet connectors) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Connector BaseEquipmentConnector
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.FamilyInstance BaseEquipment
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementSet Elements
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ConnectorManager ConnectorManager
	{
		get => throw new System.NotImplementedException();
	}
}
