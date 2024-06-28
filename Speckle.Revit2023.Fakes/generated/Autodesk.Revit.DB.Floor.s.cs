namespace Autodesk.Revit.DB;

public partial class Floor : Autodesk.Revit.DB.CeilingAndFloor
{
	public virtual Autodesk.Revit.DB.SlabShapeEditor get_SlabShapeEditor() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetVerticalProjectionPoint(Autodesk.Revit.DB.XYZ modelLocation,Autodesk.Revit.DB.FloorFace floorFace) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetNormalAtVerticalProjectionPoint(Autodesk.Revit.DB.XYZ modelLocation,Autodesk.Revit.DB.FloorFace floorFace) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FloorType get_FloorType() => throw new System.NotImplementedException();
	public virtual void set_FloorType(Autodesk.Revit.DB.FloorType attribute) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_SketchId() => throw new System.NotImplementedException();
}
