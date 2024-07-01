namespace Autodesk.Revit.DB;

public partial class BRepBuilderEdgeGeometry : System.IDisposable
{
  public BRepBuilderEdgeGeometry() { }

  public static Autodesk.Revit.DB.BRepBuilderEdgeGeometry Create(
    Autodesk.Revit.DB.XYZ startPoint,
    Autodesk.Revit.DB.XYZ endPoint
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.BRepBuilderEdgeGeometry Create(Autodesk.Revit.DB.Curve curve) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
