namespace Autodesk.Revit.DB;

public partial class Connector : Autodesk.Revit.DB.IConnector,System.IDisposable
{
	public Connector() {}
	public virtual void ConnectTo(Autodesk.Revit.DB.Connector connector) => throw new System.NotImplementedException();
	public virtual void DisconnectFrom(Autodesk.Revit.DB.Connector connector) => throw new System.NotImplementedException();
	public virtual System.Boolean IsConnectedTo(Autodesk.Revit.DB.Connector connector) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FabricationConnectorInfo GetFabricationConnectorInfo() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.MEPConnectorInfo GetMEPConnectorInfo() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double PressureDrop
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Coefficient
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double VelocityPressure
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.FlowDirectionType Direction
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Flow
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 Id
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String Description
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Utility
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean AllowsSlopeAdjustments
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double GasketLength
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double EngagementLength
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsMovable
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Angle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double AssignedKCoefficient
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double AssignedFixtureUnits
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double AssignedFlow
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double AssignedPressureDrop
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Plumbing.PipeLossMethodType AssignedPipeLossMethod
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Mechanical.DuctLossMethodType AssignedDuctLossMethod
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Mechanical.DuctFlowConfigurationType AssignedDuctFlowConfiguration
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Plumbing.PipeFlowConfigurationType AssignedPipeFlowConfiguration
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double AssignedLossCoefficient
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double AssignedFlowFactor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsConnected
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.MEPSystem MEPSystem
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ConnectorManager ConnectorManager
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Demand
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Plumbing.PipeSystemType PipeSystemType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Electrical.ElectricalSystemType ElectricalSystemType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Mechanical.DuctSystemType DuctSystemType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.FlowDirectionType AssignedFlowDirection
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Radius
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Height
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Width
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ConnectorProfileType Shape
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ConnectorType ConnectorType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ConnectorSet AllRefs
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Domain Domain
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Element Owner
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Transform CoordinateSystem
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ Origin
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
