namespace Speckle.Revit.Interfaces;

public interface IRevitCurveElement : IRevitElement
{
  IRevitCurve GeometryCurve { get; }
  IRevitSketchPlane SketchPlane { get; }
}
