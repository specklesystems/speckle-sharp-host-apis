namespace Autodesk.Revit.DB;

public partial class FaceSilhouetteNode : Autodesk.Revit.DB.FaceDetailNode
{
  public FaceSilhouetteNode() { }

  public virtual Autodesk.Revit.DB.Face GetFace() => throw new System.NotImplementedException();
}
