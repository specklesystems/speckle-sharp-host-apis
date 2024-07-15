namespace Autodesk.Revit.DB;

public partial class MEPModel : Autodesk.Revit.DB.APIObject
{
	public MEPModel() {}
	public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.Electrical.ElectricalSystem> GetElectricalSystems() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.Electrical.ElectricalSystem> GetAssignedElectricalSystems() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ConnectorManager ConnectorManager
	{
		get => throw new System.NotImplementedException();
	}
}
