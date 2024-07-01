namespace Autodesk.Revit.DB;

public enum FailureProcessingResult
{
  Continue,
  ProceedWithCommit,
  ProceedWithRollBack,
  WaitForUserInput,
}
