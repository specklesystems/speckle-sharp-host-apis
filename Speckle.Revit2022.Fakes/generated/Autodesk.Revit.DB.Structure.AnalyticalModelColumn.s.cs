namespace Autodesk.Revit.DB.Structure;

public partial class AnalyticalModelColumn : Autodesk.Revit.DB.Structure.AnalyticalModelStick
{
	public AnalyticalModelColumn() {}
	public virtual Autodesk.Revit.DB.Structure.StickElementExtension TopExtension
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.StickElementExtension BaseExtension
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId TopExtensionPlaneId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId BaseExtensionPlaneId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod TopExtensionMethod
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod BaseExtensionMethod
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
