namespace Autodesk.Revit.DB;

public partial class PointRelativeToPoint : Autodesk.Revit.DB.PointElementReference
{
  public virtual Autodesk.Revit.DB.Reference GetHostPointReference() => throw new System.NotImplementedException();

  public virtual void SetHostPointReference(Autodesk.Revit.DB.Reference hostPointReference) =>
    throw new System.NotImplementedException();
}
