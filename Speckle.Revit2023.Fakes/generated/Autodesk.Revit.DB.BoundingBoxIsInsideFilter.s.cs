namespace Autodesk.Revit.DB;

public partial class BoundingBoxIsInsideFilter : Autodesk.Revit.DB.ElementQuickFilter
{
	public virtual Autodesk.Revit.DB.Outline GetBoundingBox() => throw new System.NotImplementedException();
	public virtual System.Double Tolerance
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
