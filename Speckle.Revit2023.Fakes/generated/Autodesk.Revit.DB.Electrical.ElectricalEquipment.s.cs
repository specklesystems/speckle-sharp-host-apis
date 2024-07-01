namespace Autodesk.Revit.DB.Electrical;

public partial class ElectricalEquipment : Autodesk.Revit.DB.MEPModel
{
	public virtual System.Boolean IsValidDistributionSystem(Autodesk.Revit.DB.Electrical.DistributionSysType distributionSystem) => throw new System.NotImplementedException();
	public static System.Boolean IsValidCircuitNamingSchemeId(Autodesk.Revit.DB.Document aDocument,Autodesk.Revit.DB.ElementId circuitNamingSchemeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Electrical.CircuitNaming GetCircuitNamingSchemeType() => throw new System.NotImplementedException();
	public virtual void SetCircuitNamingSchemeType(Autodesk.Revit.DB.Electrical.CircuitNaming circuitNamingType) => throw new System.NotImplementedException();
	public virtual System.Boolean IsSwitchboard
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 MaxNumberOfCircuits
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId CircuitNamingSchemeId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Electrical.DistributionSysType DistributionSystem
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
