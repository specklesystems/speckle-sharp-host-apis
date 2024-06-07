namespace Speckle.Revit.Interfaces;

public interface IRevitCurveElement : IRevitObject
{
  IRevitCurve GeometryCurve { get; }
}
