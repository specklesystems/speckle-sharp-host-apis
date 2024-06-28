namespace Autodesk.Revit.DB;

public partial class Floor : Autodesk.Revit.DB.CeilingAndFloor
{
	public virtual Autodesk.Revit.DB.XYZ GetVerticalProjectionPoint(Autodesk.Revit.DB.XYZ modelLocation,Autodesk.Revit.DB.FloorFace floorFace) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetNormalAtVerticalProjectionPoint(Autodesk.Revit.DB.XYZ modelLocation,Autodesk.Revit.DB.FloorFace floorFace) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId SketchId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.FloorType FloorType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.SlabShapeEditor SlabShapeEditor
	{
		get => throw new System.NotImplementedException();
	}
}
