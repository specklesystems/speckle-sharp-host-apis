namespace Autodesk.Revit.DB;

public partial class ViewFamilyType : Autodesk.Revit.DB.ElementType
{
	public virtual Autodesk.Revit.DB.ViewFamily ViewFamily
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId DefaultTemplateId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.PlanViewDirection PlanViewDirection
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
