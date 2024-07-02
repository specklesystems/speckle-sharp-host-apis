namespace Autodesk.Revit.DB.Electrical;

public partial class Wire : Autodesk.Revit.DB.MEPCurve
{
	public Wire() {}
	public static Autodesk.Revit.DB.Electrical.Wire Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId wireTypeId,Autodesk.Revit.DB.ElementId viewId,Autodesk.Revit.DB.Electrical.WiringType wiringType,System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> vertexPoints,Autodesk.Revit.DB.Connector startConnectorTo,Autodesk.Revit.DB.Connector endConnectorTo) => throw new System.NotImplementedException();
	public virtual void ConnectTo(Autodesk.Revit.DB.Connector startConnectorTo,Autodesk.Revit.DB.Connector endConnectorTo) => throw new System.NotImplementedException();
	public static System.Boolean AreVertexPointsValid(System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> vertexPoints,Autodesk.Revit.DB.Connector startConnector,Autodesk.Revit.DB.Connector endConnector) => throw new System.NotImplementedException();
	public virtual void AppendVertex(Autodesk.Revit.DB.XYZ vertexPoint) => throw new System.NotImplementedException();
	public virtual void InsertVertex(System.Int32 index,Autodesk.Revit.DB.XYZ vertexPoint) => throw new System.NotImplementedException();
	public virtual void RemoveVertex(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void SetVertex(System.Int32 index,Autodesk.Revit.DB.XYZ vertexPoint) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetVertex(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Boolean IsVertexPointValid(Autodesk.Revit.DB.XYZ vertexPoint) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetMEPSystems() => throw new System.NotImplementedException();
	public virtual System.Int32 NumberOfVertices
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 GroundConductorNum
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 NeutralConductorNum
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 HotConductorNum
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Electrical.WiringType WiringType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
