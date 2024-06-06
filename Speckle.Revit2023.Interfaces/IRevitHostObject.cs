namespace Speckle.Revit2023.Interfaces;

public interface IRevitHostObject : IRevitElement
{
  IList<IRevitElementId> FindInserts(
    bool addRectOpenings,
    bool includeShadows,
    bool includeEmbeddedWalls,
    bool includeSharedEmbeddedInserts
  );
}