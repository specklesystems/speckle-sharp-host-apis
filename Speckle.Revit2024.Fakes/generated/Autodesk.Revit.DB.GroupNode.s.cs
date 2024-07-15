namespace Autodesk.Revit.DB;

public partial class GroupNode : Autodesk.Revit.DB.RenderNode
{
	public GroupNode() {}
	public virtual Autodesk.Revit.DB.Transform GetTransform() => throw new System.NotImplementedException();
}
