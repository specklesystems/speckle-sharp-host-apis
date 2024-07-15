namespace Autodesk.Revit.DB.Electrical;

public partial class AnalyticalEquipmentLoadData : Autodesk.Revit.DB.Electrical.AnalyticalDistributionNodePropertyData
{
	public AnalyticalEquipmentLoadData() {}
	public virtual Autodesk.Revit.DB.Electrical.ElectricalLoadType LoadType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double TrueLoad
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double PowerFactor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Current
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Voltage
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ApparentLoad
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId LoadSet
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId LoadClassification
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
