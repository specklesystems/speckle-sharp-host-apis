namespace Speckle.Revit.Interfaces;

public interface IRevitLocationCurve : IRevitLocation
{
  IRevitCurve Curve { get; }
}
