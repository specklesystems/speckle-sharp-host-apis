namespace Autodesk.Revit.DB;

public partial class SpatialElementCalculationPoint : Autodesk.Revit.DB.SpatialElementCalculationLocation
{
	public SpatialElementCalculationPoint() {}
	public virtual Autodesk.Revit.DB.XYZ Position
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
