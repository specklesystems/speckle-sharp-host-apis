namespace Autodesk.Revit.DB;

public partial class ImportInstance : Autodesk.Revit.DB.Instance
{
  public ImportInstance() { }

  public virtual Autodesk.Revit.DB.FamilyElementVisibility GetVisibility() =>
    throw new System.NotImplementedException();

  public virtual void SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility visibility) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ImportInstance Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.View DBView,
    Autodesk.Revit.DB.ExternalResourceReference resourceReference,
    Autodesk.Revit.DB.ImportOptions3DM options,
    out Autodesk.Revit.DB.LinkLoadResult linkLoadResult
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ImportInstance Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.View DBView,
    Autodesk.Revit.DB.ExternalResourceReference resourceReference,
    Autodesk.Revit.DB.SKPImportOptions options,
    out Autodesk.Revit.DB.LinkLoadResult linkLoadResult
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ImportInstance Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.View DBView,
    Autodesk.Revit.DB.ExternalResourceReference resourceReference,
    Autodesk.Revit.DB.SATImportOptions options,
    out Autodesk.Revit.DB.LinkLoadResult linkLoadResult
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ImportInstance Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.View DBView,
    Autodesk.Revit.DB.ExternalResourceReference resourceReference,
    Autodesk.Revit.DB.DGNImportOptions options,
    out Autodesk.Revit.DB.LinkLoadResult linkLoadResult
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ImportInstance Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId typeId,
    Autodesk.Revit.DB.View DBView
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ImportInstance Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.View DBView,
    Autodesk.Revit.DB.ExternalResourceReference resourceReference,
    Autodesk.Revit.DB.DWGImportOptions options,
    out Autodesk.Revit.DB.LinkLoadResult linkLoadResult
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ImportInstance Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.View DBView,
    System.String path,
    Autodesk.Revit.DB.DWGImportOptions options,
    out Autodesk.Revit.DB.LinkLoadResult linkLoadResult
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsLinked
  {
    get => throw new System.NotImplementedException();
  }
}
