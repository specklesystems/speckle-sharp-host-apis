namespace Autodesk.Revit.DB;

public partial class ExportPDFSettings : Autodesk.Revit.DB.Element
{
  public static Autodesk.Revit.DB.ExportPDFSettings Create(
    Autodesk.Revit.DB.Document document,
    System.String name,
    Autodesk.Revit.DB.PDFExportOptions options
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<System.String> ListNames(Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsValidName(Autodesk.Revit.DB.Document document, System.String name) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ExportPDFSettings FindByName(
    Autodesk.Revit.DB.Document document,
    System.String name
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ExportPDFSettings GetActivePredefinedSettings(Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.PDFExportOptions GetOptions() => throw new System.NotImplementedException();

  public virtual void SetOptions(Autodesk.Revit.DB.PDFExportOptions options) =>
    throw new System.NotImplementedException();
}
