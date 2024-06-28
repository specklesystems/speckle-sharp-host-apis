namespace Autodesk.Revit.DB.Architecture;

public partial class Room : Autodesk.Revit.DB.SpatialElement
{
	public virtual Autodesk.Revit.DB.GeometryElement get_ClosedShell() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Level get_UpperLimit() => throw new System.NotImplementedException();
	public virtual void set_UpperLimit(Autodesk.Revit.DB.Level plev) => throw new System.NotImplementedException();
	public virtual void Unplace() => throw new System.NotImplementedException();
}
