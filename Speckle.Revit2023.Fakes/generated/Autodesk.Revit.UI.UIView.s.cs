namespace Autodesk.Revit.UI;

public partial class UIView : System.Object
{
	public virtual Autodesk.Revit.DB.ElementId get_ViewId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Rectangle GetWindowRectangle() => throw new System.NotImplementedException();
	public virtual void Close() => throw new System.NotImplementedException();
	public virtual void ZoomToFit() => throw new System.NotImplementedException();
	public virtual void ZoomSheetSize() => throw new System.NotImplementedException();
	public virtual void ZoomAndCenterRectangle(Autodesk.Revit.DB.XYZ viewCorner1,Autodesk.Revit.DB.XYZ viewCorner2) => throw new System.NotImplementedException();
	}