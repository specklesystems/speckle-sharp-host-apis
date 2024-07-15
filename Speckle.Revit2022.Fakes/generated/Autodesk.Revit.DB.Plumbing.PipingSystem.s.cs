namespace Autodesk.Revit.DB.Plumbing;

public partial class PipingSystem : Autodesk.Revit.DB.MEPSystem
{
	public PipingSystem() {}
	public virtual System.Boolean IsFlowServerMissing() => throw new System.NotImplementedException();
	public virtual System.Boolean IsPressureDropServerMissing() => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Plumbing.PipingSystem Create(Autodesk.Revit.DB.Document ADocument,Autodesk.Revit.DB.ElementId typeId,System.String name) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Plumbing.PipingSystem Create(Autodesk.Revit.DB.Document ADocument,Autodesk.Revit.DB.ElementId typeId) => throw new System.NotImplementedException();
	public virtual System.Double GetVolume() => throw new System.NotImplementedException();
	public virtual System.Double GetFlow() => throw new System.NotImplementedException();
	public virtual System.Double GetStaticPressure() => throw new System.NotImplementedException();
	public virtual System.Double GetFixtureUnits() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetPumpSets() => throw new System.NotImplementedException();
	public static System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> CreateHydraulicSeparation(Autodesk.Revit.DB.Document document,System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> pipeElementIds) => throw new System.NotImplementedException();
	public static void DeleteHydraulicSeparation(Autodesk.Revit.DB.Document document,System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> pipeElementIds) => throw new System.NotImplementedException();
	public static System.Boolean IsHydraulicLoopBoundary(Autodesk.Revit.DB.Element element) => throw new System.NotImplementedException();
	public static System.Boolean CanBeHydraulicLoopBoundary(Autodesk.Revit.DB.Element element) => throw new System.NotImplementedException();
	public virtual System.Boolean IsWellConnected
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementSet PipingNetwork
	{
		get => throw new System.NotImplementedException();
	}
	public new Autodesk.Revit.DB.Connector BaseEquipmentConnector
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Plumbing.PipeSystemType SystemType
	{
		get => throw new System.NotImplementedException();
	}
}
