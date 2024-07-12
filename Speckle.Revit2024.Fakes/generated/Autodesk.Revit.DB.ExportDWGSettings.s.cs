namespace Autodesk.Revit.DB;

public partial class ExportDWGSettings : Autodesk.Revit.DB.Element
{
  public ExportDWGSettings() { }

  public static Autodesk.Revit.DB.ExportDWGSettings Create(
    Autodesk.Revit.DB.Document document,
    System.String name,
    Autodesk.Revit.DB.DXFExportOptions options
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ExportDWGSettings Create(
    Autodesk.Revit.DB.Document document,
    System.String name,
    Autodesk.Revit.DB.DWGExportOptions options
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ExportDWGSettings Create(Autodesk.Revit.DB.Document document, System.String name) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.DWGExportOptions GetDWGExportOptions() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.DXFExportOptions GetDXFExportOptions() => throw new System.NotImplementedException();

  public virtual void SetDWGExportOptions(Autodesk.Revit.DB.DWGExportOptions options) =>
    throw new System.NotImplementedException();

  public virtual void SetDXFExportOptions(Autodesk.Revit.DB.DXFExportOptions options) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ExportDWGSettings FindByName(Autodesk.Revit.DB.Document aDoc, System.String name) =>
    throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<System.String> ListNames(Autodesk.Revit.DB.Document aDoc) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ExportDWGSettings GetActivePredefinedSettings(Autodesk.Revit.DB.Document aDoc) =>
    throw new System.NotImplementedException();
}
