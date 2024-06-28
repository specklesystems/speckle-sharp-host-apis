namespace Autodesk.Revit.DB.Architecture;

public partial class Room : Autodesk.Revit.DB.SpatialElement
{
	public virtual void Unplace() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Level UpperLimit
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.GeometryElement ClosedShell
	{
		get => throw new System.NotImplementedException();
	}
}
