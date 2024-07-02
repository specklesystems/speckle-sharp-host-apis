namespace Autodesk.Revit.DB;

public partial class ViewPlan : Autodesk.Revit.DB.View
{
	public ViewPlan() {}
	public static Autodesk.Revit.DB.ViewPlan Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId viewFamilyTypeId,Autodesk.Revit.DB.ElementId levelId) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ViewPlan CreateAreaPlan(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId areaSchemeId,Autodesk.Revit.DB.ElementId levelId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.PlanViewRange GetViewRange() => throw new System.NotImplementedException();
	public virtual void SetViewRange(Autodesk.Revit.DB.PlanViewRange planViewRange) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.PlanViewRangeError> CheckPlanViewRangeValidity(Autodesk.Revit.DB.PlanViewRange planViewRange) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetUnderlayBaseLevel() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetUnderlayTopLevel() => throw new System.NotImplementedException();
	public virtual void SetUnderlayBaseLevel(Autodesk.Revit.DB.ElementId levelId) => throw new System.NotImplementedException();
	public virtual void SetUnderlayRange(Autodesk.Revit.DB.ElementId baseLevelId,Autodesk.Revit.DB.ElementId topLevelId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.UnderlayOrientation GetUnderlayOrientation() => throw new System.NotImplementedException();
	public virtual void SetUnderlayOrientation(Autodesk.Revit.DB.UnderlayOrientation uo) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.AreaScheme AreaScheme
	{
		get => throw new System.NotImplementedException();
	}
}
