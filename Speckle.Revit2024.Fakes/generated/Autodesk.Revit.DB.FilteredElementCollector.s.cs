namespace Autodesk.Revit.DB;

public partial class FilteredElementCollector
  : System.Collections.Generic.IEnumerable<Autodesk.Revit.DB.Element>,
    System.Collections.IEnumerable,
    System.IDisposable
{
  public FilteredElementCollector() { }

  public FilteredElementCollector(
    Autodesk.Revit.DB.Document hostDocument,
    Autodesk.Revit.DB.ElementId viewId,
    Autodesk.Revit.DB.ElementId linkId
  ) => throw new System.NotImplementedException();

  public FilteredElementCollector(Autodesk.Revit.DB.Document document, Autodesk.Revit.DB.ElementId viewId) =>
    throw new System.NotImplementedException();

  public FilteredElementCollector(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementIds
  ) => throw new System.NotImplementedException();

  public FilteredElementCollector(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FilteredElementCollector OfCategory(Autodesk.Revit.DB.BuiltInCategory category) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FilteredElementIdIterator GetElementIdIterator() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FilteredElementIterator GetElementIterator() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FilteredElementCollector WherePasses(Autodesk.Revit.DB.ElementFilter filter) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FilteredElementCollector IntersectWith(
    Autodesk.Revit.DB.FilteredElementCollector other
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FilteredElementCollector UnionWith(
    Autodesk.Revit.DB.FilteredElementCollector other
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FilteredElementCollector OfClass(System.Type type) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FilteredElementCollector OfCategoryId(Autodesk.Revit.DB.ElementId categoryId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FilteredElementCollector WhereElementIsElementType() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FilteredElementCollector WhereElementIsNotElementType() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FilteredElementCollector OwnedByView(Autodesk.Revit.DB.ElementId viewId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FilteredElementCollector WhereElementIsViewIndependent() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FilteredElementCollector ContainedInDesignOption(
    Autodesk.Revit.DB.ElementId designOptionId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FilteredElementCollector WhereElementIsCurveDriven() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FilteredElementCollector Excluding(
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> idsToExclude
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 GetElementCount() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> ToElementIds() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Element> ToElements() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId FirstElementId() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Element FirstElement() => throw new System.NotImplementedException();

  public static System.Boolean IsViewValidForElementIteration(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId viewId
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.Element> GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
