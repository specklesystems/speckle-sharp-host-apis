namespace Speckle.Revit.Interfaces;

#pragma warning disable CA1040
public interface IRevitFilterFactory 
{
  IRevitElementIsElementTypeFilter CreateElementIsElementTypeFilter(bool inverted);
  IRevitElementMulticategoryFilter CreateElementMulticategoryFilter(
    ICollection<RevitBuiltInCategory> categories,
    bool inverted
  );
  IRevitLogicalAndFilterFilter CreateLogicalAndFilter(params IRevitElementFilter[] filters);
  IRevitFilteredElementCollector CreateFilteredElementCollector(
    IRevitDocument document,
    params IRevitElementId[] elementIds
  );
}
