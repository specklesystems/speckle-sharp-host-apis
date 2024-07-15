namespace Autodesk.Revit.DB;

public partial class BoundingBoxIsInsideFilter : Autodesk.Revit.DB.ElementQuickFilter
{
	public BoundingBoxIsInsideFilter() {}
	public BoundingBoxIsInsideFilter(Autodesk.Revit.DB.Outline outline,System.Double tolerance,System.Boolean inverted) => throw new System.NotImplementedException();
	public BoundingBoxIsInsideFilter(Autodesk.Revit.DB.Outline outline,System.Double tolerance) => throw new System.NotImplementedException();
	public BoundingBoxIsInsideFilter(Autodesk.Revit.DB.Outline outline,System.Boolean inverted) => throw new System.NotImplementedException();
	public BoundingBoxIsInsideFilter(Autodesk.Revit.DB.Outline outline) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Outline GetBoundingBox() => throw new System.NotImplementedException();
	public virtual System.Double Tolerance
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
