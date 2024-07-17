namespace Autodesk.Revit.DB.Structure;

public enum RebarFreeFormValidationResult
{
  Success,
  Undefined,
  NullCurve,
  UnboundCurve,
  InvalidLoop,
  RebarCantBeBent,
}
