namespace Autodesk.Revit.DB.Structure;

public partial class Hub : Autodesk.Revit.DB.Element
{
	public Hub() {}
	public virtual System.Boolean HasOrigin() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetOrigin() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ConnectorManager GetHubConnectorManager() => throw new System.NotImplementedException();
}
