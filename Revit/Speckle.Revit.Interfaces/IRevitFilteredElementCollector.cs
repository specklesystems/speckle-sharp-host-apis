namespace Speckle.Revit.Interfaces;

public interface IRevitFilteredElementCollector : IRevitElementFilter
{
  IEnumerable<T> OfClass<T>(IProxyMap proxyMap) ;
}
