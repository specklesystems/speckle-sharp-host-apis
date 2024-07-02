namespace Autodesk.Revit.DB.Electrical;

public partial class ElectricalSystem : Autodesk.Revit.DB.MEPSystem
{
	public ElectricalSystem() {}
	public virtual System.Boolean AddToCircuit(Autodesk.Revit.DB.ElementSet components) => throw new System.NotImplementedException();
	public virtual void RemoveFromCircuit(Autodesk.Revit.DB.ElementSet components) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Electrical.WireSet NewWires(Autodesk.Revit.DB.View view,Autodesk.Revit.DB.Electrical.WiringType wiringType) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Electrical.ElectricalSystem Create(Autodesk.Revit.DB.Connector connector,Autodesk.Revit.DB.Electrical.ElectricalSystemType elecSysType) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Electrical.ElectricalSystem Create(Autodesk.Revit.DB.Document document,System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> electComponents,Autodesk.Revit.DB.Electrical.ElectricalSystemType elecSysType) => throw new System.NotImplementedException();
	public virtual void SelectPanel(Autodesk.Revit.DB.FamilyInstance panel) => throw new System.NotImplementedException();
	public virtual void DisconnectPanel() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> GetCircuitPath() => throw new System.NotImplementedException();
	public virtual void SetCircuitPath(System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> nodes) => throw new System.NotImplementedException();
	public virtual System.Boolean IsCircuitPathValid(System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> nodes) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Electrical.CircuitConnectionType CircuitConnectionType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Electrical.ElectricalCircuitPathMode CircuitPathMode
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean HasCustomCircuitPath
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsBasePanelFeedThroughLugsOccupied
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String PanelName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Electrical.CircuitType CircuitType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 GroundConductorsNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 NeutralConductorsNumber
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 HotConductorsNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 RunsNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean BalancedLoad
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 PolesNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 Ways
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String PhaseLabel
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String LoadClassificationAbbreviations
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String LoadClassifications
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Electrical.PowerFactorStateType PowerFactorState
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Electrical.ElectricalSystemType SystemType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double VoltageDrop
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double TrueCurrentPhaseC
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double TrueCurrentPhaseB
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double TrueCurrentPhaseA
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double TrueCurrent
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double ApparentCurrentPhaseC
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double ApparentCurrentPhaseB
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double ApparentCurrentPhaseA
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double ApparentCurrent
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Length
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Frame
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean HasPathOffset
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double PathOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Rating
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double TrueLoadPhaseC
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double TrueLoadPhaseB
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double TrueLoadPhaseA
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double TrueLoad
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double PowerFactor
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double ApparentLoadPhaseC
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double ApparentLoadPhaseB
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double ApparentLoadPhaseA
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double ApparentLoad
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Voltage
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String WireSizeString
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String LoadName
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Electrical.WireType WireType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String SlotIndex
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 StartSlot
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 CircuitNamingIndex
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String CircuitNumber
	{
		get => throw new System.NotImplementedException();
	}
}
