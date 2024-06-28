namespace Autodesk.Revit.DB;

public partial class MEPCurve : Autodesk.Revit.DB.HostObject
{
	public virtual Autodesk.Revit.DB.MEPSystem MEPSystem
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Level ReferenceLevel
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ConnectorManager ConnectorManager
	{
		get => throw new System.NotImplementedException();
	}
}
