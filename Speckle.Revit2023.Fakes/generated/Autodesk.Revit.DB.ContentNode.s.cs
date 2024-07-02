namespace Autodesk.Revit.DB;

public partial class ContentNode : Autodesk.Revit.DB.RenderNode
{
  public ContentNode() { }

  public virtual Autodesk.Revit.DB.Transform GetTransform() => throw new System.NotImplementedException();
}
