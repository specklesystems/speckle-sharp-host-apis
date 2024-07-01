namespace Autodesk.Revit.DB;

public partial class UpdaterRegistry : System.IDisposable
{
  public static void RegisterUpdater(
    Autodesk.Revit.DB.IUpdater updater,
    Autodesk.Revit.DB.Document document,
    System.Boolean isOptional
  ) => throw new System.NotImplementedException();

  public static void RegisterUpdater(Autodesk.Revit.DB.IUpdater updater, System.Boolean isOptional) =>
    throw new System.NotImplementedException();

  public static void RegisterUpdater(Autodesk.Revit.DB.IUpdater updater, Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public static void RegisterUpdater(Autodesk.Revit.DB.IUpdater updater) => throw new System.NotImplementedException();

  public static void UnregisterUpdater(Autodesk.Revit.DB.UpdaterId id, Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public static void UnregisterUpdater(Autodesk.Revit.DB.UpdaterId id) => throw new System.NotImplementedException();

  public static System.Boolean IsUpdaterRegistered(
    Autodesk.Revit.DB.UpdaterId id,
    Autodesk.Revit.DB.Document document
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsUpdaterRegistered(Autodesk.Revit.DB.UpdaterId id) =>
    throw new System.NotImplementedException();

  public static void SetExecutionOrder(Autodesk.Revit.DB.UpdaterId first, Autodesk.Revit.DB.UpdaterId second) =>
    throw new System.NotImplementedException();

  public static void AddTrigger(
    Autodesk.Revit.DB.UpdaterId id,
    Autodesk.Revit.DB.ElementFilter filter,
    Autodesk.Revit.DB.ChangeType change
  ) => throw new System.NotImplementedException();

  public static void AddTrigger(
    Autodesk.Revit.DB.UpdaterId id,
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementFilter filter,
    Autodesk.Revit.DB.ChangeType change
  ) => throw new System.NotImplementedException();

  public static void AddTrigger(
    Autodesk.Revit.DB.UpdaterId id,
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elements,
    Autodesk.Revit.DB.ChangeType change
  ) => throw new System.NotImplementedException();

  public static void RemoveAllTriggers(Autodesk.Revit.DB.UpdaterId id) => throw new System.NotImplementedException();

  public static void RemoveDocumentTriggers(Autodesk.Revit.DB.UpdaterId id, Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public static System.Boolean GetIsUpdaterOptional(Autodesk.Revit.DB.UpdaterId id) =>
    throw new System.NotImplementedException();

  public static void SetIsUpdaterOptional(Autodesk.Revit.DB.UpdaterId id, System.Boolean isOptional) =>
    throw new System.NotImplementedException();

  public static void EnableUpdater(Autodesk.Revit.DB.UpdaterId id) => throw new System.NotImplementedException();

  public static void DisableUpdater(Autodesk.Revit.DB.UpdaterId id) => throw new System.NotImplementedException();

  public static System.Boolean IsUpdaterEnabled(Autodesk.Revit.DB.UpdaterId id) =>
    throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<Autodesk.Revit.DB.UpdaterInfo> GetRegisteredUpdaterInfos() =>
    throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<Autodesk.Revit.DB.UpdaterInfo> GetRegisteredUpdaterInfos(
    Autodesk.Revit.DB.Document document
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}
