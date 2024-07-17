namespace Autodesk.Revit.DB;

public partial class ElementIntersectsElementFilter : Autodesk.Revit.DB.ElementIntersectsFilter
{
  public ElementIntersectsElementFilter() { }

  public ElementIntersectsElementFilter(Autodesk.Revit.DB.Element element, System.Boolean inverted) =>
    throw new System.NotImplementedException();

  public ElementIntersectsElementFilter(Autodesk.Revit.DB.Element element) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Element GetElement() => throw new System.NotImplementedException();
}
