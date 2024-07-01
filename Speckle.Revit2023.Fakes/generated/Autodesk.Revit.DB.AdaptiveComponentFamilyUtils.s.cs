namespace Autodesk.Revit.DB;

public partial class AdaptiveComponentFamilyUtils
{
  public static System.Boolean IsAdaptiveComponentFamily(Autodesk.Revit.DB.Family family) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsAdaptivePoint(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.ElementId refPointId
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsAdaptivePlacementPoint(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.ElementId refPointId
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsAdaptiveShapeHandlePoint(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.ElementId refPointId
  ) => throw new System.NotImplementedException();

  public static System.Int32 GetNumberOfAdaptivePoints(Autodesk.Revit.DB.Family family) =>
    throw new System.NotImplementedException();

  public static System.Int32 GetNumberOfPlacementPoints(Autodesk.Revit.DB.Family family) =>
    throw new System.NotImplementedException();

  public static System.Int32 GetNumberOfShapeHandlePoints(Autodesk.Revit.DB.Family family) =>
    throw new System.NotImplementedException();

  public static void MakeAdaptivePoint(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.ElementId refPointId,
    Autodesk.Revit.DB.AdaptivePointType type
  ) => throw new System.NotImplementedException();

  public static System.Int32 GetPlacementNumber(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.ElementId refPointId
  ) => throw new System.NotImplementedException();

  public static void SetPlacementNumber(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.ElementId refPointId,
    System.Int32 placementNumber
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.AdaptivePointOrientationType GetPointOrientationType(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.ElementId refPointId
  ) => throw new System.NotImplementedException();

  public static void SetPointOrientationType(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.ElementId refPointId,
    Autodesk.Revit.DB.AdaptivePointOrientationType orientationType
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.AdaptivePointConstraintType GetPointConstraintType(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.ElementId refPointId
  ) => throw new System.NotImplementedException();

  public static void SetPointConstraintType(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.ElementId refPointId,
    Autodesk.Revit.DB.AdaptivePointConstraintType constraintType
  ) => throw new System.NotImplementedException();
}
