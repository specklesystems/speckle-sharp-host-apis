namespace Autodesk.Revit.DB;

public partial class VisibleInViewFilter : Autodesk.Revit.DB.ElementQuickFilter
{
  public VisibleInViewFilter() { }

  public VisibleInViewFilter(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId viewId,
    System.Boolean inverted
  ) => throw new System.NotImplementedException();

  public VisibleInViewFilter(Autodesk.Revit.DB.Document document, Autodesk.Revit.DB.ElementId viewId) =>
    throw new System.NotImplementedException();
}
