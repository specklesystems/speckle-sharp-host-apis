namespace Autodesk.Revit.DB.Analysis;

public partial class RouteAnalysisSettings : Autodesk.Revit.DB.Element
{
	public RouteAnalysisSettings() {}
	public static Autodesk.Revit.DB.Analysis.RouteAnalysisSettings GetRouteAnalysisSettings(Autodesk.Revit.DB.Document cda) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetIgnoredCategoryIds() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetExcludedCategoryIds() => throw new System.NotImplementedException();
	public virtual void SetIgnoredCategoryIds(System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> categoryIds) => throw new System.NotImplementedException();
	public virtual System.Boolean IsLargeGeometryAllowed() => throw new System.NotImplementedException();
	public virtual System.Double MinimumLength
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double AnalysisZoneTopOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double AnalysisZoneBottomOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IgnoreImports
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean EnableIgnoredCategoryIds
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
