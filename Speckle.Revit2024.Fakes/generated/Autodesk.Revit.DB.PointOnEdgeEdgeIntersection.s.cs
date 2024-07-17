namespace Autodesk.Revit.DB;

public partial class PointOnEdgeEdgeIntersection : Autodesk.Revit.DB.PointElementReference
{
  public PointOnEdgeEdgeIntersection() { }

  public virtual Autodesk.Revit.DB.Reference GetEdgeReference1() => throw new System.NotImplementedException();

  public virtual void SetEdgeReference1(Autodesk.Revit.DB.Reference edgeReference) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Reference GetEdgeReference2() => throw new System.NotImplementedException();

  public virtual void SetEdgeReference2(Autodesk.Revit.DB.Reference edgeReference) =>
    throw new System.NotImplementedException();
}
