namespace Autodesk.Revit.DB;

public partial class FaceNode : Autodesk.Revit.DB.RenderNode
{
  public FaceNode() { }

  public virtual Autodesk.Revit.DB.Face GetFace() => throw new System.NotImplementedException();
}
