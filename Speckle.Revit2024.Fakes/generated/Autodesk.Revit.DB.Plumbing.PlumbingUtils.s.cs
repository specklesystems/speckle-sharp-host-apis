namespace Autodesk.Revit.DB.Plumbing;

public partial class PlumbingUtils
{
  public PlumbingUtils() { }

  public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> ConvertPipePlaceholders(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> placeholderIds
  ) => throw new System.NotImplementedException();

  public static System.Boolean ConnectPipePlaceholdersAtElbow(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Connector connector1,
    Autodesk.Revit.DB.Connector connector2
  ) => throw new System.NotImplementedException();

  public static System.Boolean ConnectPipePlaceholdersAtElbow(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId placeholder1Id,
    Autodesk.Revit.DB.ElementId placeholder2Id
  ) => throw new System.NotImplementedException();

  public static System.Boolean ConnectPipePlaceholdersAtTee(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Connector connector1,
    Autodesk.Revit.DB.Connector connector2,
    Autodesk.Revit.DB.Connector connector3
  ) => throw new System.NotImplementedException();

  public static System.Boolean ConnectPipePlaceholdersAtTee(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId placeholder1Id,
    Autodesk.Revit.DB.ElementId placeholder2Id
  ) => throw new System.NotImplementedException();

  public static System.Boolean ConnectPipePlaceholdersAtCross(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Connector connector1,
    Autodesk.Revit.DB.Connector connector2,
    Autodesk.Revit.DB.Connector connector3,
    Autodesk.Revit.DB.Connector connector4
  ) => throw new System.NotImplementedException();

  public static System.Boolean ConnectPipePlaceholdersAtCross(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId placeholder1Id,
    Autodesk.Revit.DB.ElementId placeholder2Id,
    Autodesk.Revit.DB.ElementId placeholder3Id
  ) => throw new System.NotImplementedException();

  public static System.Boolean ConnectPipePlaceholdersAtCross(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId placeholder1Id,
    Autodesk.Revit.DB.ElementId placeholder2Id
  ) => throw new System.NotImplementedException();

  public static void PlaceCapOnOpenEnds(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId elemId,
    Autodesk.Revit.DB.ElementId typeId
  ) => throw new System.NotImplementedException();

  public static System.Boolean HasOpenConnector(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId elemId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ElementId BreakCurve(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId pipeId,
    Autodesk.Revit.DB.XYZ ptBreak
  ) => throw new System.NotImplementedException();
}
