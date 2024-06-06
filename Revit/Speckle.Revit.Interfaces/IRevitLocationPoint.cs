namespace Speckle.Revit2023.Interfaces;

public interface IRevitLocationPoint : IRevitLocation
{
  IRevitXYZ Point { get; }
}