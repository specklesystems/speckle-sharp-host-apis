namespace Autodesk.Revit.DB;

public enum LinkLoadResultType
{
  Uninitialized,
  LinkLoaded,
  LinkNotFound,
  LinkNotOpenable,
  LinkOpenAsHost,
  SameModelAsHost,
  SameCentralModelAsHost,
  LinkNotLoadedOtherError,
  LinkMayBeUpgraded,
  ExternalServerMissing,
  LinkExists,
  CouldNotChangeViewReference,
  UsedExisting,
}
