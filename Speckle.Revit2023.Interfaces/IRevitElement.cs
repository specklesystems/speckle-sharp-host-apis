namespace Speckle.Revit2023.Interfaces;

public interface IRevitElement
{
  IList<IRevitElementId> GetDependentElements(IRevitElementFilter filter);

  IRevitElementId Id { get; }
  IRevitElementId LevelId { get; }
  IRevitCategory Category { get; }
}