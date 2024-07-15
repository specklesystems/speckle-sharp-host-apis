namespace Autodesk.Revit.DB.Electrical;

public partial class ElectricalAnalyticalNode : Autodesk.Revit.DB.Element
{
	public ElectricalAnalyticalNode() {}
	public static Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNode Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNodeType type,System.String name) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Electrical.AnalyticalDistributionNodePropertyData GetAnalyticalPropertyData() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetUpstreamNodeIds() => throw new System.NotImplementedException();
	public virtual void ConnectToUpstreamNode(Autodesk.Revit.DB.ElementId upstreamNodeId) => throw new System.NotImplementedException();
	public virtual void DisconnectFromUpstreamNode(Autodesk.Revit.DB.ElementId upstreamNodeId) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetDownstreamNodeIds() => throw new System.NotImplementedException();
	public virtual System.Boolean CanDisconnectFromUpstreamNode(Autodesk.Revit.DB.ElementId upstreamNodeId) => throw new System.NotImplementedException();
	public virtual System.Boolean CanConnectToUpstreamNode(Autodesk.Revit.DB.ElementId upstreamNodeId) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetAllDownstreamLoadIds() => throw new System.NotImplementedException();
	public virtual System.Double TotalLoad
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Electrical.ElectricalAnalyticalNodeType NodeType
	{
		get => throw new System.NotImplementedException();
	}
}
