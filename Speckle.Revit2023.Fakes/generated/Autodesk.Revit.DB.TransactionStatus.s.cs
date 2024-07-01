namespace Autodesk.Revit.DB;

public enum TransactionStatus
{
  Uninitialized,
  Started,
  RolledBack,
  Committed,
  Pending,
  Error,
  Proceed,
}
