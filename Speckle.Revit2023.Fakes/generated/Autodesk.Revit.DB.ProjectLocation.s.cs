namespace Autodesk.Revit.DB;

public partial class ProjectLocation : Autodesk.Revit.DB.Instance
{
  public ProjectLocation() { }

  public virtual Autodesk.Revit.DB.ProjectPosition GetProjectPosition(Autodesk.Revit.DB.XYZ point) =>
    throw new System.NotImplementedException();

  public virtual void SetProjectPosition(Autodesk.Revit.DB.XYZ point, Autodesk.Revit.DB.ProjectPosition position) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.SiteLocation GetSiteLocation() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ProjectLocation Duplicate(System.String name) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsProjectLocationNameUnique(
    Autodesk.Revit.DB.Document document,
    System.String name,
    Autodesk.Revit.DB.ElementId siteLocationId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ProjectLocation Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId siteLocationId,
    System.String name
  ) => throw new System.NotImplementedException();
}
