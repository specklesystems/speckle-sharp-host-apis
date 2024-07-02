namespace Autodesk.Revit.DB.Mechanical;

public partial class MechanicalSystem : Autodesk.Revit.DB.MEPSystem
{
	public MechanicalSystem() {}
	public virtual System.Boolean IsPressureDropServerMissing() => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Mechanical.MechanicalSystem Create(Autodesk.Revit.DB.Document ADocument,Autodesk.Revit.DB.ElementId typeId,System.String name) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Mechanical.MechanicalSystem Create(Autodesk.Revit.DB.Document ADocument,Autodesk.Revit.DB.ElementId typeId) => throw new System.NotImplementedException();
	public virtual System.Double GetFlow() => throw new System.NotImplementedException();
	public virtual System.Double GetStaticPressure() => throw new System.NotImplementedException();
	public virtual System.Boolean IsWellConnected
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementSet DuctNetwork
	{
		get => throw new System.NotImplementedException();
	}
	public new Autodesk.Revit.DB.Connector BaseEquipmentConnector
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Mechanical.DuctSystemType SystemType
	{
		get => throw new System.NotImplementedException();
	}
}
