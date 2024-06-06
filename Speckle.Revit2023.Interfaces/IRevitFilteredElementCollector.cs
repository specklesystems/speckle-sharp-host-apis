namespace Speckle.Revit2023.Interfaces;

public interface IRevitFilteredElementCollector : IRevitElementFilter
{
  IEnumerable<T> OfClass<T>();
}