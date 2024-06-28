namespace Autodesk.Revit.DB;

public partial class ViewNode : Autodesk.Revit.DB.RenderNode
{
	public virtual Autodesk.Revit.DB.ElementId get_ViewId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CameraInfo GetCameraInfo() => throw new System.NotImplementedException();
}
