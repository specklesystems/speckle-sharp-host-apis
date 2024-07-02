namespace Autodesk.Revit.DB;

public partial class FaceDetailNode : Autodesk.Revit.DB.RenderNode
{
	public FaceDetailNode() {}
	public virtual Autodesk.Revit.DB.Transform GetLinkTransform() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform GetInstanceTransform() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LineProperties LineProperties
	{
		get => throw new System.NotImplementedException();
	}
}
