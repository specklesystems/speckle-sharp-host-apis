namespace Autodesk.Revit.DB;

public partial class BoundingBoxContainsPointFilter : Autodesk.Revit.DB.ElementQuickFilter
{
  public BoundingBoxContainsPointFilter(
    Autodesk.Revit.DB.XYZ point,
    System.Double tolerance,
    System.Boolean inverted
  ) => throw new System.NotImplementedException();

  public BoundingBoxContainsPointFilter(Autodesk.Revit.DB.XYZ point, System.Double tolerance) =>
    throw new System.NotImplementedException();

  public BoundingBoxContainsPointFilter(Autodesk.Revit.DB.XYZ point, System.Boolean inverted) =>
    throw new System.NotImplementedException();

  public BoundingBoxContainsPointFilter(Autodesk.Revit.DB.XYZ point) => throw new System.NotImplementedException();

  public virtual System.Double Tolerance
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ Point
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}
