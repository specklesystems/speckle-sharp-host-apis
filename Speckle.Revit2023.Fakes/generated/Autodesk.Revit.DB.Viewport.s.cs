namespace Autodesk.Revit.DB;

public partial class Viewport : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.ViewportPositioning get_ViewportPositioning() => throw new System.NotImplementedException();
	public virtual void set_ViewportPositioning(Autodesk.Revit.DB.ViewportPositioning viewportPositioning) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_ViewId() => throw new System.NotImplementedException();
	public virtual void set_ViewId(Autodesk.Revit.DB.ElementId viewId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_SheetId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ViewportRotation get_Rotation() => throw new System.NotImplementedException();
	public virtual void set_Rotation(Autodesk.Revit.DB.ViewportRotation viewportRotation) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_LabelOffset() => throw new System.NotImplementedException();
	public virtual void set_LabelOffset(Autodesk.Revit.DB.XYZ originOffset) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Outline GetBoxOutline() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetBoxCenter() => throw new System.NotImplementedException();
	public virtual void SetBoxCenter(Autodesk.Revit.DB.XYZ newCenterPoint) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Outline GetLabelOutline() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform GetProjectionToSheetTransform() => throw new System.NotImplementedException();
}
