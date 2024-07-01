namespace Autodesk.Revit.DB.Electrical;

public partial class AreaBasedLoadData : Autodesk.Revit.DB.Mechanical.ZoneElementDomainData
{
	public virtual void AddElectricalLoadArea(Autodesk.Revit.DB.ElementId electricalLoadAreaId) => throw new System.NotImplementedException();
	public virtual void RemoveElectricalLoadArea(Autodesk.Revit.DB.ElementId electricalLoadAreaId) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetElectricalLoadAreas() => throw new System.NotImplementedException();
	public virtual System.Double Current
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Voltage
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ApparentPowerDensity
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Electrical.ElectricalLoadType LoadType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double ApparentLoad
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double PowerFactor
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double TrueLoad
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId LoadClassification
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double LoadDensity
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId AreaBasedLoadType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 PhasesNumber
	{
		get => throw new System.NotImplementedException();
	}
}
