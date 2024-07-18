namespace Autodesk.Revit.DB.Architecture;

public enum WinderPathResult
{
  Success,
  NumberOutOfRange,
  Unbound,
  Noncontinuous,
  NotOpenLoop,
  TooShort,
  ColinearOrOverlap,
  SelfIntersect,
  InvalidCurveType,
  NotSupported,
}
