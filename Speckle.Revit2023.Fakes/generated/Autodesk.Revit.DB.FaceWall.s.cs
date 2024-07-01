namespace Autodesk.Revit.DB;

public partial class FaceWall : Autodesk.Revit.DB.HostObject
{
  public FaceWall() { }

  public static Autodesk.Revit.DB.FaceWall Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId wallType,
    Autodesk.Revit.DB.WallLocationLine locationLine,
    Autodesk.Revit.DB.Reference faceReference
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsWallTypeValidForFaceWall(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId wallType
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsValidFaceReferenceForFaceWall(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Reference faceReference
  ) => throw new System.NotImplementedException();
}
