namespace Autodesk.Revit.DB;

public partial class Level : Autodesk.Revit.DB.DatumPlane
{
	public Level() {}
	public static Autodesk.Revit.DB.Level Create(Autodesk.Revit.DB.Document document,System.Double elevation) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference GetPlaneReference() => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ElementId GetNearestLevelId(Autodesk.Revit.DB.Document document,System.Double elevation) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId FindAssociatedPlanViewId() => throw new System.NotImplementedException();
	public virtual System.Double ProjectElevation
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Elevation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
