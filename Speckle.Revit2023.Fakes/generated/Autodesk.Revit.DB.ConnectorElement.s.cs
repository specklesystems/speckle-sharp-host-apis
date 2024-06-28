namespace Autodesk.Revit.DB;

public partial class ConnectorElement : Autodesk.Revit.DB.Element
{
								public virtual Autodesk.Revit.DB.MEPSystemClassification get_SystemClassification() => throw new System.NotImplementedException();
	public virtual void set_SystemClassification(Autodesk.Revit.DB.MEPSystemClassification systemType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_Direction() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ConnectorElement GetLinkedConnectorElement() => throw new System.NotImplementedException();
	public virtual void SetLinkedConnectorElement(Autodesk.Revit.DB.ConnectorElement otherConnector) => throw new System.NotImplementedException();
	public virtual void AssignAsPrimary() => throw new System.NotImplementedException();
	public virtual void FlipDirection() => throw new System.NotImplementedException();
	public virtual void ChangeHostReference(Autodesk.Revit.DB.Reference planarFace,Autodesk.Revit.DB.Edge edge) => throw new System.NotImplementedException();
	public virtual void ChangeHostReference(Autodesk.Revit.DB.Reference planarFace) => throw new System.NotImplementedException();
}
