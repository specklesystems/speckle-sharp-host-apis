namespace Autodesk.Revit.DB;

public partial class ConnectionValidationWarning : System.Object
{
	public ConnectionValidationWarning(Autodesk.Revit.DB.ConnectionResolution resolution,Autodesk.Revit.DB.ConnectionWarning reason,Autodesk.Revit.DB.ElementId part1,Autodesk.Revit.DB.ElementId part2) => throw new System.NotImplementedException();
	public virtual ISet<Autodesk.Revit.DB.ElementId> GetParts() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ConnectionWarning Reason
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ConnectionResolution Resolution
	{
		get => throw new System.NotImplementedException();
	}
}
