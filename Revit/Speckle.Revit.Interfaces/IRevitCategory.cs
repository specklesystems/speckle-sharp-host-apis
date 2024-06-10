namespace Speckle.Revit.Interfaces;

public interface IRevitCategory : IRevitObject
{
  string Name { get; }
  IRevitElementId Id { get; }
}
