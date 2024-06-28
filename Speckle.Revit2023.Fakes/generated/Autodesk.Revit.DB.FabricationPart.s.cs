namespace Autodesk.Revit.DB;

public partial class FabricationPart : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.GeometryElement GetInsulationLiningGeometry() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FabricationHostedInfo GetHostedInfo() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FabricationRodInfo GetRodInfo() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform GetTransform() => throw new System.NotImplementedException();
	public virtual void SetPositionByEnd(Autodesk.Revit.DB.Connector connector,Autodesk.Revit.DB.XYZ position) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId SplitStraight(Autodesk.Revit.DB.XYZ position) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId SplitStraight(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId partId,Autodesk.Revit.DB.XYZ position) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ConnectorManager ConnectorManager
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ConnectorDomainType DomainType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ Origin
	{
		get => throw new System.NotImplementedException();
	}
}
