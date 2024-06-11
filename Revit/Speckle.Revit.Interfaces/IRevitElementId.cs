namespace Speckle.Revit.Interfaces;

public interface IRevitElementId : IRevitObject
{
  int IntegerValue { get; }
}
