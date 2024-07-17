namespace Autodesk.Revit.DB;

public partial class BrowserOrganization : Autodesk.Revit.DB.ElementType
{
  public BrowserOrganization() { }

  public virtual System.Boolean AreFiltersSatisfied(Autodesk.Revit.DB.ElementId elementId) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FolderItemInfo> GetFolderItems(
    Autodesk.Revit.DB.ElementId elementId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.BrowserOrganization GetCurrentBrowserOrganizationForViews(
    Autodesk.Revit.DB.Document document
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.BrowserOrganization GetCurrentBrowserOrganizationForSheets(
    Autodesk.Revit.DB.Document document
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.BrowserOrganization GetCurrentBrowserOrganizationForSchedules(
    Autodesk.Revit.DB.Document document
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.SortingOrder SortingOrder
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.BrowserOrganizationType Type
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId SortingParameterId
  {
    get => throw new System.NotImplementedException();
  }
}
