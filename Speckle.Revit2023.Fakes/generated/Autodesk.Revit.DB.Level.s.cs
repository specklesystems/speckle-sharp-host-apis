namespace Autodesk.Revit.DB;

public partial class Level : Autodesk.Revit.DB.DatumPlane
{
	public virtual Autodesk.Revit.DB.Reference GetPlaneReference() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId FindAssociatedPlanViewId() => throw new System.NotImplementedException();
}
