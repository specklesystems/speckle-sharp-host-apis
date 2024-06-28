namespace Autodesk.Revit.DB.Architecture;

public partial class Room : Autodesk.Revit.DB.SpatialElement
{
	public virtual void Unplace() => throw new System.NotImplementedException();
	public virtual System.Boolean IsPointInRoom(Autodesk.Revit.DB.XYZ point) => throw new System.NotImplementedException();
	public virtual System.Double Volume
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double UnboundedHeight
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double BaseOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double LimitOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
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
