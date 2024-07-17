namespace Autodesk.Revit.DB;

public enum ExternalResourceLoadStatus
{
  Success,
  Failure,
  Uninitialized,
  ResourceAlreadyCurrent,
  CannotFindServer,
  ServerThrewException,
}
