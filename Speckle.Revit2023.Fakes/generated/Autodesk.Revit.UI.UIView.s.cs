namespace Autodesk.Revit.UI;

public partial class UIView : System.Object
{
	public virtual Autodesk.Revit.DB.Rectangle GetWindowRectangle() => throw new System.NotImplementedException();
	public virtual void Close() => throw new System.NotImplementedException();
	public virtual void ZoomToFit() => throw new System.NotImplementedException();
	public virtual void Zoom(System.Double zoomFactor) => throw new System.NotImplementedException();
	public virtual void ZoomSheetSize() => throw new System.NotImplementedException();
	public virtual void ZoomAndCenterRectangle(Autodesk.Revit.DB.XYZ viewCorner1,Autodesk.Revit.DB.XYZ viewCorner2) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.XYZ> GetZoomCorners() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId ViewId
	{
		get => throw new System.NotImplementedException();
	}
}
