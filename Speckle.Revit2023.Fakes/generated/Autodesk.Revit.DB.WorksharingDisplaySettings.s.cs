namespace Autodesk.Revit.DB;

public partial class WorksharingDisplaySettings : Autodesk.Revit.DB.Element
{
  public WorksharingDisplaySettings() { }

  public static Autodesk.Revit.DB.WorksharingDisplaySettings GetOrCreateWorksharingDisplaySettings(
    Autodesk.Revit.DB.Document doc
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean UserHasGraphicOverrides(System.String username) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CanUserHaveOverrides(System.String username) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 RestoreUsers(System.Collections.Generic.ICollection<System.String> usersToRestore) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<System.String> GetRemovedUsers() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<System.String> GetAllUsersWithGraphicOverrides() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.WorksharingDisplayGraphicSettings GetGraphicOverrides(
    Autodesk.Revit.DB.WorksetId worksetId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.WorksharingDisplayGraphicSettings GetGraphicOverrides(System.String username) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.WorksharingDisplayGraphicSettings GetGraphicOverrides(
    Autodesk.Revit.DB.ModelUpdatesStatus statusInCentral
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.WorksharingDisplayGraphicSettings GetGraphicOverrides(
    Autodesk.Revit.DB.CheckoutStatus ownershipStatus
  ) => throw new System.NotImplementedException();

  public virtual void SetGraphicOverrides(
    Autodesk.Revit.DB.WorksetId worksetId,
    Autodesk.Revit.DB.WorksharingDisplayGraphicSettings overrides
  ) => throw new System.NotImplementedException();

  public virtual void SetGraphicOverrides(
    Autodesk.Revit.DB.CheckoutStatus status,
    Autodesk.Revit.DB.WorksharingDisplayGraphicSettings overrides
  ) => throw new System.NotImplementedException();

  public virtual void SetGraphicOverrides(
    Autodesk.Revit.DB.ModelUpdatesStatus status,
    Autodesk.Revit.DB.WorksharingDisplayGraphicSettings overrides
  ) => throw new System.NotImplementedException();

  public virtual void SetGraphicOverrides(
    System.String username,
    Autodesk.Revit.DB.WorksharingDisplayGraphicSettings overrides
  ) => throw new System.NotImplementedException();
}
