namespace Speckle.Revit2023.Interfaces;

public interface IRevitLocationCurve : IRevitLocation
{
  IRevitCurve Curve { get; }
}