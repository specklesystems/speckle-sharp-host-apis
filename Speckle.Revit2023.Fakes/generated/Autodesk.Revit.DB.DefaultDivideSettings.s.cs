namespace Autodesk.Revit.DB;

public partial class DefaultDivideSettings : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.SpacingRuleLayout GetSurfaceLayout(Autodesk.Revit.DB.UVGridlineType gridlines) => throw new System.NotImplementedException();
	public virtual void SetSurfaceLayout(Autodesk.Revit.DB.UVGridlineType gridlines,Autodesk.Revit.DB.SpacingRuleLayout layout) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DividedPathMeasurementType PathMeasurementType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.SpacingRuleLayout PathLayout
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
