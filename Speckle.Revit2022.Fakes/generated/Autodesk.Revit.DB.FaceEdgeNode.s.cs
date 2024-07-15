namespace Autodesk.Revit.DB;

public partial class FaceEdgeNode : Autodesk.Revit.DB.FaceDetailNode
{
	public FaceEdgeNode() {}
	public virtual Autodesk.Revit.DB.Edge GetFaceEdge() => throw new System.NotImplementedException();
}
