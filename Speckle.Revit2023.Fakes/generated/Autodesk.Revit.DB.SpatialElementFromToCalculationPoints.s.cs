namespace Autodesk.Revit.DB;

public partial class SpatialElementFromToCalculationPoints : Autodesk.Revit.DB.SpatialElementCalculationLocation
{
	public virtual Autodesk.Revit.DB.XYZ get_FromPosition() => throw new System.NotImplementedException();
	public virtual void set_FromPosition(Autodesk.Revit.DB.XYZ fromPosition) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_ToPosition() => throw new System.NotImplementedException();
	public virtual void set_ToPosition(Autodesk.Revit.DB.XYZ toPosition) => throw new System.NotImplementedException();
	public virtual void Flip() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ MakeFromPositionAcceptable(Autodesk.Revit.DB.XYZ newFromLocation) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ MakeToPositionAcceptable(Autodesk.Revit.DB.XYZ newToLocation) => throw new System.NotImplementedException();
}
