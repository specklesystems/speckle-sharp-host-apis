namespace Autodesk.Revit.DB.Electrical;

public partial class DistributionSysType : Autodesk.Revit.DB.ElementType
{
	public DistributionSysType() {}
	public virtual System.Boolean IsInUse
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Electrical.VoltageType VoltageLineToGround
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Electrical.VoltageType VoltageLineToLine
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 NumWires
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Electrical.ElectricalPhase ElectricalPhase
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Electrical.ElectricalPhaseConfiguration ElectricalPhaseConfiguration
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
