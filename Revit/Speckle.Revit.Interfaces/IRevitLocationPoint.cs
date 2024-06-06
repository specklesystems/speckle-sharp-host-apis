namespace Speckle.Revit.Interfaces;

public interface IRevitLocationPoint : IRevitLocation
{
  IRevitXYZ Point { get; }
}
