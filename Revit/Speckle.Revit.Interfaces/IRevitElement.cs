namespace Speckle.Revit.Interfaces;

public interface IRevitElement
{
  IList<IRevitElementId> GetDependentElements(IRevitElementFilter filter);

  IRevitElementId Id { get; }
  IRevitElementId LevelId { get; }
  IRevitCategory Category { get; }
}
