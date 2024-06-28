namespace Autodesk.Revit.DB;

public partial class Viewport : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.Outline GetBoxOutline() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetBoxCenter() => throw new System.NotImplementedException();
	public virtual void SetBoxCenter(Autodesk.Revit.DB.XYZ newCenterPoint) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Outline GetLabelOutline() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform GetProjectionToSheetTransform() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ LabelOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ViewportRotation Rotation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId SheetId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId ViewId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ViewportPositioning ViewportPositioning
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}
