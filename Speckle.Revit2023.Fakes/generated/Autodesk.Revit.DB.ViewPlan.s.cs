namespace Autodesk.Revit.DB;

public partial class ViewPlan : Autodesk.Revit.DB.View
{
	public virtual Autodesk.Revit.DB.AreaScheme get_AreaScheme() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.PlanViewRange GetViewRange() => throw new System.NotImplementedException();
	public virtual void SetViewRange(Autodesk.Revit.DB.PlanViewRange planViewRange) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetUnderlayBaseLevel() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetUnderlayTopLevel() => throw new System.NotImplementedException();
	public virtual void SetUnderlayBaseLevel(Autodesk.Revit.DB.ElementId levelId) => throw new System.NotImplementedException();
	public virtual void SetUnderlayRange(Autodesk.Revit.DB.ElementId baseLevelId,Autodesk.Revit.DB.ElementId topLevelId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.UnderlayOrientation GetUnderlayOrientation() => throw new System.NotImplementedException();
	public virtual void SetUnderlayOrientation(Autodesk.Revit.DB.UnderlayOrientation uo) => throw new System.NotImplementedException();
}
