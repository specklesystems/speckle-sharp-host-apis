namespace Autodesk.Revit.DB;

public partial class Connector : System.Object
{
	public virtual void ConnectTo(Autodesk.Revit.DB.Connector connector) => throw new System.NotImplementedException();
	public virtual void DisconnectFrom(Autodesk.Revit.DB.Connector connector) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FabricationConnectorInfo GetFabricationConnectorInfo() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.MEPConnectorInfo GetMEPConnectorInfo() => throw new System.NotImplementedException();
		public virtual Autodesk.Revit.DB.FlowDirectionType Direction
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
	public virtual Autodesk.Revit.DB.FlowDirectionType AssignedFlowDirection
	{
		get => throw new System.NotImplementedException();
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
