namespace Autodesk.Revit.DB;

public partial class Connector : System.Object
{
		public virtual void set_Origin(Autodesk.Revit.DB.XYZ origin) => throw new System.NotImplementedException();
		public virtual Autodesk.Revit.DB.Element get_Owner() => throw new System.NotImplementedException();
		public virtual Autodesk.Revit.DB.ConnectorSet get_AllRefs() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ConnectorType get_ConnectorType() => throw new System.NotImplementedException();
					public virtual Autodesk.Revit.DB.FlowDirectionType get_AssignedFlowDirection() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ConnectorManager get_ConnectorManager() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.MEPSystem get_MEPSystem() => throw new System.NotImplementedException();
	public virtual void ConnectTo(Autodesk.Revit.DB.Connector connector) => throw new System.NotImplementedException();
	public virtual void DisconnectFrom(Autodesk.Revit.DB.Connector connector) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FlowDirectionType get_Direction() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FabricationConnectorInfo GetFabricationConnectorInfo() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.MEPConnectorInfo GetMEPConnectorInfo() => throw new System.NotImplementedException();
	}
