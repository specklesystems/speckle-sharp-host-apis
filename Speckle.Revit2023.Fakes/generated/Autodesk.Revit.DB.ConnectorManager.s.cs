namespace Autodesk.Revit.DB;

public partial class ConnectorManager : System.IDisposable
{
	public ConnectorManager() {}
	public virtual Autodesk.Revit.DB.Connector Lookup(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Element Owner
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ConnectorSet UnusedConnectors
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ConnectorSet Connectors
	{
		get => throw new System.NotImplementedException();
	}
}
