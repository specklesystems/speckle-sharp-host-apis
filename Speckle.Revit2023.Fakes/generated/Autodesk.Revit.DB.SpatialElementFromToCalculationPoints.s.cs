namespace Autodesk.Revit.DB;

public partial class SpatialElementFromToCalculationPoints : Autodesk.Revit.DB.SpatialElementCalculationLocation
{
	public virtual void Flip() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ MakeFromPositionAcceptable(Autodesk.Revit.DB.XYZ newFromLocation) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ MakeToPositionAcceptable(Autodesk.Revit.DB.XYZ newToLocation) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ ToPosition
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.XYZ FromPosition
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
