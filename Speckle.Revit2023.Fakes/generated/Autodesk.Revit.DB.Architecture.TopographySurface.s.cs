namespace Autodesk.Revit.DB.Architecture;

public partial class TopographySurface : Autodesk.Revit.DB.Element
{
	public virtual void MovePoint(Autodesk.Revit.DB.XYZ movedPoint,Autodesk.Revit.DB.XYZ targetPoint) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Architecture.SiteSubRegion AsSiteSubRegion() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId MaterialId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId AssociatedBuildingPadId
	{
		get => throw new System.NotImplementedException();
	}
}
