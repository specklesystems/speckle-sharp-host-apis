namespace Autodesk.Revit.DB.Architecture;

public partial class BuildingPad : Autodesk.Revit.DB.CeilingAndFloor
{
	public static Autodesk.Revit.DB.Architecture.BuildingPad Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId buildingPadTypeId,Autodesk.Revit.DB.ElementId levelId,IList<Autodesk.Revit.DB.CurveLoop> curveLoops) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.CurveLoop> GetBoundary() => throw new System.NotImplementedException();
	public virtual void SetBoundary(IList<Autodesk.Revit.DB.CurveLoop> curveLoops) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId AssociatedTopographySurfaceId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId HostId
	{
		get => throw new System.NotImplementedException();
	}
}
