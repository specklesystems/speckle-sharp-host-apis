namespace Autodesk.Revit.DB.Mechanical;

public partial class Space : Autodesk.Revit.DB.SpatialElement
{
	public Space() {}
	public virtual System.Boolean IsPointInSpace(Autodesk.Revit.DB.XYZ point) => throw new System.NotImplementedException();
	public virtual System.Boolean Plenum
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Occupiable
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double DesignPowerLoad
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ActualPowerLoad
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.BaseLoadOn PowerLoadUnit
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double DesignLightingLoad
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ActualLightingLoad
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.BaseLoadOn LightingLoadUnit
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double LatentHeatGainperPerson
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double SensibleHeatGainperPerson
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double AreaperPerson
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double NumberofPeople
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.BaseLoadOn BaseHeatLoadOn
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Mechanical.OccupancyUnit OccupancyUnit
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double DesignCoolingLoad
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double CalculatedCoolingLoad
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double DesignHeatingLoad
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double CalculatedHeatingLoad
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Mechanical.MEPSpaceConstruction SpaceConstruction
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId SpaceTypeId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Mechanical.SpaceType SpaceType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Mechanical.ConditionType ConditionType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Volume
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double UnboundedHeight
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Analysis.OutdoorAirFlowStandard OutdoorAirFlowStandard
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double OutdoorAirflow
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double AirChangesPerHour
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double OutdoorAirPerArea
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double OutdoorAirPerPerson
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double ActualExhaustAirflow
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double DesignExhaustAirflow
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ActualReturnAirflow
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double DesignReturnAirflow
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Mechanical.ReturnAirflowType ReturnAirflow
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ActualSupplyAirflow
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double CalculatedSupplyAirflow
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double DesignSupplyAirflow
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ActualOtherLoad
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double DesignOtherLoadperArea
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ActualHVACLoad
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double DesignHVACLoadperArea
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double FloorReflectance
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double WallReflectance
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double CeilingReflectance
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double LightingCalculationWorkplane
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double SpaceCavityRatio
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double AverageEstimatedIllumination
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double BaseOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double LimitOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Level UpperLimit
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Architecture.Room Room
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.GeometryElement ClosedShell
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Mechanical.Zone Zone
	{
		get => throw new System.NotImplementedException();
	}
}
