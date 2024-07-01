namespace Autodesk.Revit.DB;

public partial class DeleteElements : Autodesk.Revit.DB.FailureResolution
{
  public static Autodesk.Revit.DB.FailureResolution Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId id
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.FailureResolution Create(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> ids
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.FailureResolution Create(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> ids
  ) => throw new System.NotImplementedException();
}
