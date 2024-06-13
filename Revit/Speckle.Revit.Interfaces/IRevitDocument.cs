#pragma warning disable CA1040

namespace Speckle.Revit.Interfaces;

public interface IRevitDocument : IRevitObject
{
  string PathName { get; }
  bool IsFamilyDocument { get; }
  IRevitUnits GetUnits();

  IRevitElement? GetElement(IRevitElementId elementId);
}
