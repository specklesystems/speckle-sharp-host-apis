namespace Speckle.Revit.Interfaces;

public interface IRevitForgeTypeId : IRevitObject
{
  string TypeId { get; }
  bool Empty();
}
