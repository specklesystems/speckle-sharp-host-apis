namespace Autodesk.Revit.DB;

public partial class MEPAnalyticalConnection : Autodesk.Revit.DB.MEPCurve
{
	public MEPAnalyticalConnection() {}
	public static Autodesk.Revit.DB.MEPAnalyticalConnection Create(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.ElementId typeId,Autodesk.Revit.DB.Connector startConnector,Autodesk.Revit.DB.Connector endConnector) => throw new System.NotImplementedException();
	public static System.Boolean CanSupportAnalyticalConnection(Autodesk.Revit.DB.Connector connector) => throw new System.NotImplementedException();
	public static System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> CreateMultipleConnections(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.ElementId typeId,System.Collections.Generic.IList<Autodesk.Revit.DB.Connector> equipmentOpenConnectors,System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> curveIdsToConnect) => throw new System.NotImplementedException();
	public virtual System.Double GetFlow() => throw new System.NotImplementedException();
}
